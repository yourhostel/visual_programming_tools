using System.Runtime.InteropServices;

namespace _2026_10_03_system_dialogs
{
    internal static class RichTextBoxPrinter
    {
        private const int EmFormatRange = 0x0439;

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct CharRange
        {
            public int Min;
            public int Max;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct FormatRange
        {
            public IntPtr Hdc;
            public IntPtr HdcTarget;
            public Rect Area;
            public Rect Page;
            public CharRange Range;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            int msg,
            IntPtr wParam,
            IntPtr lParam
        );

        public static int Print(
            RichTextBox richTextBox,
            Graphics graphics,
            Rectangle marginBounds,
            Rectangle pageBounds,
            int firstCharacter)
        {
            const double twipsPerInch = 1440.0;

            using Graphics referenceGraphics = richTextBox.CreateGraphics();

            Rect area = new()
            {
                Left = (int)(marginBounds.Left * twipsPerInch / referenceGraphics.DpiX),
                Top = (int)(marginBounds.Top * twipsPerInch / referenceGraphics.DpiY),
                Right = (int)(marginBounds.Right * twipsPerInch / referenceGraphics.DpiX),
                Bottom = (int)(marginBounds.Bottom * twipsPerInch / referenceGraphics.DpiY)
            };

            Rect page = new()
            {
                Left = (int)(pageBounds.Left * twipsPerInch / referenceGraphics.DpiX),
                Top = (int)(pageBounds.Top * twipsPerInch / referenceGraphics.DpiY),
                Right = (int)(pageBounds.Right * twipsPerInch / referenceGraphics.DpiX),
                Bottom = (int)(pageBounds.Bottom * twipsPerInch / referenceGraphics.DpiY)
            };

            IntPtr hdc = graphics.GetHdc();

            FormatRange formatRange = new()
            {
                Hdc = hdc,
                HdcTarget = hdc,
                Area = area,
                Page = page,
                Range = new CharRange
                {
                    Min = firstCharacter,
                    Max = richTextBox.TextLength
                }
            };

            IntPtr formatRangePointer = Marshal.AllocCoTaskMem(
                Marshal.SizeOf<FormatRange>()
            );

            try
            {
                Marshal.StructureToPtr(
                    formatRange,
                    formatRangePointer,
                    false
                );

                return SendMessage(
                    richTextBox.Handle,
                    EmFormatRange,
                    new IntPtr(1),
                    formatRangePointer
                ).ToInt32();
            }
            finally
            {
                Marshal.FreeCoTaskMem(formatRangePointer);
                graphics.ReleaseHdc(hdc);

                // Звільнення кешованої інформації форматування RichEdit.
                SendMessage(
                    richTextBox.Handle,
                    EmFormatRange,
                    IntPtr.Zero,
                    IntPtr.Zero
                );
            }
        }
    }
}
