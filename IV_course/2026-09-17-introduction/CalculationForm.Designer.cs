namespace _2026_09_17_introduction
{
    partial class CalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            xTextBox = new TextBox();
            yTextBox = new TextBox();
            zTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            calculateButton = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 194);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "x =";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 239);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 1;
            label2.Text = "y =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 284);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 2;
            label3.Text = "z =";
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(118, 186);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(281, 23);
            xTextBox.TabIndex = 3;
            xTextBox.Text = "14.26";
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(118, 231);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(281, 23);
            yTextBox.TabIndex = 4;
            yTextBox.Text = "-1.22";
            // 
            // zTextBox
            // 
            zTextBox.Location = new Point(118, 276);
            zTextBox.Name = "zTextBox";
            zTextBox.Size = new Size(281, 23);
            zTextBox.TabIndex = 5;
            zTextBox.Text = "0.035";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(118, 339);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(80, 23);
            calculateButton.TabIndex = 7;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(324, 339);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 8;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // CalculationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 478);
            Controls.Add(closeButton);
            Controls.Add(calculateButton);
            Controls.Add(pictureBox1);
            Controls.Add(zTextBox);
            Controls.Add(yTextBox);
            Controls.Add(xTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalculationForm";
            Text = "CalculationForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox xTextBox;
        private TextBox yTextBox;
        private TextBox zTextBox;
        private PictureBox pictureBox1;
        private Button calculateButton;
        private Button closeButton;
    }
}