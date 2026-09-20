namespace _2026_09_20_user_interface
{
    partial class MainForm
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
            productCostButton = new Button();
            oddNumbersSumButton = new Button();
            numberCubesButton = new Button();
            closeButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // productCostButton
            // 
            productCostButton.Location = new Point(74, 38);
            productCostButton.Name = "productCostButton";
            productCostButton.Size = new Size(180, 23);
            productCostButton.TabIndex = 0;
            productCostButton.Text = "Вартість придбаного товару";
            productCostButton.UseVisualStyleBackColor = true;
            productCostButton.Click += productCostButtonClick;
            // 
            // oddNumbersSumButton
            // 
            oddNumbersSumButton.Location = new Point(74, 67);
            oddNumbersSumButton.Name = "oddNumbersSumButton";
            oddNumbersSumButton.Size = new Size(180, 23);
            oddNumbersSumButton.TabIndex = 1;
            oddNumbersSumButton.Text = "Сума непарних чисел";
            oddNumbersSumButton.UseVisualStyleBackColor = true;
            oddNumbersSumButton.Click += oddNumbersSumButtonClick;
            // 
            // numberCubesButton
            // 
            numberCubesButton.Location = new Point(74, 96);
            numberCubesButton.Name = "numberCubesButton";
            numberCubesButton.Size = new Size(180, 23);
            numberCubesButton.TabIndex = 2;
            numberCubesButton.Text = "Куби чисел";
            numberCubesButton.UseVisualStyleBackColor = true;
            numberCubesButton.Click += numberCubesButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(74, 141);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(180, 23);
            closeButton.TabIndex = 3;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 4;
            label1.Text = "Оберіть завдання";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 197);
            Controls.Add(label1);
            Controls.Add(closeButton);
            Controls.Add(numberCubesButton);
            Controls.Add(oddNumbersSumButton);
            Controls.Add(productCostButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Практична робота № 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button productCostButton;
        private Button oddNumbersSumButton;
        private Button numberCubesButton;
        private Button closeButton;
        private Label label1;
    }
}
