namespace ExcelAutomation;

partial class ExcelEquationForm
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
        labelResultTitle = new Label();
        labelX1 = new Label();
        labelX2 = new Label();
        labelX3 = new Label();
        labelVerification = new Label();
        buttonSolve = new Button();
        labelSeparator = new Label();
        textEquation1 = new TextBox();
        textEquation2 = new TextBox();
        textEquation3 = new TextBox();
        comboVariant = new ComboBox();
        labelVariant = new Label();
        SuspendLayout();
        // 
        // labelTitle
        // 
        labelTitle.AutoSize = true;
        labelTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelTitle.Location = new Point(12, 9);
        labelTitle.Name = "labelTitle";
        labelTitle.Size = new Size(190, 19);
        labelTitle.TabIndex = 0;
        labelTitle.Text = "Система лінійних рівнянь";
        // 
        // labelResultTitle
        // 
        labelResultTitle.AutoSize = true;
        labelResultTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelResultTitle.Location = new Point(12, 210);
        labelResultTitle.Name = "labelResultTitle";
        labelResultTitle.Size = new Size(173, 19);
        labelResultTitle.TabIndex = 4;
        labelResultTitle.Text = "Результати обчислення";
        // 
        // labelX1
        // 
        labelX1.AutoSize = true;
        labelX1.Location = new Point(12, 236);
        labelX1.Name = "labelX1";
        labelX1.Size = new Size(39, 15);
        labelX1.TabIndex = 5;
        labelX1.Text = "x₁ = ...";
        // 
        // labelX2
        // 
        labelX2.AutoSize = true;
        labelX2.Location = new Point(12, 260);
        labelX2.Name = "labelX2";
        labelX2.Size = new Size(39, 15);
        labelX2.TabIndex = 6;
        labelX2.Text = "x₂ = ...";
        // 
        // labelX3
        // 
        labelX3.AutoSize = true;
        labelX3.Location = new Point(12, 287);
        labelX3.Name = "labelX3";
        labelX3.Size = new Size(39, 15);
        labelX3.TabIndex = 7;
        labelX3.Text = "x₃ = ...";
        // 
        // labelVerification
        // 
        labelVerification.AutoSize = true;
        labelVerification.Location = new Point(12, 316);
        labelVerification.Name = "labelVerification";
        labelVerification.Size = new Size(200, 15);
        labelVerification.TabIndex = 8;
        labelVerification.Text = "Перевірка: очікування обчислення";
        // 
        // buttonSolve
        // 
        buttonSolve.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        buttonSolve.FlatStyle = FlatStyle.System;
        buttonSolve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        buttonSolve.Location = new Point(12, 138);
        buttonSolve.Name = "buttonSolve";
        buttonSolve.Size = new Size(460, 40);
        buttonSolve.TabIndex = 9;
        buttonSolve.Text = "Розв'язати систему";
        buttonSolve.UseVisualStyleBackColor = true;
        buttonSolve.Click += button1_Click;
        // 
        // labelSeparator
        // 
        labelSeparator.BorderStyle = BorderStyle.Fixed3D;
        labelSeparator.Location = new Point(12, 192);
        labelSeparator.Name = "labelSeparator";
        labelSeparator.Size = new Size(460, 2);
        labelSeparator.TabIndex = 10;
        // 
        // textEquation1
        // 
        textEquation1.Location = new Point(60, 41);
        textEquation1.Name = "textEquation1";
        textEquation1.Size = new Size(100, 23);
        textEquation1.TabIndex = 11;
        textEquation1.Text = "2x1+3x2+5x3=10";
        // 
        // textEquation2
        // 
        textEquation2.Location = new Point(60, 74);
        textEquation2.Name = "textEquation2";
        textEquation2.Size = new Size(100, 23);
        textEquation2.TabIndex = 12;
        textEquation2.Text = "3x1+7x2+4x3=3";
        // 
        // textEquation3
        // 
        textEquation3.Location = new Point(62, 109);
        textEquation3.Name = "textEquation3";
        textEquation3.Size = new Size(100, 23);
        textEquation3.TabIndex = 13;
        textEquation3.Text = "x1+2x2+2x3=3";
        // 
        // comboVariant
        // 
        comboVariant.DropDownStyle = ComboBoxStyle.DropDownList;
        comboVariant.FormattingEnabled = true;
        comboVariant.Location = new Point(234, 74);
        comboVariant.Name = "comboVariant";
        comboVariant.Size = new Size(121, 23);
        comboVariant.TabIndex = 14;
        comboVariant.SelectedIndexChanged += comboVariant_SelectedIndexChanged;
        // 
        // labelVariant
        // 
        labelVariant.AutoSize = true;
        labelVariant.Location = new Point(234, 44);
        labelVariant.Name = "labelVariant";
        labelVariant.Size = new Size(97, 15);
        labelVariant.TabIndex = 15;
        labelVariant.Text = "Варіант системи";
        // 
        // ExcelEquationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 351);
        Controls.Add(labelVariant);
        Controls.Add(comboVariant);
        Controls.Add(textEquation3);
        Controls.Add(textEquation2);
        Controls.Add(textEquation1);
        Controls.Add(labelSeparator);
        Controls.Add(buttonSolve);
        Controls.Add(labelVerification);
        Controls.Add(labelX3);
        Controls.Add(labelX2);
        Controls.Add(labelX1);
        Controls.Add(labelResultTitle);
        Controls.Add(labelTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "ExcelEquationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Практична №14. Розв'язання системи рівнянь";
        Paint += ExcelEquationForm_Paint;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelTitle;
    private Label labelResultTitle;
    private Label labelX1;
    private Label labelX2;
    private Label labelX3;
    private Label labelVerification;
    private Button buttonSolve;
    private Label labelSeparator;
    private TextBox textEquation1;
    private TextBox textEquation2;
    private TextBox textEquation3;
    private ComboBox comboVariant;
    private Label labelVariant;
}
