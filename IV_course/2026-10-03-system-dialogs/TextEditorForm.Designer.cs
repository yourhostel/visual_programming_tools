namespace _2026_10_03_system_dialogs
{
    partial class TextEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainMenuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            openMenuItem = new ToolStripMenuItem();
            saveMenuItem = new ToolStripMenuItem();
            printMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitMenuItem = new ToolStripMenuItem();
            editMenuItem = new ToolStripMenuItem();
            copyMenuItem = new ToolStripMenuItem();
            cutMenuItem = new ToolStripMenuItem();
            pasteMenuItem = new ToolStripMenuItem();
            helpMenuItem = new ToolStripMenuItem();
            editorRichTextBox = new RichTextBox();
            editorContextMenuStrip = new ContextMenuStrip(components);
            contextCopyMenuItem = new ToolStripMenuItem();
            contextCutMenuItem = new ToolStripMenuItem();
            contextPasteMenuItem = new ToolStripMenuItem();
            contextFontMenuItem = new ToolStripMenuItem();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            printDialog = new PrintDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            mainMenuStrip.SuspendLayout();
            editorContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, editMenuItem, helpMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(884, 24);
            mainMenuStrip.TabIndex = 0;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMenuItem, saveMenuItem, printMenuItem, toolStripSeparator1, exitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(48, 20);
            fileMenuItem.Text = "Файл";
            // 
            // openMenuItem
            // 
            openMenuItem.Name = "openMenuItem";
            openMenuItem.Size = new Size(124, 22);
            openMenuItem.Text = "Відкрити";
            openMenuItem.Click += openMenuItemClick;
            // 
            // saveMenuItem
            // 
            saveMenuItem.Name = "saveMenuItem";
            saveMenuItem.Size = new Size(124, 22);
            saveMenuItem.Text = "Зберегти";
            saveMenuItem.Click += saveMenuItemClick;
            // 
            // printMenuItem
            // 
            printMenuItem.Name = "printMenuItem";
            printMenuItem.Size = new Size(124, 22);
            printMenuItem.Text = "Друк";
            printMenuItem.Click += printMenuItemClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(121, 6);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(124, 22);
            exitMenuItem.Text = "Вихід";
            exitMenuItem.Click += exitMenuItemClick;
            // 
            // editMenuItem
            // 
            editMenuItem.DropDownItems.AddRange(new ToolStripItem[] { copyMenuItem, cutMenuItem, pasteMenuItem });
            editMenuItem.Name = "editMenuItem";
            editMenuItem.Size = new Size(59, 20);
            editMenuItem.Text = "Правка";
            // 
            // copyMenuItem
            // 
            copyMenuItem.Name = "copyMenuItem";
            copyMenuItem.Size = new Size(132, 22);
            copyMenuItem.Text = "Копіювати";
            copyMenuItem.Click += copyMenuItemClick;
            // 
            // cutMenuItem
            // 
            cutMenuItem.Name = "cutMenuItem";
            cutMenuItem.Size = new Size(132, 22);
            cutMenuItem.Text = "Вирізати";
            cutMenuItem.Click += cutMenuItemClick;
            // 
            // pasteMenuItem
            // 
            pasteMenuItem.Name = "pasteMenuItem";
            pasteMenuItem.Size = new Size(132, 22);
            pasteMenuItem.Text = "Вставити";
            pasteMenuItem.Click += pasteMenuItemClick;
            // 
            // helpMenuItem
            // 
            helpMenuItem.Name = "helpMenuItem";
            helpMenuItem.Size = new Size(61, 20);
            helpMenuItem.Text = "Довідка";
            // 
            // editorRichTextBox
            // 
            editorRichTextBox.BorderStyle = BorderStyle.FixedSingle;
            editorRichTextBox.ContextMenuStrip = editorContextMenuStrip;
            editorRichTextBox.Dock = DockStyle.Fill;
            editorRichTextBox.Location = new Point(0, 24);
            editorRichTextBox.Name = "editorRichTextBox";
            editorRichTextBox.Size = new Size(884, 537);
            editorRichTextBox.TabIndex = 1;
            editorRichTextBox.Text = "";
            // 
            // editorContextMenuStrip
            // 
            editorContextMenuStrip.Items.AddRange(new ToolStripItem[] { contextCopyMenuItem, contextCutMenuItem, contextPasteMenuItem, contextFontMenuItem });
            editorContextMenuStrip.Name = "editorContextMenuStrip";
            editorContextMenuStrip.Size = new Size(133, 92);
            // 
            // contextCopyMenuItem
            // 
            contextCopyMenuItem.Name = "contextCopyMenuItem";
            contextCopyMenuItem.Size = new Size(132, 22);
            contextCopyMenuItem.Text = "Копіювати";
            contextCopyMenuItem.Click += contextCopyMenuItemClick;
            // 
            // contextCutMenuItem
            // 
            contextCutMenuItem.Name = "contextCutMenuItem";
            contextCutMenuItem.Size = new Size(132, 22);
            contextCutMenuItem.Text = "Вирізати";
            contextCutMenuItem.Click += contextCutMenuItemClick;
            // 
            // contextPasteMenuItem
            // 
            contextPasteMenuItem.Name = "contextPasteMenuItem";
            contextPasteMenuItem.Size = new Size(132, 22);
            contextPasteMenuItem.Text = "Вставити";
            contextPasteMenuItem.Click += contextPasteMenuItemClick;
            // 
            // contextFontMenuItem
            // 
            contextFontMenuItem.Name = "contextFontMenuItem";
            contextFontMenuItem.Size = new Size(132, 22);
            contextFontMenuItem.Text = "Шрифт";
            contextFontMenuItem.Click += contextFontMenuItemClick;
            // 
            // printDialog
            // 
            printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocumentPrintPage;
            // 
            // TextEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(editorRichTextBox);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            MinimumSize = new Size(600, 400);
            Name = "TextEditorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Текстовий редактор";
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            editorContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem openMenuItem;
        private ToolStripMenuItem saveMenuItem;
        private ToolStripMenuItem printMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem copyMenuItem;
        private ToolStripMenuItem cutMenuItem;
        private ToolStripMenuItem pasteMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private RichTextBox editorRichTextBox;
        private ContextMenuStrip editorContextMenuStrip;
        private ToolStripMenuItem contextCopyMenuItem;
        private ToolStripMenuItem contextCutMenuItem;
        private ToolStripMenuItem contextPasteMenuItem;
        private ToolStripMenuItem contextFontMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}
