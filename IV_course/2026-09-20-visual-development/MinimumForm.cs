using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2026_09_20_visual_development
{
    public partial class MinimumForm : Form
    {
        public MinimumForm()
        {
            InitializeComponent();
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            // TryParse отримує текст із TextBox.Text і повертає:
            // true, якщо текст вдалося перетворити на число. Отримане значення записується у змінну x.
            // false, якщо перетворення неможливе. У такому випадку x отримує значення 0.

            // Зчитуємо перше число.
            if (!double.TryParse(xTextBox.Text, out double x))
            {
                MessageBox.Show("Введіть коректне число x.");
                return;
            }

            // Зчитуємо друге число.
            if (!double.TryParse(yTextBox.Text, out double y))
            {
                MessageBox.Show("Введіть коректне число y.");
                return;
            }

            // Зчитуємо третє число.
            if (!double.TryParse(zTextBox.Text, out double z))
            {
                MessageBox.Show("Введіть коректне число z.");
                return;
            }

            // Знаходимо найменше число.
            double minimum = x;

            if (y < minimum) minimum = y;

            if (z < minimum) minimum = z;

            // Виводимо результат.
            resultLabel.Text = minimum.ToString();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
