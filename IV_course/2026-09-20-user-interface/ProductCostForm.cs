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
    public partial class ProductCostForm : Form
    {
        private const decimal UnitPrice = 50m;

        public ProductCostForm()
        {
            InitializeComponent();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            // Перевіряємо, чи введено цілу додатну кількість товару.
            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Введіть коректну кількість товару (ціле додатне число).");
                quantityTextBox.Focus();
                return;
            }

            // Обчислюємо загальну вартість.
            decimal totalCost = quantity * UnitPrice;

            // Виводимо результат.
            totalCostLabel.Text = $"{totalCost:0.00} грн";
        }

        private void quantityTextBoxTextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled =
        !string.IsNullOrWhiteSpace(quantityTextBox.Text);
        }
    }
}
