namespace _2026_09_20_user_interface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productCostButtonClick(object sender, EventArgs e)
        {
            new ProductCostForm().Show();
        }

        private void oddNumbersSumButtonClick(object sender, EventArgs e)
        {
            new OddNumbersSumForm().Show();
        }

        private void numberCubesButtonClick(object sender, EventArgs e)
        {
            new NumberCubesForm().Show();
        }
    }
}
