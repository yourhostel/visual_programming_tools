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
    public partial class NumberCubesForm : Form
    {
        public NumberCubesForm()
        {
            InitializeComponent();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            // Очищуємо попередній результат.
            resultTextBox.Clear();

            // Обчислюємо куби непарних чисел від 1 до 9.
            for (int number = 1; number <= 9; number += 2)
            {
                int cube = number * number * number;

                // Додаємо результат до текстового поля з нового рядка.
                resultTextBox.AppendText(
                    $"{number}^3 = {cube}{Environment.NewLine}"
                );
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
        }
    }
}
