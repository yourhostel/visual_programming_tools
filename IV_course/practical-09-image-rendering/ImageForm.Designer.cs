namespace ImageRendering;

partial class ImageForm
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
        comboImage = new ComboBox();
        comboScale = new ComboBox();
        SuspendLayout();
        // 
        // comboImage
        // 
        comboImage.DropDownStyle = ComboBoxStyle.DropDownList;
        comboImage.FormattingEnabled = true;
        comboImage.Location = new Point(20, 20);
        comboImage.Name = "comboImage";
        comboImage.Size = new Size(211, 23);
        comboImage.TabIndex = 0;
        // 
        // comboScale
        // 
        comboScale.DropDownStyle = ComboBoxStyle.DropDownList;
        comboScale.FormattingEnabled = true;
        comboScale.Items.AddRange(new object[] { "100%", "75%", "50%", "25%" });
        comboScale.Location = new Point(237, 20);
        comboScale.Name = "comboScale";
        comboScale.Size = new Size(211, 23);
        comboScale.TabIndex = 1;
        // 
        // ImageForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(884, 611);
        Controls.Add(comboScale);
        Controls.Add(comboImage);
        Name = "ImageForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Практична №9. Виведення графічного зображення";
        ResumeLayout(false);
    }

    #endregion

    private ComboBox comboImage;
    private ComboBox comboScale;
}
