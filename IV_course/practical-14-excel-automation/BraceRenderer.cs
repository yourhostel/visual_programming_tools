using System.Drawing.Drawing2D;

namespace ExcelAutomation
{
    public static class BraceRenderer
    {
        public static void DrawBrace(
            Graphics graphics,
            float x,
            float y,
            float width,
            float height,
            float thickness = 1.2f,
            Color? color = null,
            bool opening = true)
        {
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using Pen pen = new(color ?? Color.Black, thickness);
            using GraphicsPath path = new();

            float s = opening ? 1f : -1f;
            float edge = opening ? x + width : x;
            float mid = y + height / 2f;

            float a = width * 0.65f;
            float b = height * 0.12f;

            // Верхній зовнішній вигин
            path.AddBezier(
                edge, y,
                edge - s * a, y,
                edge - s * a, y + b,
                edge - s * a, y + height * 0.25f
            );

            // Перехід до гострого центрального виступу
            path.AddBezier(
                edge - s * a, y + height * 0.25f,
                edge - s * a, mid - b * 0.25f,
                edge - s * width * 0.45f, mid,
                edge - s * width, mid
            );

            // Дзеркальна нижня половина
            path.AddBezier(
                edge - s * width, mid,
                edge - s * width * 0.45f, mid,
                edge - s * a, mid + b * 0.25f,
                edge - s * a, y + height * 0.75f
            );

            path.AddBezier(
                edge - s * a, y + height * 0.75f,
                edge - s * a, y + height - b,
                edge - s * a, y + height,
                edge, y + height
            );

            graphics.DrawPath(pen, path);
        }
    }
}