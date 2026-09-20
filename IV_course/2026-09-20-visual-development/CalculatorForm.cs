using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_09_20_visual_development
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private bool TryReadNumbers(out double a, out double b)
        {
            // Зчитуємо перше число.
            if (!double.TryParse(firstNumberTextBox.Text, out a))
            {
                MessageBox.Show("Введіть коректне число a.");
                b = 0;
                return false;
            }

            // Зчитуємо друге число.
            if (!double.TryParse(secondNumberTextBox.Text, out b))
            {
                MessageBox.Show("Введіть коректне число b.");
                return false;
            }

            return true;
        }

        private bool TryReadOperation(out char operation)
        {
            // Зчитуємо символ операції.
            string input = operationTextBox.Text.Trim();

            // Перевіряємо, що введено рівно один дозволений символ.
            if (input.Length != 1 || !"+-*/".Contains(input[0]))
            {
                MessageBox.Show(
                    "Введіть дозволений символ математичної операції: +, -, *, /.",
                    "Помилка введення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                operation = default;
                return false;
            }

            operation = input[0];
            return true;
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            // Зчитуємо та перевіряємо числові значення.
            if (!TryReadNumbers(out double a, out double b))
            {
                return;
            }

            // Зчитуємо та перевіряємо математичну операцію.
            if (!TryReadOperation(out char operation))
            {
                return;
            }

            // Виконуємо вибрану математичну операцію.
            double result;

            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;

                case '/':
                    if (b == 0)
                    {
                        MessageBox.Show(
                            "Ділення на нуль неможливе.",
                            "Помилка обчислення",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }

                    result = a / b;
                    break;

                default:
                    return;
            }

            // Виводимо результат на форму.
            resultLabel.Text = result.ToString();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
                        Close();
        }
    }
}
