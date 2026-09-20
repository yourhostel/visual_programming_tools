namespace _2026_09_20_visual_development
{
    public partial class SumForm : Form
    {
        public SumForm()
        {
            InitializeComponent();
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            // Зчитуємо перше число та перевіряємо правильність введення.
            if (!double.TryParse(firstNumberTextBox.Text, out double a))
            {
                MessageBox.Show("Введіть коректне число a.");
                return;
            }

            // Зчитуємо друге число та перевіряємо правильність введення.
            if (!double.TryParse(secondNumberTextBox.Text, out double b))
            {
                MessageBox.Show("Введіть коректне число b.");
                return;
            }

            // Обчислюємо суму двох чисел.
            double sum = a + b;

            // Виводимо результат на форму.
            resultLabel.Text = sum.ToString();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
                        Close();
        }
    }
}
