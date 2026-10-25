
using System.Data;

namespace TabularData;

public partial class TableEditorForm : Form
{
    private readonly DataTable table = new("Products");

    public TableEditorForm()
    {
        InitializeComponent();

        InitializeTable();
    }

    private void InitializeTable()
    {
        // Стовпці таблиці
        table.Columns.Add("Назва", typeof(string));
        table.Columns.Add("Кількість", typeof(int));
        table.Columns.Add("Ціна", typeof(decimal));

        gridData.DataSource = table;
        gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        // Оновлення кількості записів і діаграми
        table.RowChanged += (_, _) =>
        {
            UpdateRowCount();
            UpdateChart();
        };

        table.RowDeleted += (_, _) =>
        {
            UpdateRowCount();
            UpdateChart();
        };

        // Головне меню: файл
        menuCreate.Click += (_, _) => CreateTable();
        menuOpenXml.Click += (_, _) => OpenXml();
        menuSaveXml.Click += (_, _) => SaveXml();
        menuExit.Click += (_, _) => Close();

        // Головне меню: таблиця
        menuAddRow.Click += (_, _) => AddRow();
        menuDeleteRow.Click += (_, _) => DeleteRow();

        // Головне меню: діаграма
        menuRefreshChart.Click += (_, _) => UpdateChart();

        // Вибір типу діаграми
        comboChartType.SelectedIndexChanged += (_, _) => UpdateChart();
        comboChartType.SelectedIndex = 0;

        // Панель діаграми
        panelChart.Paint += DrawChart;
        panelChart.Resize += (_, _) => UpdateChart();

        // Контекстне меню таблиці
        contextCreate.Click += (_, _) => CreateTable();
        contextOpenXml.Click += (_, _) => OpenXml();
        contextSaveXml.Click += (_, _) => SaveXml();

        // Початкове оновлення
        UpdateRowCount();
        UpdateChart();
    }

    private void CreateTable()
    {
        table.Clear();
        UpdateRowCount();
    }

    private void AddRow()
    {
        table.Rows.Add("Новий товар", 1, 0m);
    }

    private void DeleteRow()
    {
        if (gridData.CurrentRow?.DataBoundItem is DataRowView row)
            row.Delete();
    }

    private void UpdateRowCount()
    {
        statusRows.Text = $"Записів: {table.Rows.Count}";
    }

    private void SaveXml()
    {
        gridData.EndEdit();

        using SaveFileDialog dialog = new()
        {
            Filter = "XML-файли (*.xml)|*.xml",
            FileName = "products.xml"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        table.WriteXml(dialog.FileName, XmlWriteMode.WriteSchema);
    }

    private void OpenXml()
    {
        using OpenFileDialog dialog = new()
        {
            Filter = "XML-файли (*.xml)|*.xml"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        table.Clear();
        table.ReadXml(dialog.FileName);
        UpdateRowCount();
    }


    private void UpdateChart()
    {
        panelChart.Invalidate();
    }

    private void DrawChart(object? sender, PaintEventArgs e)
    {
        // Визначення типу діаграми
        bool isLineChart = comboChartType.SelectedIndex == 1;

        // Отримання даних із таблиці та розрахунок вартості товарів
        var items = table.Rows
            .Cast<DataRow>()
            .Where(row => row.RowState != DataRowState.Deleted)
            .Select(row => new
            {
                Name = row["Назва"].ToString() ?? "",
                Total = row.Field<int?>("Кількість").GetValueOrDefault()
                      * row.Field<decimal?>("Ціна").GetValueOrDefault()
            })
            .Where(item => item.Total > 0)
            .ToList();

        // Очищення області діаграми
        Graphics g = e.Graphics;
        g.Clear(Color.White);

        if (items.Count == 0)
            return;

        // Визначення меж області побудови
        int left = 55;
        int top = 30;
        int bottom = panelChart.Height - 55;
        int width = panelChart.Width - left - 20;
        int height = bottom - top;

        if (width <= 0 || height <= 0)
            return;

        // Масштабування значень відповідно до найбільшої вартості
        decimal max = items.Max(item => item.Total);
        float step = (float)width / items.Count;
        float barWidth = Math.Max(1f, step * 0.6f);

        using Pen axisPen = new(Color.Gray);
        using Pen linePen = new(Color.SteelBlue, 2);
        using SolidBrush barBrush = new(Color.SteelBlue);

        // Побудова осей координат
        g.DrawLine(axisPen, left, top, left, bottom);
        g.DrawLine(axisPen, left, bottom, left + width, bottom);

        // Координати точок для лінійної діаграми
        List<PointF> points = new();

        for (int i = 0; i < items.Count; i++)
        {
            // Розрахунок висоти та положення елемента
            float barHeight = (float)(items[i].Total / max) * height;
            float x = left + i * step + (step - barWidth) / 2;
            float y = bottom - barHeight;

            if (isLineChart)
            {
                // Збереження координат точки лінійної діаграми
                points.Add(new PointF(left + (i + 0.5f) * step, y));
            }
            else
            {
                // Малювання стовпчика
                g.FillRectangle(barBrush, x, y, barWidth, barHeight);
            }

            // Підпис товару під діаграмою
            // Виводимо номери товарів із кроком, залежним від їх кількості
            int labelStep = items.Count > 30 ? 10 : items.Count > 15 ? 5 : 1;

            if (i % labelStep == 0)
            {
                string label = (i + 1).ToString();

                float labelX = left + (i + 0.5f) * step;

                using StringFormat format = new()
                {
                    Alignment = StringAlignment.Center
                };

                g.DrawString(
                    label,
                    Font,
                    Brushes.Black,
                    new PointF(labelX, bottom + 5),
                    format);
            }
        }

        if (isLineChart)
        {
            // З'єднання точок лініями
            if (points.Count > 1)
                g.DrawLines(linePen, points.ToArray());

            // Позначення окремих значень на лінійній діаграмі
            foreach (PointF point in points)
            {
                g.FillEllipse(
                    barBrush,
                    point.X - 4,
                    point.Y - 4,
                    8,
                    8);
            }
        }
    }

}
