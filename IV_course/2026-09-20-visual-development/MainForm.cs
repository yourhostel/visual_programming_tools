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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void sumButtonClick(object sender, EventArgs e)
        {
            new SumForm().Show();
        }

        private void minimumButtonClick(object sender, EventArgs e)
        {
            new MinimumForm().Show();
        }

        private void calculatorButtonClick(object sender, EventArgs e)
        {
            new CalculatorForm().Show();
        }

        private void pointRegionButtonClick(object sender, EventArgs e)
        {
            new PointRegionForm().Show();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
