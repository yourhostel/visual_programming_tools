using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_09_20_user_interface
{
    public partial class OddNumbersSumForm : Form
    {
        public OddNumbersSumForm()
        {
            InitializeComponent();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {

            // Зчитуємо початок проміжку.
            if (!int.TryParse(startTextBox.Text, out int a))
            {
                MessageBox.Show("Введіть коректне ціле число A.");
                startTextBox.Focus();
                return;
            }

            // Зчитуємо кінець проміжку.
            if (!int.TryParse(endTextBox.Text, out int b))
            {
                MessageBox.Show("Введіть коректне ціле число B.");
                endTextBox.Focus();
                return;
            }

            // Перевіряємо порядок меж проміжку.
            if (a > b)
            {
                MessageBox.Show("Число A не може бути більшим за B.");
                startTextBox.Focus();
                return;
            }

            // Обчислюємо суму непарних чисел від A до B включно.
            long sum = 0;

            for (long number = a; number <= b; number++)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            // Виводимо результат.
            resultLabel.Text = sum.ToString();
        }
    }
}
