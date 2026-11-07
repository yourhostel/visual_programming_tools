using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;

namespace WordAutomation
{
    public partial class WordTableForm : Form
    {
        public WordTableForm()
        {
            InitializeComponent();
        }

        private void buttonGenerateClick(object sender, EventArgs e)
        {
            Word.Application? word = null;
            Word.Document? document = null;

            try
            {
                int rows = (int)numericRows.Value;
                int columns = (int)numericColumns.Value;

                // Створення нового документа Word.
                word = new Word.Application();
                document = word.Documents.Add();

                // Заголовок документа.
                Word.Paragraph title = document.Paragraphs.Add();
                title.Range.Text = "Автоматично згенерована таблиця";
                title.Range.Font.Bold = 1;
                title.Range.Font.Size = 16;
                title.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();

                // Створення таблиці після заголовка.
                Word.Range range = document.Range(
                    document.Content.End - 1,
                    document.Content.End - 1
                );

                Word.Table table = document.Tables.Add(
                    range, rows, columns
                );

                // Межі та вирівнювання таблиці.
                table.Borders.Enable = 1;
                table.Range.ParagraphFormat.Alignment =
                    Word.WdParagraphAlignment.wdAlignParagraphCenter;

                // Звичайний шрифт для всієї таблиці.
                table.Range.Font.Bold = 0;
                table.Range.Font.Size = 11;

                // Заповнення клітинок.
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= columns; j++)
                    {
                        table.Cell(i, j).Range.Text =
                            i == 1
                                ? $"Стовпець {j}"
                                : $"Рядок {i}, стовпець {j}";
                    }
                }

                // Перший рядок жирним шрифтом.
                table.Rows[1].Range.Bold = 1;

                // Показ документа користувачеві.
                word.Visible = true;
                word.Activate();
            }
            catch (COMException ex)
            {
                MessageBox.Show(
                    $"Помилка взаємодії з Microsoft Word:\n{ex.Message}",
                    "Помилка COM",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                if (word != null)
                    word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не вдалося створити документ.\n" +
                    $"Перевірте, чи встановлено Microsoft Word.\n\n{ex.Message}",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                if (word != null)
                    word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
