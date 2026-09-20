namespace _2026_09_20_visual_development
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            pointRegionButton = new Button();
            calculatorButton = new Button();
            minimumButton = new Button();
            sumButton = new Button();
            closeButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pointRegionButton);
            groupBox1.Controls.Add(calculatorButton);
            groupBox1.Controls.Add(minimumButton);
            groupBox1.Controls.Add(sumButton);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Завдання:";
            // 
            // pointRegionButton
            // 
            pointRegionButton.Location = new Point(31, 163);
            pointRegionButton.Name = "pointRegionButton";
            pointRegionButton.Size = new Size(271, 23);
            pointRegionButton.TabIndex = 3;
            pointRegionButton.Text = "Належність точки області";
            pointRegionButton.UseVisualStyleBackColor = true;
            pointRegionButton.Click += pointRegionButtonClick;
            // 
            // calculatorButton
            // 
            calculatorButton.Location = new Point(31, 122);
            calculatorButton.Name = "calculatorButton";
            calculatorButton.Size = new Size(271, 23);
            calculatorButton.TabIndex = 2;
            calculatorButton.Text = "Арифметичні операції";
            calculatorButton.UseVisualStyleBackColor = true;
            calculatorButton.Click += calculatorButtonClick;
            // 
            // minimumButton
            // 
            minimumButton.Location = new Point(31, 82);
            minimumButton.Name = "minimumButton";
            minimumButton.Size = new Size(271, 23);
            minimumButton.TabIndex = 1;
            minimumButton.Text = "Мінімум із трьох чисел";
            minimumButton.UseVisualStyleBackColor = true;
            minimumButton.Click += minimumButtonClick;
            // 
            // sumButton
            // 
            sumButton.Location = new Point(31, 38);
            sumButton.Name = "sumButton";
            sumButton.Size = new Size(271, 23);
            sumButton.TabIndex = 0;
            sumButton.Text = "Сума двох чисел";
            sumButton.UseVisualStyleBackColor = true;
            sumButton.Click += sumButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(147, 243);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 282);
            Controls.Add(closeButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Практична робота № 2";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button pointRegionButton;
        private Button calculatorButton;
        private Button minimumButton;
        private Button sumButton;
        private Button closeButton;
    }
}