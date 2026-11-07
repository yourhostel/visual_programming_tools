namespace ExcelAutomation;


public partial class ExcelEquationForm : Form
{
    private List<EquationSystem> systems = [];

    public ExcelEquationForm()
    {
        InitializeComponent();

        try
        {
            systems = EquationSystemRepository.Load();

            comboVariant.DisplayMember = nameof(EquationSystem.Id);
            comboVariant.ValueMember = nameof(EquationSystem.Id);
            comboVariant.DataSource = systems;
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"Помилка завантаження варіантів:\n{ex.Message}",
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }



    private void button1_Click(object sender, EventArgs e)
    {
        try
        {
            // 1. Отримання рівнянь із полів введення.
            string[] equations =
            {
            textEquation1.Text,
            textEquation2.Text,
            textEquation3.Text
        };

            // 2. Попередня перевірка синтаксису.
            EquationParser.Parse(equations);

            // 3. Пошук параметрів у порядку появи.
            List<char> parameters =
                EquationParser.FindParameters(equations);

            Dictionary<char, double> values = [];

            // 4. Послідовне введення параметрів.
            foreach (char parameter in parameters)
            {
                double? value = RequestParameter(parameter);

                if (value is null)
                    return;

                values[parameter] = value.Value;
            }

            // 5. Формування матриці A та вектора B.
            ParsedEquationSystem parsed = EquationParser.Parse(
                equations,
                a: values.GetValueOrDefault('a', 1),
                b: values.GetValueOrDefault('b', 1)
            );

            // 6. Розв'язання системи через Microsoft Excel.
            double[] x = ExcelEquationSolver.Solve(parsed);

            // 7. Виведення результатів обчислення.
            labelX1.Text = $"x₁ = {x[0]:0.######}";
            labelX2.Text = $"x₂ = {x[1]:0.######}";
            labelX3.Text = $"x₃ = {x[2]:0.######}";

            // 8. Перевірка розв'язку підстановкою.
            bool verified = ExcelEquationSolver.Verify(parsed, x);

            labelVerification.Text = verified
                ? "Перевірка: успішно"
                : "Перевірка: помилка";
        }
        catch (EquationParseException ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка синтаксису",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                "Помилка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }

    private void ExcelEquationForm_Paint(object sender, PaintEventArgs e)
    {
        float x = textEquation1.Left - 20;
        float y = textEquation1.Top;
        float height = textEquation3.Bottom - textEquation1.Top;

        BraceRenderer.DrawBrace(
            e.Graphics,
            x,
            y,
            width: 10,
            height: height,
            thickness: 1.2f
        );
    }

    private void comboVariant_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboVariant.SelectedItem is not EquationSystem system)
            return;

        textEquation1.Text = system.Equations[0];
        textEquation2.Text = system.Equations[1];
        textEquation3.Text = system.Equations[2];

        labelX1.Text = "x₁ = ...";
        labelX2.Text = "x₂ = ...";
        labelX3.Text = "x₃ = ...";

        labelVerification.Text = "Перевірка: очікування обчислення";
    }

    private static double? RequestParameter(char parameter)
    {
        using Form dialog = new()
        {
            Text = $"Параметр {parameter}",
            Width = 320,
            Height = 170,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            StartPosition = FormStartPosition.CenterParent,
            MaximizeBox = false,
            MinimizeBox = false
        };

        Label label = new()
        {
            Text = $"Введіть значення параметра {parameter}:",
            Left = 15,
            Top = 15,
            AutoSize = true
        };

        NumericUpDown input = new()
        {
            Left = 15,
            Top = 45,
            Width = 275,
            DecimalPlaces = 4,
            Minimum = -1000000,
            Maximum = 1000000,
            Value = 1
        };

        Button confirm = new()
        {
            Text = "Встановити",
            Left = 105,
            Top = 85,
            Width = 90,
            DialogResult = DialogResult.OK
        };

        Button cancel = new()
        {
            Text = "Скасувати",
            Left = 200,
            Top = 85,
            Width = 90,
            DialogResult = DialogResult.Cancel
        };

        dialog.Controls.AddRange(
            [label, input, confirm, cancel]
        );

        dialog.AcceptButton = confirm;
        dialog.CancelButton = cancel;

        return dialog.ShowDialog() == DialogResult.OK
            ? (double)input.Value
            : null;
    }
}
