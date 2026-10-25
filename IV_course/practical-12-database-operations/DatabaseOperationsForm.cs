using System.Data;

namespace DatabaseOperations;

/// <summary>
/// Головна форма для перегляду та керування товарами PostgreSQL.
/// </summary>
public partial class DatabaseOperationsForm : Form
{
    private readonly ProductService productService;
    private int? selectedProductId;

    /// <summary>
    /// Ініціалізує компоненти форми, сервіси
    /// та обробники подій завантаження й оновлення даних.
    /// </summary>
    public DatabaseOperationsForm()
    {
        InitializeComponent();

        comboBoxQueryType.Items.AddRange(
        [
            "Усі товари",
            "Пошук за назвою або категорією",
            "Товари з кількістю менше 20"
        ]);

        comboBoxQueryType.SelectedIndex = 0;

        comboBoxChartType.Items.AddRange(
        [
            "Кількість товарів за категоріями",
            "Вартість запасів за категоріями",
            "Кількість одиниць за категоріями"
        ]);

        comboBoxChartType.SelectedIndex = 0;

        var databaseService = new DatabaseService(
            DatabaseService.GetConnectionString()
        );

        productService = new ProductService(databaseService);
        dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;

        Load += async (_, _) => await LoadProductsAsync();
        
        buttonRefresh.Click += async (_, _) => await LoadProductsAsync();
        buttonAdd.Click += buttonAdd_Click;
        buttonDelete.Click += buttonDelete_Click;
        buttonSearch.Click += buttonSearch_Click;
        buttonUpdate.Click += buttonSave_Click;

        buttonBuildChart.Click += async (_, _) => await BuildChartAsync();
        buttonRefreshChart.Click += async (_, _) => await BuildChartAsync();
    }

    /// <summary>
    /// Виконує вибраний тип SQL-запиту
    /// та відображає знайдені товари в DataGridView.
    /// </summary>
    /// <param name="sender">Компонент, який викликав подію.</param>
    /// <param name="e">Аргументи події.</param>
    private async void buttonSearch_Click(object? sender, EventArgs e)
    {
        try
        {
            dataGridViewProducts.DataSource =
                await productService.SearchProductsAsync(
                    comboBoxQueryType.SelectedIndex,
                    textBoxSearch.Text.Trim()
                );

            dataGridViewProducts.ClearSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка пошуку",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    /// <summary>
    /// Завантажує всі товари з PostgreSQL
    /// та відображає їх у DataGridView.
    /// </summary>
    /// <returns>Асинхронна операція завантаження даних.</returns>
    private async Task LoadProductsAsync()
    {
        try
        {
            dataGridViewProducts.DataSource =
                await productService.GetAllAsync();

            dataGridViewProducts.ClearSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка завантаження товарів",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    /// <summary>
    /// Скидає поля редактора товару до початкових значень.
    /// </summary>
    private void ClearEditor()
    {
        selectedProductId = null;

        textBoxName.Clear();
        textBoxCategory.Clear();

        numericQuantity.Value = 0;
        numericPrice.Value = 0;
        numericWeight.Value = 0;
    }

    /// <summary>
    /// Додає новий товар до PostgreSQL
    /// та оновлює таблицю після успішного збереження.
    /// </summary>
    private async void buttonAdd_Click(object? sender, EventArgs e)
    {
        try
        {
            string name = textBoxName.Text.Trim();
            string category = textBoxCategory.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(category))
            {
                MessageBox.Show("Заповніть назву та категорію товару.");
                return;
            }

            await productService.AddAsync(
                name,
                category,
                (int)numericQuantity.Value,
                numericPrice.Value,
                (double)numericWeight.Value
            );

            await LoadProductsAsync();
            ClearEditor();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка додавання товару",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    /// <summary>
    /// Видаляє вибраний товар після підтвердження користувача
    /// та оновлює таблицю.
    /// </summary>
    /// <param name="sender">Компонент, який викликав подію.</param>
    /// <param name="e">Аргументи події.</param>
    private async void buttonDelete_Click(object? sender, EventArgs e)
    {
        if (dataGridViewProducts.CurrentRow?.DataBoundItem is not DataRowView row)
        {
            MessageBox.Show("Виберіть товар для видалення.");
            return;
        }

        int id = Convert.ToInt32(row["id"]);
        string name = Convert.ToString(row["name"]) ?? "";

        var result = MessageBox.Show(
            $"Видалити товар «{name}» (ID: {id})?",
            "Підтвердження видалення",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (result != DialogResult.Yes)
            return;

        try
        {
            int affected = await productService.DeleteAsync(id);

            if (affected == 0)
            {
                MessageBox.Show("Товар не знайдено в базі даних.");
                return;
            }

            await LoadProductsAsync();
            ClearEditor();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка видалення товару",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    /// <summary>
    /// Переносить дані вибраного товару з таблиці
    /// до полів редактора для подальшого редагування.
    /// </summary>
    /// <param name="sender">Компонент, який викликав подію.</param>
    /// <param name="e">Аргументи події.</param>
    private void dataGridViewProducts_SelectionChanged(object? sender, EventArgs e)
    {
        if (dataGridViewProducts.SelectedRows.Count == 0)
            return;

        if (dataGridViewProducts.CurrentRow?.DataBoundItem is not DataRowView row)
            return;

        selectedProductId = Convert.ToInt32(row["id"]);

        textBoxName.Text = Convert.ToString(row["name"]);
        textBoxCategory.Text = Convert.ToString(row["category"]);

        numericQuantity.Value = Math.Clamp(
            Convert.ToDecimal(row["quantity"]),
            numericQuantity.Minimum,
            numericQuantity.Maximum
        );

        numericPrice.Value = Math.Clamp(
            Convert.ToDecimal(row["price"]),
            numericPrice.Minimum,
            numericPrice.Maximum
        );

        numericWeight.Value = Math.Clamp(
            Convert.ToDecimal(row["weight"]),
            numericWeight.Minimum,
            numericWeight.Maximum
        );
    }

    /// <summary>
    /// Зберігає зміни вибраного товару в PostgreSQL
    /// та оновлює таблицю після успішного виконання.
    /// </summary>
    /// <param name="sender">Компонент, який викликав подію.</param>
    /// <param name="e">Аргументи події.</param>
    private async void buttonSave_Click(object? sender, EventArgs e)
    {
        if (selectedProductId is not int id)
        {
            MessageBox.Show("Виберіть товар для редагування.");
            return;
        }

        string name = textBoxName.Text.Trim();
        string category = textBoxCategory.Text.Trim();

        if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(category))
        {
            MessageBox.Show("Заповніть назву та категорію товару.");
            return;
        }

        try
        {
            int affected = await productService.UpdateAsync(
                id,
                name,
                category,
                (int)numericQuantity.Value,
                numericPrice.Value,
                (double)numericWeight.Value
            );

            if (affected == 0)
            {
                MessageBox.Show("Товар не знайдено в базі даних.");
                return;
            }

            selectedProductId = null;

            await LoadProductsAsync();
            ClearEditor();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка оновлення товару",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    /// <summary>
    /// Будує стовпчикову діаграму кількості товарних позицій
    /// за категоріями на основі даних PostgreSQL.
    /// </summary>
    /// <returns>Асинхронна операція побудови діаграми.</returns>
    private async Task BuildChartAsync()
    {
        try
        {
            int chartType = comboBoxChartType.SelectedIndex;

            DataTable table = chartType switch
            {
                1 => await productService.GetCategoryStockValueAsync(),
                2 => await productService.GetCategoryQuantityAsync(),
                _ => await productService.GetCategoryStatisticsAsync()
            };

            string valueColumn = chartType switch
            {
                1 => "total_value",
                2 => "total_quantity",
                _ => "product_count"
            };

            double[] values = table.AsEnumerable()
                .Select(row => Convert.ToDouble(row[valueColumn]))
                .ToArray();

            string[] categories = table.AsEnumerable()
                .Select(row => Convert.ToString(row["category"]) ?? "")
                .ToArray();

            formsPlot.Plot.Clear();

            var bars = formsPlot.Plot.Add.Bars(values);

            bars.ValueLabelStyle.IsVisible = true;

            ScottPlot.Tick[] ticks = categories
                .Select((category, index) =>
                    new ScottPlot.Tick(index + 1, category))
                .ToArray();

            formsPlot.Plot.Axes.Bottom.TickGenerator =
                new ScottPlot.TickGenerators.NumericManual(ticks);

            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlot.Plot.Axes.Bottom.MinimumSize = 110;

            formsPlot.Plot.Title(chartType switch
            {
                1 => "Вартість товарних запасів за категоріями",
                2 => "Кількість одиниць товару за категоріями",
                _ => "Кількість товарних позицій за категоріями"
            });

            formsPlot.Plot.YLabel(chartType switch
            {
                1 => "Вартість запасів, грн",
                2 => "Кількість одиниць",
                _ => "Кількість товарних позицій"
            });

            formsPlot.Plot.Axes.AutoScale();
            formsPlot.Refresh();
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка побудови діаграми",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
