namespace _2026_09_20_visual_development
{
    partial class MinimumForm
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
            zLabel = new Label();
            resultCaptionLabel = new Label();
            resultLabel = new Label();
            xTextBox = new TextBox();
            yTextBox = new TextBox();
            zTextBox = new TextBox();
            calculateButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(83, 39);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(23, 15);
            xLabel.TabIndex = 0;
            xLabel.Text = "x =";
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(83, 75);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(24, 15);
            yLabel.TabIndex = 1;
            yLabel.Text = "y =";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Location = new Point(83, 111);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(23, 15);
            zLabel.TabIndex = 2;
            zLabel.Text = "z =";
            // 
            // resultCaptionLabel
            // 
            resultCaptionLabel.AutoSize = true;
            resultCaptionLabel.Location = new Point(83, 189);
            resultCaptionLabel.Name = "resultCaptionLabel";
            resultCaptionLabel.Size = new Size(116, 15);
            resultCaptionLabel.TabIndex = 3;
            resultCaptionLabel.Text = "Найменше число =";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(205, 189);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 4;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(158, 31);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(100, 23);
            xTextBox.TabIndex = 5;
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(158, 67);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(100, 23);
            yTextBox.TabIndex = 6;
            // 
            // zTextBox
            // 
            zTextBox.Location = new Point(158, 103);
            zTextBox.Name = "zTextBox";
            zTextBox.Size = new Size(100, 23);
            zTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(83, 263);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(89, 23);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(205, 263);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 9;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // MinimumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 352);
            Controls.Add(closeButton);
            Controls.Add(calculateButton);
            Controls.Add(zTextBox);
            Controls.Add(yTextBox);
            Controls.Add(xTextBox);
            Controls.Add(resultLabel);
            Controls.Add(resultCaptionLabel);
            Controls.Add(zLabel);
            Controls.Add(yLabel);
            Controls.Add(xLabel);
            Name = "MinimumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Найменше з трьох чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label xLabel;
        private Label yLabel;
        private Label zLabel;
        private Label resultCaptionLabel;
        private Label resultLabel;
        private TextBox xTextBox;
        private TextBox yTextBox;
        private TextBox zTextBox;
        private Button calculateButton;
        private Button closeButton;
    }
}