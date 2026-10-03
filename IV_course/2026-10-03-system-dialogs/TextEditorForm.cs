namespace _2026_10_03_system_dialogs
{
    public partial class TextEditorForm : Form
    {
        // Шлях до поточного відкритого або збереженого файла.
        private string? currentFilePath;

        // Індекс першого символу, який буде надрукований на поточній сторінці.
        private int firstCharacterToPrint;

        public TextEditorForm()
        {
            InitializeComponent();
        }

        // Відображає ім'я поточного файла в заголовку вікна.
        private void updateWindowTitle()
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                Text = "Текстовий редактор";
                return;
            }

            Text = $"Текстовий редактор — {Path.GetFileName(currentFilePath)}";
        }

        private void openMenuItemClick(object sender, EventArgs e)
        {
            openFileDialog.Filter =
                "Текстові файли (*.txt)|*.txt|RTF файли (*.rtf)|*.rtf|Усі файли (*.*)|*.*";

            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;

                // RTF завантажується разом із форматуванням,
                // для інших форматів зчитується звичайний текст.
                if (Path.GetExtension(currentFilePath).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                    editorRichTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                else
                    editorRichTextBox.Text = File.ReadAllText(currentFilePath);

                updateWindowTitle();
            }
        }

        private void saveMenuItemClick(object sender, EventArgs e)
        {
            saveFileDialog.Filter =
                "Текстові файли (*.txt)|*.txt|RTF файли (*.rtf)|*.rtf|Усі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;

                // RTF зберігає форматування тексту,
                // TXT та інші текстові формати зберігають лише символи.
                if (Path.GetExtension(currentFilePath).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                    editorRichTextBox.SaveFile(currentFilePath, RichTextBoxStreamType.RichText);
                else
                    File.WriteAllText(currentFilePath, editorRichTextBox.Text);

                updateWindowTitle();
            }
        }

        private void exitMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void copyMenuItemClick(object sender, EventArgs e)
        {
            editorRichTextBox.Copy();
        }

        private void cutMenuItemClick(object sender, EventArgs e)
        {
            editorRichTextBox.Cut();
        }

        private void pasteMenuItemClick(object sender, EventArgs e)
        {
            editorRichTextBox.Paste();
        }

        private void contextCopyMenuItemClick(object sender, EventArgs e)
        {
            editorRichTextBox.Copy();
        }

        private void contextCutMenuItemClick(object sender, EventArgs e)
        {
            editorRichTextBox.Cut();
        }

        private void contextPasteMenuItemClick(object sender, EventArgs e)
        {
            editorRichTextBox.Paste();
        }

        private void contextFontMenuItemClick(object sender, EventArgs e)
        {
            // Перед відкриттям діалогу встановлюємо шрифт
            // поточного виділеного фрагмента.
            if (editorRichTextBox.SelectionFont != null)
            {
                fontDialog.Font = editorRichTextBox.SelectionFont;
            }

            // Застосовуємо вибраний шрифт тільки до виділеного тексту.
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                editorRichTextBox.SelectionFont = fontDialog.Font;
            }
        }

        private void printMenuItemClick(object sender, EventArgs e)
        {
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                firstCharacterToPrint = 0;
                printDocument.Print();
            }
        }

        private void printDocumentPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics == null)
                return;

            firstCharacterToPrint = RichTextBoxPrinter.Print(
                editorRichTextBox,
                e.Graphics,
                e.MarginBounds,
                e.PageBounds,
                firstCharacterToPrint
            );

            e.HasMorePages = firstCharacterToPrint < editorRichTextBox.TextLength;
        }

        private void helpMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Текстовий редактор\n\n" +
                "Практична робота № 4\n" +
                "«Розробка діалогових вікон. Системні діалоги»\n\n" +
                "Розробник: Тищенко Сергій Сергійович\n" +
                "Група: alk-43\n" +
                "Київ — 2026",
                "Про програму",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
