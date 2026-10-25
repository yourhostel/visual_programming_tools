using Npgsql;
using System.Data;

namespace DatabaseOperations;

/// <summary>
/// Реалізує операції з товарами в базі даних PostgreSQL.
/// </summary>
public class ProductService
{
    private readonly DatabaseService databaseService;

    /// <summary>
    /// Ініціалізує сервіс операцій із товарами.
    /// </summary>
    /// <param name="databaseService">Сервіс виконання SQL-запитів.</param>
    public ProductService(DatabaseService databaseService)
    {
        this.databaseService = databaseService;
    }

    /// <summary>
    /// Отримує всі товари, впорядковані за ідентифікатором.
    /// </summary>
    /// <returns>Таблиця з усіма товарами.</returns>
    public async Task<DataTable> GetAllAsync()
    {
        const string sql = """
            SELECT id, name, category, quantity, price, weight, created_at
            FROM public.products
            ORDER BY id;
            """;

        return await databaseService.ExecuteQueryAsync(sql);
    }

    /// <summary>
    /// Виконує вибірку товарів відповідно до вибраного типу запиту.
    /// </summary>
    /// <param name="queryType">Індекс типу запиту в ComboBox.</param>
    /// <param name="searchText">Текст пошуку за назвою або категорією.</param>
    /// <returns>Таблиця з результатами вибірки.</returns>
    public async Task<DataTable> SearchProductsAsync(
        int queryType,
        string searchText)
    {
        string sql = queryType switch
        {
            1 => """
                SELECT id, name, category, quantity, price, weight, created_at
                FROM public.products
                WHERE name ILIKE @search
                   OR category ILIKE @search
                ORDER BY id;
                """,

            2 => """
                SELECT id, name, category, quantity, price, weight, created_at
                FROM public.products
                WHERE quantity < @quantity
                ORDER BY id;
                """,

            _ => """
                SELECT id, name, category, quantity, price, weight, created_at
                FROM public.products
                ORDER BY id;
                """
        };

        return queryType switch
        {
            1 => await databaseService.ExecuteQueryAsync(
                sql,
                new NpgsqlParameter("search", $"%{searchText}%")
            ),

            2 => await databaseService.ExecuteQueryAsync(
                sql,
                new NpgsqlParameter("quantity", 20)
            ),

            _ => await databaseService.ExecuteQueryAsync(sql)
        };
    }

    /// <summary>
    /// Додає новий товар до бази даних PostgreSQL.
    /// </summary>
    /// <param name="name">Назва товару.</param>
    /// <param name="category">Категорія товару.</param>
    /// <param name="quantity">Кількість товару.</param>
    /// <param name="price">Ціна товару.</param>
    /// <param name="weight">Вага товару.</param>
    /// <returns>Кількість доданих записів.</returns>
    public async Task<int> AddAsync(
        string name,
        string category,
        int quantity,
        decimal price,
        double weight)
    {
        const string sql = """
        INSERT INTO public.products
            (name, category, quantity, price, weight)
        VALUES
            (@name, @category, @quantity, @price, @weight);
        """;

        return await databaseService.ExecuteNonQueryAsync(
            sql,
            new NpgsqlParameter("name", name),
            new NpgsqlParameter("category", category),
            new NpgsqlParameter("quantity", quantity),
            new NpgsqlParameter("price", price),
            new NpgsqlParameter("weight", weight)
        );
    }

    /// <summary>
    /// Видаляє товар із бази даних за ідентифікатором.
    /// </summary>
    /// <param name="id">Ідентифікатор товару.</param>
    /// <returns>Кількість видалених записів.</returns>
    public async Task<int> DeleteAsync(int id)
    {
        const string sql = """
        DELETE FROM public.products
        WHERE id = @id;
        """;

        return await databaseService.ExecuteNonQueryAsync(
            sql,
            new NpgsqlParameter("id", id)
        );
    }

    /// <summary>
    /// Оновлює дані товару в PostgreSQL за його ідентифікатором.
    /// </summary>
    /// <param name="id">Ідентифікатор товару.</param>
    /// <param name="name">Назва товару.</param>
    /// <param name="category">Категорія товару.</param>
    /// <param name="quantity">Кількість товару.</param>
    /// <param name="price">Ціна товару.</param>
    /// <param name="weight">Вага товару.</param>
    /// <returns>Кількість оновлених записів.</returns>
    public async Task<int> UpdateAsync(
        int id,
        string name,
        string category,
        int quantity,
        decimal price,
        double weight)
    {
        const string sql = """
        UPDATE public.products
        SET name = @name,
            category = @category,
            quantity = @quantity,
            price = @price,
            weight = @weight
        WHERE id = @id;
        """;

        return await databaseService.ExecuteNonQueryAsync(
            sql,
            new NpgsqlParameter("id", id),
            new NpgsqlParameter("name", name),
            new NpgsqlParameter("category", category),
            new NpgsqlParameter("quantity", quantity),
            new NpgsqlParameter("price", price),
            new NpgsqlParameter("weight", weight)
        );
    }

    /// <summary>
    /// Отримує кількість товарних позицій у кожній категорії.
    /// </summary>
    /// <returns>Таблиця з категоріями та кількістю товарних позицій.</returns>
    public async Task<DataTable> GetCategoryStatisticsAsync()
    {
        const string sql = """
        SELECT category, COUNT(*)::integer AS product_count
        FROM public.products
        GROUP BY category
        ORDER BY category;
        """;

        return await databaseService.ExecuteQueryAsync(sql);
    }

    /// <summary>
    /// Обчислює загальну вартість товарних запасів
    /// для кожної категорії.
    /// </summary>
    /// <returns>Таблиця з категоріями та вартістю запасів.</returns>
    public async Task<DataTable> GetCategoryStockValueAsync()
    {
        const string sql = """
        SELECT
            category,
            SUM(quantity * price) AS total_value
        FROM public.products
        GROUP BY category
        ORDER BY category;
        """;

        return await databaseService.ExecuteQueryAsync(sql);
    }

    /// <summary>
    /// Обчислює загальну кількість одиниць товару
    /// для кожної категорії.
    /// </summary>
    /// <returns>Таблиця з категоріями та кількістю одиниць товару.</returns>
    public async Task<DataTable> GetCategoryQuantityAsync()
    {
        const string sql = """
        SELECT
            category,
            SUM(quantity)::bigint AS total_quantity
        FROM public.products
        GROUP BY category
        ORDER BY category;
        """;

        return await databaseService.ExecuteQueryAsync(sql);
    }
}