namespace DatabaseConnection;

using Npgsql;
using System.Data;

public partial class DatabaseConnectionForm : Form
{
    public DatabaseConnectionForm()
    {
        InitializeComponent();
        buttonCheckConnection.Click += async (_, _) =>
    await CheckConnectionAsync();
    }

    /// <summary>
    /// Зчитує параметри конфігурації з файлу .env.
    /// </summary>
    private static Dictionary<string, string> LoadEnvironment()
    {
        string path = Path.Combine(AppContext.BaseDirectory, ".env");

        return File.ReadAllLines(path)
            .Where(line => !string.IsNullOrWhiteSpace(line)
                           && !line.TrimStart().StartsWith('#'))
            .Select(line => line.Split('=', 2))
            .Where(parts => parts.Length == 2)
            .ToDictionary(
                parts => parts[0].Trim(),
                parts => parts[1].Trim()
            );
    }

    /// <summary>
    /// Формує параметри підключення до PostgreSQL.
    /// </summary>
    private static string GetConnectionString()
    {
        var env = LoadEnvironment();

        var builder = new NpgsqlConnectionStringBuilder
        {
            Host = env["POSTGRES_HOST"],
            Port = int.Parse(env["POSTGRES_PORT"]),
            Database = env["POSTGRES_DB"],
            Username = env["POSTGRES_USER"],
            Password = env["POSTGRES_PASSWORD"]
        };

        return builder.ConnectionString;
    }

    /// <summary>
    /// Встановлює з'єднання з PostgreSQL, виконує SQL-запити
    /// та відображає результати у таблицях.
    /// </summary>
    private async Task CheckConnectionAsync()
    {
        buttonCheckConnection.Enabled = false;
        labelStatus.Text = "Підключення...";

        try
        {
            // Створюємо підключення до PostgreSQL
            await using var connection = new NpgsqlConnection(GetConnectionString());

            // Асинхронно відкриває з'єднання.
            await connection.OpenAsync();

            const string serverQuery = """
            SELECT
                current_database() AS database_name,
                current_user AS username,
                version() AS postgres_version,
                NOW() AS server_time;
            """;

            const string databaseQuery = """
            SELECT datname
            FROM pg_database
            WHERE datname = 'data_db';
            """;

            dataGridViewServer.DataSource = await ExecuteQueryAsync(connection, serverQuery);

            dataGridViewDatabases.DataSource = await ExecuteQueryAsync(connection, databaseQuery);

            labelStatus.Text = "Підключення успішне";
        }
        catch (Exception ex)
        {
            labelStatus.Text = "Помилка підключення";

            MessageBox.Show(
                ex.Message,
                "PostgreSQL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
        finally
        {
            buttonCheckConnection.Enabled = true;
        }
    }

    /// <summary>
    /// Виконує SQL-запит і повертає отримані записи у DataTable.
    /// </summary>
    private static async Task<DataTable> ExecuteQueryAsync(
        NpgsqlConnection connection,
        string sql)
    {
        // Передає SQL-запит серверу
        await using var command = new NpgsqlCommand(sql, connection);
        // Виконує запит і отримує результати
        await using var reader = await command.ExecuteReaderAsync();

        // Завантажує записи у таблицю пам'яті
        var table = new DataTable();
        table.Load(reader);

        return table;
    }
}
