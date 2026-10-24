using System.Drawing.Drawing2D;

namespace BasePointDrawing;

public partial class DrawingForm : Form
{
    public DrawingForm()
    {
        InitializeComponent();

        Text = "Практична №5. Метод базової точки";
        ClientSize = new Size(800, 450);
        BackColor = Color.White;
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Координати базової точки.
        DrawCar(e.Graphics, 180, 150);
    }

    private static void DrawCar(Graphics g, int x, int y)
    {
        using Pen outline = new(Color.Black, 2);
        using Brush body = new SolidBrush(Color.SteelBlue);
        using Brush glass = new SolidBrush(Color.LightSkyBlue);
        using Brush wheel = new SolidBrush(Color.Black);
        using Brush hub = new SolidBrush(Color.LightGray);

        // Кузов автомобіля.
        g.FillRectangle(body, x, y + 70, 360, 90);
        g.DrawRectangle(outline, x, y + 70, 360, 90);

        // Кабіна.
        Point[] cabin =
        [
            new(x + 75, y + 70),
            new(x + 125, y),
            new(x + 245, y),
            new(x + 300, y + 70)
        ];

        g.FillPolygon(body, cabin);
        g.DrawPolygon(outline, cabin);

        // Вікна.
        Point[] leftWindow =
        [
            new(x + 100, y + 65),
            new(x + 135, y + 12),
            new(x + 180, y + 12),
            new(x + 180, y + 65)
        ];

        Point[] rightWindow =
        [
            new(x + 190, y + 12),
            new(x + 237, y + 12),
            new(x + 278, y + 65),
            new(x + 190, y + 65)
        ];

        g.FillPolygon(glass, leftWindow);
        g.FillPolygon(glass, rightWindow);

        g.DrawPolygon(outline, leftWindow);
        g.DrawPolygon(outline, rightWindow);

        // Колеса.
        g.FillEllipse(wheel, x + 55, y + 130, 70, 70);
        g.FillEllipse(wheel, x + 245, y + 130, 70, 70);

        // Диски.
        g.FillEllipse(hub, x + 75, y + 150, 30, 30);
        g.FillEllipse(hub, x + 265, y + 150, 30, 30);

        // Фари.
        g.FillRectangle(Brushes.Yellow, x + 340, y + 90, 20, 20);
        g.FillRectangle(Brushes.Red, x, y + 90, 15, 20);
    }
}
