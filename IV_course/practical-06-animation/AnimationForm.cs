using System.Drawing.Drawing2D;

namespace DrawingAnimation;

public partial class AnimationForm : Form
{
    private readonly System.Windows.Forms.Timer animationTimer = new();

    // Поточні координати базової точки автомобіля.
    private int carX = 0;
    private const int CarY = 100;
    private const int CarWidth = 360;
    private const int Speed = 5;

    public AnimationForm()
    {
        InitializeComponent();

        Text = "Практична №6. Анімація автомобіля";
        ClientSize = new Size(800, 350);
        BackColor = Color.White;
        DoubleBuffered = true;

        // Таймер оновлює положення автомобіля кожні 30 мс.
        animationTimer.Interval = 30;
        animationTimer.Tick += AnimationTimer_Tick;
        animationTimer.Start();
    }

    private void AnimationTimer_Tick(object? sender, EventArgs e)
    {
        // Переміщення базової точки вправо.
        carX += Speed;

        // Повернення автомобіля після виходу за праву межу.
        if (carX > ClientSize.Width)
        {
            carX = -CarWidth;
        }

        // Виклик повторного малювання форми.
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        DrawCar(e.Graphics, carX, CarY);
    }

    private static void DrawCar(Graphics g, int x, int y)
    {
        using Pen outline = new(Color.Black, 2);
        using Brush body = new SolidBrush(Color.SteelBlue);
        using Brush glass = new SolidBrush(Color.LightSkyBlue);
        using Brush wheel = new SolidBrush(Color.Black);
        using Brush hub = new SolidBrush(Color.LightGray);

        // Кузов.
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