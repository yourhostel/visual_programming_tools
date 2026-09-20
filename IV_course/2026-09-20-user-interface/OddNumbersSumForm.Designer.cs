namespace _2026_09_20_user_interface
{
    partial class OddNumbersSumForm
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
            startLabel = new Label();
            endLabel = new Label();
            resultCaptionLabel = new Label();
            resultLabel = new Label();
            startTextBox = new TextBox();
            endTextBox = new TextBox();
            calculateButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new Point(94, 37);
            startLabel.Name = "startLabel";
            startLabel.Size = new Size(26, 15);
            startLabel.TabIndex = 0;
            startLabel.Text = "A =";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(94, 68);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(25, 15);
            endLabel.TabIndex = 1;
            endLabel.Text = "B =";
            // 
            // resultCaptionLabel
            // 
            resultCaptionLabel.AutoSize = true;
            resultCaptionLabel.Location = new Point(103, 98);
            resultCaptionLabel.Name = "resultCaptionLabel";
            resultCaptionLabel.Size = new Size(130, 15);
            resultCaptionLabel.TabIndex = 2;
            resultCaptionLabel.Text = "Сума непарних чисел:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(162, 124);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(12, 15);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "_";
            // 
            // startTextBox
            // 
            startTextBox.Location = new Point(153, 29);
            startTextBox.Name = "startTextBox";
            startTextBox.Size = new Size(100, 23);
            startTextBox.TabIndex = 4;
            // 
            // endTextBox
            // 
            endTextBox.Location = new Point(153, 60);
            endTextBox.Name = "endTextBox";
            endTextBox.Size = new Size(100, 23);
            endTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(128, 164);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(91, 23);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(128, 193);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(91, 23);
            closeButton.TabIndex = 7;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // OddNumbersSumForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 228);
            Controls.Add(closeButton);
            Controls.Add(calculateButton);
            Controls.Add(endTextBox);
            Controls.Add(startTextBox);
            Controls.Add(resultLabel);
            Controls.Add(resultCaptionLabel);
            Controls.Add(endLabel);
            Controls.Add(startLabel);
            Name = "OddNumbersSumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сума непарних чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startLabel;
        private Label endLabel;
        private Label resultCaptionLabel;
        private Label resultLabel;
        private TextBox startTextBox;
        private TextBox endTextBox;
        private Button calculateButton;
        private Button closeButton;
    }
}