
namespace ImageRendering;

public partial class ImageForm : Form
{
    private Image? image;
    private bool scaled = false;

    // Файли зображень
    private readonly string[] imageFiles =
    {
        "fruit_still_life.png",
        "bouquet_autumn_leaves.png",
        "frog.png"
    };

    public ImageForm()
    {
        InitializeComponent();

        comboScale.SelectedIndexChanged += (_, _) => Invalidate();
        comboScale.SelectedIndex = 0;

        DoubleBuffered = true;
        Resize += (_, _) => Invalidate();

        DoubleBuffered = true;
        ResizeRedraw = true;
        KeyPreview = true;

        // Заповнення випадаючого списку
        comboImage.Items.AddRange(
        [
            "Фруктовий натюрморт",
            "Осінній букет",
            "Жаба"
        ]);

        comboImage.SelectedIndexChanged += (_, _) => LoadImage();
        comboImage.SelectedIndex = 0;
    }

    private void LoadImage()
    {
        string path = Path.Combine(
            AppContext.BaseDirectory,
            "assets",
            imageFiles[comboImage.SelectedIndex]);

        try
        {
            // Завантаження нового зображення
            Image newImage = Image.FromFile(path);

            // Звільнення попереднього зображення
            Image? previousImage = image;
            image = newImage;
            previousImage?.Dispose();

            Invalidate();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Помилка завантаження: {ex.Message}");
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (image is null)
            return;

        // Доступна область під ComboBox
        Rectangle area = new(
            10,
            Math.Max(comboImage.Bottom, comboScale.Bottom) + 10,
            ClientSize.Width - 20,
            ClientSize.Height - Math.Max(comboImage.Bottom, comboScale.Bottom) - 20
        );

        if (area.Width <= 0 || area.Height <= 0)
            return;

        // Масштабування зі збереженням пропорцій
        float scale = Math.Min(
            (float)area.Width / image.Width,
            (float)area.Height / image.Height
        );

        // Додатковий масштаб із випадаючого списку
        float factor = comboScale.SelectedIndex switch
        {
            1 => 0.75f,
            2 => 0.50f,
            3 => 0.25f,
            _ => 1.00f
        };

        scale *= factor;

        int width = (int)(image.Width * scale);
        int height = (int)(image.Height * scale);

        // Центрування зображення
        int x = area.Left + (area.Width - width) / 2;
        int y = area.Top + (area.Height - height) / 2;

        // Виведення зображення
        e.Graphics.DrawImage(image, x, y, width, height);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        base.OnKeyDown(e);

        // Перемикання режиму клавішею Space
        if (e.KeyCode == Keys.Space)
        {
            scaled = !scaled;
            Invalidate();
            e.Handled = true;
        }
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        image?.Dispose();
        base.OnFormClosed(e);
    }
}

