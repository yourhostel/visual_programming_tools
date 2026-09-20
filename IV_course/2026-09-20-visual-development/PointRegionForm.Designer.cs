namespace _2026_09_20_visual_development
{
    partial class PointRegionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            xLabel = new Label();
            yLabel = new Label();
            regionPictureBox = new PictureBox();
            firstRegionRadioButton = new RadioButton();
            secondRegionRadioButton = new RadioButton();
            xTextBox = new TextBox();
            yTextBox = new TextBox();
            groupBox1 = new GroupBox();
            resultLabel = new Label();
            checkButton = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)regionPictureBox).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(46, 49);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(23, 15);
            xLabel.TabIndex = 0;
            xLabel.Text = "x =";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(46, 87);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(24, 15);
            yLabel.TabIndex = 1;
            yLabel.Text = "y =";
            // 
            // regionPictureBox
            // 
            regionPictureBox.Location = new Point(258, 41);
            regionPictureBox.Name = "regionPictureBox";
            regionPictureBox.Size = new Size(391, 272);
            regionPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            regionPictureBox.TabIndex = 2;
            regionPictureBox.TabStop = false;
            regionPictureBox.Paint += regionPictureBoxPaint;
            // 
            // firstRegionRadioButton
            // 
            firstRegionRadioButton.AutoSize = true;
            firstRegionRadioButton.Checked = true;
            firstRegionRadioButton.Location = new Point(16, 27);
            firstRegionRadioButton.Name = "firstRegionRadioButton";
            firstRegionRadioButton.Size = new Size(80, 19);
            firstRegionRadioButton.TabIndex = 3;
            firstRegionRadioButton.TabStop = true;
            firstRegionRadioButton.Text = "Область 1";
            firstRegionRadioButton.UseVisualStyleBackColor = true;
            firstRegionRadioButton.CheckedChanged += regionRadioButtonCheckedChanged;
            // 
            // secondRegionRadioButton
            // 
            secondRegionRadioButton.AutoSize = true;
            secondRegionRadioButton.Location = new Point(16, 64);
            secondRegionRadioButton.Name = "secondRegionRadioButton";
            secondRegionRadioButton.Size = new Size(80, 19);
            secondRegionRadioButton.TabIndex = 4;
            secondRegionRadioButton.Text = "Область 2";
            secondRegionRadioButton.UseVisualStyleBackColor = true;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(120, 41);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(100, 23);
            xTextBox.TabIndex = 5;
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(120, 79);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(100, 23);
            yTextBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(firstRegionRadioButton);
            groupBox1.Controls.Add(secondRegionRadioButton);
            groupBox1.Location = new Point(46, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 100);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Обрати";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(258, 327);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 8;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(200, 379);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(100, 23);
            checkButton.TabIndex = 9;
            checkButton.Text = "Перевірити";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(361, 379);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(100, 23);
            closeButton.TabIndex = 10;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // PointRegionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 414);
            Controls.Add(closeButton);
            Controls.Add(checkButton);
            Controls.Add(resultLabel);
            Controls.Add(groupBox1);
            Controls.Add(yTextBox);
            Controls.Add(xTextBox);
            Controls.Add(regionPictureBox);
            Controls.Add(yLabel);
            Controls.Add(xLabel);
            Name = "PointRegionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Належність точки області";
            Load += PointRegionForm_Load;
            ((System.ComponentModel.ISupportInitialize)regionPictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label xLabel;
        private Label yLabel;
        private PictureBox regionPictureBox;
        private RadioButton firstRegionRadioButton;
        private RadioButton secondRegionRadioButton;
        private TextBox xTextBox;
        private TextBox yTextBox;
        private GroupBox groupBox1;
        private Label resultLabel;
        private Button checkButton;
        private Button closeButton;
    }
}