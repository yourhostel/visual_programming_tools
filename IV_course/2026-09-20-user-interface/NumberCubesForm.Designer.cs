namespace _2026_09_20_user_interface
{
    partial class NumberCubesForm
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
            descriptionLabel = new Label();
            resultTextBox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(46, 29);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(187, 15);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Куби чисел від 1 до 9 із кроком 2";
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(52, 66);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(99, 120);
            resultTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(289, 66);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(95, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(289, 111);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(95, 23);
            clearButton.TabIndex = 3;
            clearButton.Text = "Очистити";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(289, 155);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(95, 23);
            closeButton.TabIndex = 4;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // NumberCubesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 203);
            Controls.Add(closeButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(resultTextBox);
            Controls.Add(descriptionLabel);
            Name = "NumberCubesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Куби чисел";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private TextBox resultTextBox;
        private Button calculateButton;
        private Button clearButton;
        private Button closeButton;
    }
}