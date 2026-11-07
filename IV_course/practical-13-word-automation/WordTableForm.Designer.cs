namespace WordAutomation;

partial class WordTableForm
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
        labelTitle = new Label();
        labelRows = new Label();
        labelColumns = new Label();
        numericRows = new NumericUpDown();
        numericColumns = new NumericUpDown();
        buttonGenerate = new Button();
        ((System.ComponentModel.ISupportInitialize)numericRows).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericColumns).BeginInit();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Location = new Point(28, 19);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(198, 15);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Генератор таблиць Microsoft Word";
        // 
        // labelRows
        // 
        labelRows.AutoSize = true;
        labelRows.Location = new Point(28, 69);
        labelRows.Name = "labelRows";
        labelRows.Size = new Size(93, 15);
        labelRows.TabIndex = 1;
        labelRows.Text = "Кількість рядків";
        labelRows.Click += label2_Click;
        // 
        // labelColumns
        // 
        labelColumns.AutoSize = true;
        labelColumns.Location = new Point(28, 108);
        labelColumns.Name = "labelColumns";
        labelColumns.Size = new Size(106, 15);
        labelColumns.TabIndex = 2;
        labelColumns.Text = "Кількість стовпців";
        // 
        // numericRows
        // 
        numericRows.Location = new Point(201, 69);
        numericRows.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        numericRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericRows.Name = "numericRows";
        numericRows.Size = new Size(120, 23);
        numericRows.TabIndex = 3;
        numericRows.Value = new decimal(new int[] { 5, 0, 0, 0 });
        // 
        // numericColumns
        // 
        numericColumns.Location = new Point(201, 104);
        numericColumns.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
        numericColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        numericColumns.Name = "numericColumns";
        numericColumns.Size = new Size(120, 23);
        numericColumns.TabIndex = 4;
        numericColumns.Value = new decimal(new int[] { 4, 0, 0, 0 });
        // 
        // buttonGenerate
        // 
        buttonGenerate.Location = new Point(212, 169);
        buttonGenerate.Name = "buttonGenerate";
        buttonGenerate.Size = new Size(180, 40);
        buttonGenerate.TabIndex = 5;
        buttonGenerate.Text = "Створити таблицю";
        buttonGenerate.UseVisualStyleBackColor = true;
        buttonGenerate.Click += buttonGenerateClick;
        // 
        // WordTableForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(404, 221);
        Controls.Add(buttonGenerate);
        Controls.Add(numericColumns);
        Controls.Add(numericRows);
        Controls.Add(labelColumns);
        Controls.Add(labelRows);
        Controls.Add(labelTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimumSize = new Size(420, 260);
        Name = "WordTableForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Практична №13. Генератор таблиць Word";
        ((System.ComponentModel.ISupportInitialize)numericRows).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericColumns).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private Label labelRows;
    private Label labelColumns;
    private NumericUpDown numericRows;
    private NumericUpDown numericColumns;
    private Button buttonGenerate;
}
