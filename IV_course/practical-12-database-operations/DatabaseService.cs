using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperations;

using Npgsql;
using System.Data;

/// <summary>
/// Забезпечує підключення до PostgreSQL
/// та виконання SQL-запитів через ADO.NET.
/// </summary>
public class DatabaseService
{
    private readonly string connectionString;

    public DatabaseService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    /// <summary>
    /// Виконує SELECT-запит і повертає результат у DataTable.
    /// </summary>
    public async Task<DataTable> ExecuteQueryAsync(
        string sql,
        params NpgsqlParameter[] parameters)
    {
        await using var connection = new NpgsqlConnection(connectionString);
        await connection.OpenAsync();

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddRange(parameters);

        await using var reader = await command.ExecuteReaderAsync();

        var table = new DataTable();
        table.Load(reader);

        return table;
    }

    /// <summary>
    /// Виконує INSERT, UPDATE або DELETE
    /// і повертає кількість змінених записів.
    /// </summary>
    public async Task<int> ExecuteNonQueryAsync(
        string sql,
        params NpgsqlParameter[] parameters)
    {
        await using var connection = new NpgsqlConnection(connectionString);
        await connection.OpenAsync();

        await using var command = new NpgsqlCommand(sql, connection);
        command.Parameters.AddRange(parameters);

        return await command.ExecuteNonQueryAsync();
    }

    /// <summary>
    /// Зчитує параметри з .env і формує рядок підключення до PostgreSQL.
    /// </summary>
    public static string GetConnectionString()
    {
        string path = Path.Combine(AppContext.BaseDirectory, ".env");

        var env = File.ReadAllLines(path)
            .Where(line => !string.IsNullOrWhiteSpace(line)
                           && !line.TrimStart().StartsWith('#'))
            .Select(line => line.Split('=', 2))
            .Where(parts => parts.Length == 2)
            .ToDictionary(
                parts => parts[0].Trim(),
                parts => parts[1].Trim()
            );

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
}
