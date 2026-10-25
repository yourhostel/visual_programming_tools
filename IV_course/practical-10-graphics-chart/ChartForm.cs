namespace GraphicsChart;

using ScottPlot.WinForms;
using System.Data;

public partial class ChartForm : Form
{
    private readonly string dataPath = Path.Combine(
        AppContext.BaseDirectory, "data"
    );

    private record Product(string Name, int Quantity, decimal Price);

    private List<Product> products = [];

    /// <summary>
    /// Ініціалізує форму, підключає обробники подій
    /// та завантажує доступні файли й типи графіків.
    /// </summary>
    public ChartForm()
    {
        InitializeComponent();

        comboData.SelectedIndexChanged += (_, _) =>
        {
            LoadProducts();
            DrawChart();
        };

        comboChartType.SelectedIndexChanged += (_, _) => DrawChart();

        LoadDataFiles();
        LoadChartTypes();
        DrawChart();
    }


    /// <summary>
    /// Перебудовує графік відповідно до вибраного типу діаграми
    /// та налаштовує координатні осі й масштаб відображення.
    /// </summary>
    private void DrawChart()
    {
        // Видаляємо попередні графічні об'єкти
        // (стовпчики, лінії, точки, сектори тощо).
        formsPlot.Plot.Clear();

        // Дозволяємо осям X та Y масштабуватися незалежно.
        // Наприклад, X може мати значення 0–1500, а Y — 0–30.
        formsPlot.Plot.Axes.SquareUnits(false);

        // Якщо дані відсутні, очищаємо відображення
        // та завершуємо виконання методу.
        if (products.Count == 0)
        {
            formsPlot.Refresh();
            return;
        }

        // Відновлюємо видимість координатних осей.
        // Це необхідно після кругової діаграми,
        // яка приховує осі та їхні підписи.
        formsPlot.Plot.Axes.Left.IsVisible = true;
        formsPlot.Plot.Axes.Bottom.IsVisible = true;
        formsPlot.Plot.Axes.Right.IsVisible = false;
        formsPlot.Plot.Axes.Top.IsVisible = false;

        // Вмикаємо координатну сітку,
        // яка також приховується для кругової діаграми.
        formsPlot.Plot.ShowGrid();

        // Викликаємо метод побудови відповідно
        // до індексу вибраного елемента ComboBox.
        switch (comboChartType.SelectedIndex)
        {
            case 0:
                DrawBarChart();      // Стовпчикова діаграма
                break;

            case 1:
                DrawLineChart();     // Лінійний графік
                break;

            case 2:
                DrawPieChart();      // Кругова діаграма
                break;

            case 3:
                DrawScatterChart();  // Точкова діаграма
                break;

            case 4:
                DrawHistogram();     // Гістограма розподілу
                break;
        }

        // Автоматично визначаємо межі координатних осей,
        // щоб побудовані дані помістилися в область графіка.
        formsPlot.Plot.Axes.AutoScale();

        // Для стовпчикової та лінійної діаграм
        // показуємо спочатку лише перші 15 товарів.
        // Решту можна переглянути перетягуванням графіка мишею.
        if (comboChartType.SelectedIndex is 0 or 1)
        {
            formsPlot.Plot.Axes.SetLimitsX(0, 16);
        }
        // Для гістограми встановлюємо вертикальні межі:
        // від нуля до розрахункового верхнього значення.
        else if (comboChartType.SelectedIndex == 4)
        {
            formsPlot.Plot.Axes.SetLimitsY(
                0,
                Math.Ceiling(products.Count / 5.0) + 2
            );
        }

        // Перемальовуємо компонент FormsPlot
        // із новими даними та налаштуваннями.
        formsPlot.Refresh();
    }

    /// <summary>
    /// Будує стовпчикову діаграму кількості товарів
    /// за їхніми порядковими номерами.
    /// </summary>
    private void DrawBarChart()
    {
        double[] values = products
            .Select(p => (double)p.Quantity)
            .ToArray();

        var bars = values.Select((value, index) => new ScottPlot.Bar
        {
            Position = index + 1,
            Value = value
        }).ToArray();

        formsPlot.Plot.Add.Bars(bars);

        formsPlot.Plot.Title("Кількість товарів");
        formsPlot.Plot.XLabel("Номер товару");
        formsPlot.Plot.YLabel("Кількість");
    }

    /// <summary>
    /// Будує лінійний графік кількості товарів
    /// із послідовним з'єднанням точок.
    /// </summary>
    private void DrawLineChart()
    {
        double[] x = Enumerable.Range(1, products.Count)
            .Select(i => (double)i)
            .ToArray();

        double[] y = products
            .Select(p => (double)p.Quantity)
            .ToArray();

        formsPlot.Plot.Add.Scatter(x, y);

        formsPlot.Plot.Title("Кількість товарів");
        formsPlot.Plot.XLabel("Номер товару");
        formsPlot.Plot.YLabel("Кількість");
    }

    /// <summary>
    /// Будує кругову діаграму для десяти товарів
    /// із найбільшою кількістю, об'єднуючи решту в один сектор.
    /// </summary>
    private void DrawPieChart()
    {
        var topProducts = products
            .OrderByDescending(p => p.Quantity)
            .Take(10)
            .ToList();

        double others = products
            .Except(topProducts)
            .Sum(p => (double)p.Quantity);

        List<double> values = topProducts
            .Select(p => (double)p.Quantity)
            .ToList();

        if (others > 0)
            values.Add(others);

        var pie = formsPlot.Plot.Add.Pie(values.ToArray());

        pie.ExplodeFraction = 0.02;

        formsPlot.Plot.Title("Розподіл кількості товарів (ТОП-10 та інші)");
        formsPlot.Plot.Axes.Frameless();
        formsPlot.Plot.HideGrid();
    }

    /// <summary>
    /// Будує точкову діаграму співвідношення
    /// ціни та кількості товарів.
    /// </summary>
    private void DrawScatterChart()
    {
        double[] prices = products
            .Select(p => (double)p.Price)
            .ToArray();

        double[] quantities = products
            .Select(p => (double)p.Quantity)
            .ToArray();

        var scatter = formsPlot.Plot.Add.ScatterPoints(
            prices, quantities
        );

        scatter.MarkerSize = 8;

        formsPlot.Plot.Title("Залежність кількості від ціни");
        formsPlot.Plot.XLabel("Ціна");
        formsPlot.Plot.YLabel("Кількість");
    }

    /// <summary>
    /// Будує гістограму розподілу товарів
    /// за десятьма ціновими інтервалами.
    /// </summary>
    private void DrawHistogram()
    {
        double[] prices = products
            .Select(p => (double)p.Price)
            .ToArray();

        const int binCount = 10;

        double min = prices.Min();
        double max = prices.Max();

        double binWidth = (max - min) / binCount;

        if (binWidth == 0)
            binWidth = 1;

        int[] counts = new int[binCount];

        foreach (double price in prices)
        {
            int index = (int)((price - min) / binWidth);
            index = Math.Clamp(index, 0, binCount - 1);
            counts[index]++;
        }

        var bars = counts.Select((count, index) => new ScottPlot.Bar
        {
            Position = min + (index + 0.5) * binWidth,
            Value = count,
            Size = binWidth * 0.95
        }).ToArray();

        formsPlot.Plot.Add.Bars(bars);

        formsPlot.Plot.Title("Розподіл товарів за ціною");
        formsPlot.Plot.XLabel("Ціна");
        formsPlot.Plot.YLabel("Кількість найменувань");
    }

    /// <summary>
    /// Зчитує товари з вибраного XML-файлу
    /// та заповнює колекцію products.
    /// </summary>
    private void LoadProducts()
    {
        products.Clear();

        if (comboData.SelectedItem is not string fileName)
            return;

        string filePath = Path.Combine(dataPath, fileName);

        DataTable table = new("Products");
        table.ReadXml(filePath);

        foreach (DataRow row in table.Rows)
        {
            products.Add(new Product(
                Convert.ToString(row["Назва"]) ?? "",
                Convert.ToInt32(row["Кількість"]),
                Convert.ToDecimal(row["Ціна"])
            ));
        }
    }

    /// <summary>
    /// Знаходить XML-файли в каталозі data
    /// та додає їхні назви до comboData.
    /// </summary>
    private void LoadDataFiles()
    {
        comboData.Items.Clear();

        if (!Directory.Exists(dataPath))
            return;

        foreach (string file in Directory.GetFiles(dataPath, "*.xml"))
        {
            comboData.Items.Add(Path.GetFileName(file));
        }

        if (comboData.Items.Count > 0)
            comboData.SelectedIndex = 0;
    }

    /// <summary>
    /// Заповнює comboChartType доступними
    /// типами графіків і встановлює початковий вибір.
    /// </summary>
    private void LoadChartTypes()
    {
        comboChartType.Items.AddRange(
        [
        "Стовпчикова",
        "Лінійна",
        "Кругова",
        "Точкова",
        "Гістограма розподілу"
        ]);

        comboChartType.SelectedIndex = 0;
    }
}

