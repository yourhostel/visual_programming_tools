namespace _2026_09_20_user_interface
{
    partial class ProductCostForm
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
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            unitPriceCaptionLabel = new Label();
            unitPriceLabel = new Label();
            label4 = new Label();
            totalCostLabel = new Label();
            calculateButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(66, 22);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(99, 15);
            quantityLabel.TabIndex = 0;
            quantityLabel.Text = "Кількість товару:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(183, 14);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(100, 23);
            quantityTextBox.TabIndex = 1;
            quantityTextBox.TextChanged += quantityTextBoxTextChanged;
            // 
            // unitPriceCaptionLabel
            // 
            unitPriceCaptionLabel.AutoSize = true;
            unitPriceCaptionLabel.Location = new Point(66, 59);
            unitPriceCaptionLabel.Name = "unitPriceCaptionLabel";
            unitPriceCaptionLabel.Size = new Size(103, 15);
            unitPriceCaptionLabel.TabIndex = 2;
            unitPriceCaptionLabel.Text = "Ціна за одиницю:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new Point(183, 59);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(41, 15);
            unitPriceLabel.TabIndex = 3;
            unitPriceLabel.Text = "50 грн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 96);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 4;
            label4.Text = "Загальна вартість:";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(183, 96);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(12, 15);
            totalCostLabel.TabIndex = 5;
            totalCostLabel.Text = "_";
            // 
            // calculateButton
            // 
            calculateButton.Enabled = false;
            calculateButton.Location = new Point(255, 92);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(79, 23);
            calculateButton.TabIndex = 6;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButtonClick;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(153, 137);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(79, 23);
            closeButton.TabIndex = 7;
            closeButton.Text = "Закрити";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButtonClick;
            // 
            // ProductCostForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 170);
            Controls.Add(closeButton);
            Controls.Add(calculateButton);
            Controls.Add(totalCostLabel);
            Controls.Add(label4);
            Controls.Add(unitPriceLabel);
            Controls.Add(unitPriceCaptionLabel);
            Controls.Add(quantityTextBox);
            Controls.Add(quantityLabel);
            Name = "ProductCostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вартість придбаного товару";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label quantityLabel;
        private TextBox quantityTextBox;
        private Label unitPriceCaptionLabel;
        private Label unitPriceLabel;
        private Label label4;
        private Label totalCostLabel;
        private Button calculateButton;
        private Button closeButton;
    }
}