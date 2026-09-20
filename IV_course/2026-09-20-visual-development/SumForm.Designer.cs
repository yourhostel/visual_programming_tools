namespace _2026_09_20_visual_development
{
    partial class SumForm
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
            firstNumberLabel = new Label();
            secondNumberLabel = new Label();
            firstNumberTextBox = new TextBox();
            secondNumberTextBox = new TextBox();
            resultCaptionLabel = new Label();
            resultLabel = new Label();
            calculateButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // firstNumberLabel
            // 
            firstNumberLabel.AutoSize = true;
            firstNumberLabel.Location = new Point(47, 41);
            firstNumberLabel.Name = "firstNumberLabel";
            firstNumberLabel.Size = new Size(24, 15);
            firstNumberLabel.TabIndex = 0;
            firstNumberLabel.Text = "a =";
            // 
            // secondNumberLabel
            // 
            secondNumberLabel.AutoSize = true;
            secondNumberLabel.Location = new Point(46, 77);
            secondNumberLabel.Name = "secondNumberLabel";
            secondNumberLabel.Size = new Size(25, 15);
            secondNumberLabel.TabIndex = 1;
            secondNumberLabel.Text = "b =";
            // 
            // firstNumberTextBox
            // 
            firstNumberTextBox.Location = new Point(122, 39);
            firstNumberTextBox.Name = "firstNumberTextBox";
            firstNumberTextBox.Size = new Size(100, 23);
            firstNumberTextBox.TabIndex = 2;
            // 
            // secondNumberTextBox
            // 
            secondNumberTextBox.Location = new Point(123, 77);
            secondNumberTextBox.Name = "secondNumberTextBox";
            secondNumberTextBox.Size = new Size(100, 23);
            secondNumberTextBox.TabIndex = 3;
            // 
            // resultCaptionLabel
            // 
            resultCaptionLabel.AutoSize = true;
            resultCaptionLabel.Location = new Point(47, 117);
            resultCaptionLabel.Name = "resultCaptionLabel";
            resultCaptionLabel.Size = new Size(45, 15);
            resultCaptionLabel.TabIndex = 4;
            resultCaptionLabel.Text = "a + b =";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(123, 117);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(46, 167);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(81, 23);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(148, 167);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(83, 23);
            closeButton.TabIndex = 7;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // SumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 208);
            Controls.Add(closeButton);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Controls.Add(resultCaptionLabel);
            Controls.Add(secondNumberTextBox);
            Controls.Add(firstNumberTextBox);
            Controls.Add(secondNumberLabel);
            Controls.Add(firstNumberLabel);
            Name = "SumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сума двох чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNumberLabel;
        private Label secondNumberLabel;
        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private Label resultCaptionLabel;
        private Label resultLabel;
        private Button calculateButton;
        private Button closeButton;
    }
}
