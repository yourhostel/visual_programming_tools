using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2026_09_20_visual_development
{
    public partial class PointRegionForm : Form
    {
        private double? pointX;
        private double? pointY;

        public PointRegionForm()
        {
            InitializeComponent();
        }

        private void DrawPoint(Graphics graphics)
        {
            if (pointX == null || pointY == null)
            {
                return;
            }

            int centerX = regionPictureBox.ClientSize.Width / 2;
            int centerY = regionPictureBox.ClientSize.Height / 2;
            int scale = 70;

            // Перетворюємо математичні координати на пікселі.
            float x = centerX + (float)(pointX.Value * scale);
            float y = centerY - (float)(pointY.Value * scale);

            // Малюємо червону точку діаметром 8 пікселів.
            graphics.FillEllipse(
                Brushes.Red,
                x - 4,
                y - 4,
                8,
                8
            );
        }

        private void DrawFirstRegion(Graphics graphics)
        {
            // Центр координатної системи у PictureBox.
            int centerX = regionPictureBox.ClientSize.Width / 2;
            int centerY = regionPictureBox.ClientSize.Height / 2;

            // Довжина одиничного відрізка у пікселях.
            int scale = 70;

            // Малюємо координатну сітку.
            for (int i = -1; i <= 1; i++)
            {
                int x = centerX + i * scale;
                int y = centerY - i * scale;

                graphics.DrawLine(
                    Pens.LightGray,
                    x, 0,
                    x, regionPictureBox.ClientSize.Height
                );

                graphics.DrawLine(
                    Pens.LightGray,
                    0, y,
                    regionPictureBox.ClientSize.Width, y
                );
            }

            // Зафарбовуємо квадрат від (-1, -1) до (0, 0).
            graphics.FillRectangle(
                Brushes.LightGray,
                centerX - scale,
                centerY,
                scale,
                scale
            );

            // Вершини трикутника: (0, 0), (0, 1), (1, 0).
            Point[] triangle =
            {
        new Point(centerX, centerY),
        new Point(centerX, centerY - scale),
        new Point(centerX + scale, centerY)
    };

            // Зафарбовуємо трикутник.
            graphics.FillPolygon(Brushes.LightGray, triangle);

            // Малюємо контури зафарбованих фігур.
            graphics.DrawRectangle(
                Pens.Gray,
                centerX - scale,
                centerY,
                scale,
                scale
            );

            graphics.DrawPolygon(Pens.Gray, triangle);

            // Малюємо осі поверх фігур.
            graphics.DrawLine(
                Pens.Black,
                0, centerY,
                regionPictureBox.ClientSize.Width, centerY
            );

            graphics.DrawLine(
                Pens.Black,
                centerX, 0,
                centerX, regionPictureBox.ClientSize.Height
            );

            // Стрілки на додатних напрямках осей.
            int right = regionPictureBox.ClientSize.Width - 1;

            graphics.DrawLine(Pens.Black, right, centerY, right - 7, centerY - 4);
            graphics.DrawLine(Pens.Black, right, centerY, right - 7, centerY + 4);

            graphics.DrawLine(Pens.Black, centerX, 0, centerX - 4, 7);
            graphics.DrawLine(Pens.Black, centerX, 0, centerX + 4, 7);

            // Підписуємо осі та координати.
            graphics.DrawString("x", Font, Brushes.Black, right - 14, centerY + 5);
            graphics.DrawString("y", Font, Brushes.Black, centerX + 6, 2);

            graphics.DrawString("-1", Font, Brushes.Black,
                centerX - scale - 8, centerY + 5);

            graphics.DrawString("0", Font, Brushes.Black,
                centerX + 4, centerY + 5);

            graphics.DrawString("1", Font, Brushes.Black,
                centerX + scale - 4, centerY + 5);

            graphics.DrawString("1", Font, Brushes.Black,
                centerX + 5, centerY - scale - 8);

            graphics.DrawString("-1", Font, Brushes.Black,
                centerX + 5, centerY + scale - 8);
        }

        private void DrawSecondRegion(Graphics graphics)
        {
            // Центр координатної системи у PictureBox.
            int centerX = regionPictureBox.ClientSize.Width / 2;
            int centerY = regionPictureBox.ClientSize.Height / 2;

            // Довжина одиничного відрізка у пікселях.
            int scale = 70;

            // Малюємо координатну сітку.
            for (int i = -1; i <= 1; i++)
            {
                int x = centerX + i * scale;
                int y = centerY - i * scale;

                graphics.DrawLine(
                    Pens.LightGray,
                    x, 0,
                    x, regionPictureBox.ClientSize.Height
                );

                graphics.DrawLine(
                    Pens.LightGray,
                    0, y,
                    regionPictureBox.ClientSize.Width, y
                );
            }

            // Зафарбовуємо квадрат зі стороною 2.
            graphics.FillRectangle(
                Brushes.LightGray,
                centerX - scale,
                centerY - scale,
                2 * scale,
                2 * scale
            );

            // Малюємо білий круг радіуса 1 поверх квадрата.
            graphics.FillEllipse(
                Brushes.White,
                centerX - scale,
                centerY - scale,
                2 * scale,
                2 * scale
            );

            // Малюємо контури квадрата та круга.
            graphics.DrawRectangle(
                Pens.Gray,
                centerX - scale,
                centerY - scale,
                2 * scale,
                2 * scale
            );

            graphics.DrawEllipse(
                Pens.Gray,
                centerX - scale,
                centerY - scale,
                2 * scale,
                2 * scale
            );

            // Малюємо координатні осі поверх фігур.
            graphics.DrawLine(
                Pens.Black,
                0, centerY,
                regionPictureBox.ClientSize.Width, centerY
            );

            graphics.DrawLine(
                Pens.Black,
                centerX, 0,
                centerX, regionPictureBox.ClientSize.Height
            );

            // Стрілки на додатних напрямках осей.
            int right = regionPictureBox.ClientSize.Width - 1;

            graphics.DrawLine(Pens.Black, right, centerY, right - 7, centerY - 4);
            graphics.DrawLine(Pens.Black, right, centerY, right - 7, centerY + 4);

            graphics.DrawLine(Pens.Black, centerX, 0, centerX - 4, 7);
            graphics.DrawLine(Pens.Black, centerX, 0, centerX + 4, 7);

            // Підписуємо осі та координати.
            graphics.DrawString("x", Font, Brushes.Black, right - 14, centerY + 5);
            graphics.DrawString("y", Font, Brushes.Black, centerX + 6, 2);

            graphics.DrawString("-1", Font, Brushes.Black,
                centerX - scale - 8, centerY + 5);

            graphics.DrawString("0", Font, Brushes.Black,
                centerX + 4, centerY + 5);

            graphics.DrawString("1", Font, Brushes.Black,
                centerX + scale - 4, centerY + 5);

            graphics.DrawString("1", Font, Brushes.Black,
                centerX + 5, centerY - scale - 8);

            graphics.DrawString("-1", Font, Brushes.Black,
                centerX + 5, centerY + scale - 8);
        }

        private void regionPictureBoxPaint(object sender, PaintEventArgs e)
        {
            if (firstRegionRadioButton.Checked)
            {
                DrawFirstRegion(e.Graphics);
            }
            else if (secondRegionRadioButton.Checked)
            {
                DrawSecondRegion(e.Graphics);
            }

            DrawPoint(e.Graphics);
        }

        private bool TryReadCoordinate(TextBox textBox, string coordinateName, out double value)
        {
            string input = textBox.Text.Trim().Replace(',', '.');

            if (!double.TryParse(
                    input,
                    System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out value))
            {
                MessageBox.Show($"Введіть коректну координату {coordinateName}.");
                return false;
            }

            return true;
        }

        private void checkButtonClick(object sender, EventArgs e)
        {
            // Зчитуємо координату x.
            if (!TryReadCoordinate(xTextBox, "x", out double x))
            {
                return;
            }

            // Зчитуємо координату y.
            if (!TryReadCoordinate(yTextBox, "y", out double y))
            {
                return;
            }

            bool belongsToRegion;

            if (firstRegionRadioButton.Checked)
            {
                // Квадрат у III чверті.
                bool belongsToSquare =
                    x >= -1 && x <= 0 &&
                    y >= -1 && y <= 0;

                // Трикутник у I чверті.
                bool belongsToTriangle =
                    x >= 0 && y >= 0 &&
                    x + y <= 1;

                belongsToRegion = belongsToSquare || belongsToTriangle;
            }
            else
            {
                // Квадрат із круглим вирізом.
                bool belongsToSquare =
                    x >= -1 && x <= 1 &&
                    y >= -1 && y <= 1;

                bool outsideCircle = x * x + y * y >= 1;

                belongsToRegion = belongsToSquare && outsideCircle;
            }

            // Запам'ятовуємо координати для малювання точки.
            pointX = x;
            pointY = y;

            // Виводимо результат перевірки.
            resultLabel.Text = belongsToRegion
                ? "Точка належить зафарбованій області."
                : "Точка не належить зафарбованій області.";

            // Перемальовуємо рисунок разом із точкою.
            regionPictureBox.Invalidate();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void regionRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            regionPictureBox.Invalidate();
        }

        private void PointRegionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
