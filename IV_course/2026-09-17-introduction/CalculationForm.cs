using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_09_17_introduction
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        // Метод для зчитування значень x, y та z з текстових полів та перевірки їх коректності
        private bool TryReadInputValues(out double x, out double y, out double z)
        {
            bool xValid = double.TryParse(xTextBox.Text, out x);
            bool yValid = double.TryParse(yTextBox.Text, out y);
            bool zValid = double.TryParse(zTextBox.Text, out z);

            if (!xValid || !yValid || !zValid)
            {
                MessageBox.Show(
                    "Введіть коректні числові значення x, y та z.",
                    "Помилка введення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        // Метод для обчислення значення s за заданою формулою
        private double Calculate(double x, double y, double z)
        {
            return
                (2 * Math.Cos(x - 2.0 / 3.0)) /
                (1.0 / 2.0 + Math.Pow(Math.Sin(y), 2)) *
                (1.0 + Math.Pow(z, 2) /
                (3.0 - Math.Pow(z, 2) / 5.0));
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            if (!TryReadInputValues(out double x, out double y, out double z))
            {
                return;
            }

            double result = Calculate(x, y, z);

            MessageBox.Show($"s = {result:F6}");
        }
    }
}
