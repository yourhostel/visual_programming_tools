namespace _2026_09_20_visual_development
{
    partial class CalculatorForm
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
            firstNumberLabel = new Label();
            secondNumberLabel = new Label();
            operationLabel = new Label();
            firstNumberTextBox = new TextBox();
            secondNumberTextBox = new TextBox();
            operationTextBox = new TextBox();
            resultCaptionLabel = new Label();
            calculateButton = new Button();
            closeButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // firstNumberLabel
            // 
            firstNumberLabel.AutoSize = true;
            firstNumberLabel.Location = new Point(95, 47);
            firstNumberLabel.Name = "firstNumberLabel";
            firstNumberLabel.Size = new Size(24, 15);
            firstNumberLabel.TabIndex = 0;
            firstNumberLabel.Text = "a =";
            // 
            // secondNumberLabel
            // 
            secondNumberLabel.AutoSize = true;
            secondNumberLabel.Location = new Point(95, 80);
            secondNumberLabel.Name = "secondNumberLabel";
            secondNumberLabel.Size = new Size(25, 15);
            secondNumberLabel.TabIndex = 1;
            secondNumberLabel.Text = "b =";
            // 
            // operationLabel
            // 
            operationLabel.AutoSize = true;
            operationLabel.Location = new Point(95, 114);
            operationLabel.Name = "operationLabel";
            operationLabel.Size = new Size(61, 15);
            operationLabel.TabIndex = 2;
            operationLabel.Text = "Операція:";
            // 
            // firstNumberTextBox
            // 
            firstNumberTextBox.Location = new Point(165, 39);
            firstNumberTextBox.Name = "firstNumberTextBox";
            firstNumberTextBox.Size = new Size(100, 23);
            firstNumberTextBox.TabIndex = 3;
            // 
            // secondNumberTextBox
            // 
            secondNumberTextBox.Location = new Point(165, 72);
            secondNumberTextBox.Name = "secondNumberTextBox";
            secondNumberTextBox.Size = new Size(100, 23);
            secondNumberTextBox.TabIndex = 4;
            // 
            // operationTextBox
            // 
            operationTextBox.Location = new Point(165, 106);
            operationTextBox.Name = "operationTextBox";
            operationTextBox.Size = new Size(100, 23);
            operationTextBox.TabIndex = 5;
            // 
            // resultCaptionLabel
            // 
            resultCaptionLabel.AutoSize = true;
            resultCaptionLabel.Location = new Point(95, 180);
            resultCaptionLabel.Name = "resultCaptionLabel";
            resultCaptionLabel.Size = new Size(63, 15);
            resultCaptionLabel.TabIndex = 6;
            resultCaptionLabel.Text = "Результат:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(95, 255);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 8;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(190, 255);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 9;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(165, 180);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 15);
            resultLabel.TabIndex = 7;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 342);
            Controls.Add(closeButton);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Controls.Add(resultCaptionLabel);
            Controls.Add(operationTextBox);
            Controls.Add(secondNumberTextBox);
            Controls.Add(firstNumberTextBox);
            Controls.Add(operationLabel);
            Controls.Add(secondNumberLabel);
            Controls.Add(firstNumberLabel);
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Арифметичні операції";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNumberLabel;
        private Label secondNumberLabel;
        private Label operationLabel;
        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private TextBox operationTextBox;
        private Label resultCaptionLabel;
        private Button calculateButton;
        private Button closeButton;
        private Label resultLabel;
    }
}