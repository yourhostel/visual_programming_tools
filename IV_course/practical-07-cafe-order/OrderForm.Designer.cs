namespace CafeOrder;

partial class OrderForm
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
        panelDrinks = new Panel();
        labelDrinksTotal = new Label();
        buttonDrinksNext = new Button();
        pictureDrink = new PictureBox();
        groupDrinks = new GroupBox();
        radioCoffee = new RadioButton();
        radioJuice = new RadioButton();
        radioTea = new RadioButton();
        radioNoDrink = new RadioButton();
        panelSoups = new Panel();
        labelSoupsTotal = new Label();
        buttonSoupsNext = new Button();
        buttonSoupsBack = new Button();
        pictureSoup = new PictureBox();
        groupSoups = new GroupBox();
        radioSolyanka = new RadioButton();
        radioBorscht = new RadioButton();
        radioChickenSoup = new RadioButton();
        radioNoSoup = new RadioButton();
        panelMainDishes = new Panel();
        labelMainTotal = new Label();
        buttonMainNext = new Button();
        buttonMainBack = new Button();
        pictureMainDish = new PictureBox();
        groupIngredients = new GroupBox();
        checkIngredient3 = new CheckBox();
        checkIngredient2 = new CheckBox();
        checkIngredient1 = new CheckBox();
        groupMainDishes = new GroupBox();
        radioBurger = new RadioButton();
        radioSpaghetti = new RadioButton();
        radioPizza = new RadioButton();
        radioNoMainDish = new RadioButton();
        panelSummary = new Panel();
        buttonNewOrder = new Button();
        buttonSummaryBack = new Button();
        labelTotal = new Label();
        labelTotalCaption = new Label();
        groupDiscount = new GroupBox();
        radioStudent = new RadioButton();
        radioNoDiscount = new RadioButton();
        groupOrderSummary = new GroupBox();
        listOrderItems = new ListBox();
        colorDialog1 = new ColorDialog();
        panelDrinks.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureDrink).BeginInit();
        groupDrinks.SuspendLayout();
        panelSoups.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureSoup).BeginInit();
        groupSoups.SuspendLayout();
        panelMainDishes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureMainDish).BeginInit();
        groupIngredients.SuspendLayout();
        groupMainDishes.SuspendLayout();
        panelSummary.SuspendLayout();
        groupDiscount.SuspendLayout();
        groupOrderSummary.SuspendLayout();
        SuspendLayout();
        // 
        // panelDrinks
        // 
        panelDrinks.BorderStyle = BorderStyle.FixedSingle;
        panelDrinks.Controls.Add(labelDrinksTotal);
        panelDrinks.Controls.Add(buttonDrinksNext);
        panelDrinks.Controls.Add(pictureDrink);
        panelDrinks.Controls.Add(groupDrinks);
        panelDrinks.Dock = DockStyle.Fill;
        panelDrinks.Location = new Point(0, 0);
        panelDrinks.Name = "panelDrinks";
        panelDrinks.Size = new Size(800, 488);
        panelDrinks.TabIndex = 0;
        // 
        // labelDrinksTotal
        // 
        labelDrinksTotal.Font = new Font("Segoe UI", 11F);
        labelDrinksTotal.Location = new Point(30, 450);
        labelDrinksTotal.Name = "labelDrinksTotal";
        labelDrinksTotal.Size = new Size(300, 30);
        labelDrinksTotal.TabIndex = 3;
        labelDrinksTotal.Text = "Поточна сума: 0,00 грн";
        // 
        // buttonDrinksNext
        // 
        buttonDrinksNext.Location = new Point(330, 400);
        buttonDrinksNext.Name = "buttonDrinksNext";
        buttonDrinksNext.Size = new Size(120, 40);
        buttonDrinksNext.TabIndex = 2;
        buttonDrinksNext.Text = "Далі";
        buttonDrinksNext.UseVisualStyleBackColor = true;
        // 
        // pictureDrink
        // 
        pictureDrink.BackColor = Color.WhiteSmoke;
        pictureDrink.Location = new Point(420, 70);
        pictureDrink.Name = "pictureDrink";
        pictureDrink.Size = new Size(330, 270);
        pictureDrink.SizeMode = PictureBoxSizeMode.Zoom;
        pictureDrink.TabIndex = 1;
        pictureDrink.TabStop = false;
        // 
        // groupDrinks
        // 
        groupDrinks.Controls.Add(radioCoffee);
        groupDrinks.Controls.Add(radioJuice);
        groupDrinks.Controls.Add(radioTea);
        groupDrinks.Controls.Add(radioNoDrink);
        groupDrinks.Location = new Point(30, 70);
        groupDrinks.Name = "groupDrinks";
        groupDrinks.Size = new Size(330, 270);
        groupDrinks.TabIndex = 0;
        groupDrinks.TabStop = false;
        groupDrinks.Text = "Напої";
        // 
        // radioCoffee
        // 
        radioCoffee.AutoSize = true;
        radioCoffee.Location = new Point(20, 185);
        radioCoffee.Name = "radioCoffee";
        radioCoffee.Size = new Size(56, 23);
        radioCoffee.TabIndex = 3;
        radioCoffee.Text = "Кава";
        radioCoffee.UseVisualStyleBackColor = true;
        // 
        // radioJuice
        // 
        radioJuice.AutoSize = true;
        radioJuice.Location = new Point(20, 135);
        radioJuice.Name = "radioJuice";
        radioJuice.Size = new Size(138, 23);
        radioJuice.TabIndex = 2;
        radioJuice.Text = "Апельсиновий сік";
        radioJuice.UseVisualStyleBackColor = true;
        // 
        // radioTea
        // 
        radioTea.AutoSize = true;
        radioTea.Location = new Point(20, 85);
        radioTea.Name = "radioTea";
        radioTea.Size = new Size(51, 23);
        radioTea.TabIndex = 1;
        radioTea.Text = "Чай";
        radioTea.UseVisualStyleBackColor = true;
        // 
        // radioNoDrink
        // 
        radioNoDrink.AutoSize = true;
        radioNoDrink.Checked = true;
        radioNoDrink.Location = new Point(20, 35);
        radioNoDrink.Name = "radioNoDrink";
        radioNoDrink.Size = new Size(114, 23);
        radioNoDrink.TabIndex = 0;
        radioNoDrink.TabStop = true;
        radioNoDrink.Text = "Не замовляти";
        radioNoDrink.UseVisualStyleBackColor = true;
        // 
        // panelSoups
        // 
        panelSoups.Controls.Add(labelSoupsTotal);
        panelSoups.Controls.Add(buttonSoupsNext);
        panelSoups.Controls.Add(buttonSoupsBack);
        panelSoups.Controls.Add(pictureSoup);
        panelSoups.Controls.Add(groupSoups);
        panelSoups.Dock = DockStyle.Fill;
        panelSoups.Location = new Point(0, 0);
        panelSoups.Name = "panelSoups";
        panelSoups.Size = new Size(800, 488);
        panelSoups.TabIndex = 0;
        // 
        // labelSoupsTotal
        // 
        labelSoupsTotal.Font = new Font("Segoe UI", 11F);
        labelSoupsTotal.Location = new Point(30, 450);
        labelSoupsTotal.Name = "labelSoupsTotal";
        labelSoupsTotal.Size = new Size(300, 30);
        labelSoupsTotal.TabIndex = 4;
        labelSoupsTotal.Text = "Поточна сума: 0,00 грн";
        // 
        // buttonSoupsNext
        // 
        buttonSoupsNext.Location = new Point(420, 400);
        buttonSoupsNext.Name = "buttonSoupsNext";
        buttonSoupsNext.Size = new Size(120, 40);
        buttonSoupsNext.TabIndex = 3;
        buttonSoupsNext.Text = "Далі";
        buttonSoupsNext.UseVisualStyleBackColor = true;
        // 
        // buttonSoupsBack
        // 
        buttonSoupsBack.Location = new Point(260, 400);
        buttonSoupsBack.Name = "buttonSoupsBack";
        buttonSoupsBack.Size = new Size(120, 40);
        buttonSoupsBack.TabIndex = 2;
        buttonSoupsBack.Text = "Назад";
        buttonSoupsBack.UseVisualStyleBackColor = true;
        // 
        // pictureSoup
        // 
        pictureSoup.Location = new Point(420, 70);
        pictureSoup.Name = "pictureSoup";
        pictureSoup.Size = new Size(330, 260);
        pictureSoup.SizeMode = PictureBoxSizeMode.Zoom;
        pictureSoup.TabIndex = 1;
        pictureSoup.TabStop = false;
        // 
        // groupSoups
        // 
        groupSoups.Controls.Add(radioSolyanka);
        groupSoups.Controls.Add(radioBorscht);
        groupSoups.Controls.Add(radioChickenSoup);
        groupSoups.Controls.Add(radioNoSoup);
        groupSoups.Location = new Point(30, 75);
        groupSoups.Name = "groupSoups";
        groupSoups.Size = new Size(330, 260);
        groupSoups.TabIndex = 0;
        groupSoups.TabStop = false;
        groupSoups.Text = "Перші страви";
        // 
        // radioSolyanka
        // 
        radioSolyanka.AutoSize = true;
        radioSolyanka.Location = new Point(20, 185);
        radioSolyanka.Name = "radioSolyanka";
        radioSolyanka.Size = new Size(80, 23);
        radioSolyanka.TabIndex = 3;
        radioSolyanka.Text = "Солянка";
        radioSolyanka.UseVisualStyleBackColor = true;
        // 
        // radioBorscht
        // 
        radioBorscht.AutoSize = true;
        radioBorscht.Location = new Point(20, 135);
        radioBorscht.Name = "radioBorscht";
        radioBorscht.Size = new Size(144, 23);
        radioBorscht.TabIndex = 2;
        radioBorscht.Text = "Український борщ";
        radioBorscht.UseVisualStyleBackColor = true;
        // 
        // radioChickenSoup
        // 
        radioChickenSoup.AutoSize = true;
        radioChickenSoup.Location = new Point(20, 85);
        radioChickenSoup.Name = "radioChickenSoup";
        radioChickenSoup.Size = new Size(110, 23);
        radioChickenSoup.TabIndex = 1;
        radioChickenSoup.Text = "Курячий суп ";
        radioChickenSoup.UseVisualStyleBackColor = true;
        // 
        // radioNoSoup
        // 
        radioNoSoup.AutoSize = true;
        radioNoSoup.Checked = true;
        radioNoSoup.Location = new Point(20, 35);
        radioNoSoup.Name = "radioNoSoup";
        radioNoSoup.Size = new Size(114, 23);
        radioNoSoup.TabIndex = 0;
        radioNoSoup.TabStop = true;
        radioNoSoup.Text = "Не замовляти";
        radioNoSoup.UseVisualStyleBackColor = true;
        // 
        // panelMainDishes
        // 
        panelMainDishes.Controls.Add(labelMainTotal);
        panelMainDishes.Controls.Add(buttonMainNext);
        panelMainDishes.Controls.Add(buttonMainBack);
        panelMainDishes.Controls.Add(pictureMainDish);
        panelMainDishes.Controls.Add(groupIngredients);
        panelMainDishes.Controls.Add(groupMainDishes);
        panelMainDishes.Dock = DockStyle.Fill;
        panelMainDishes.Location = new Point(0, 0);
        panelMainDishes.Name = "panelMainDishes";
        panelMainDishes.Size = new Size(800, 488);
        panelMainDishes.TabIndex = 0;
        // 
        // labelMainTotal
        // 
        labelMainTotal.Font = new Font("Segoe UI", 11F);
        labelMainTotal.Location = new Point(30, 450);
        labelMainTotal.Name = "labelMainTotal";
        labelMainTotal.Size = new Size(300, 30);
        labelMainTotal.TabIndex = 5;
        labelMainTotal.Text = "Поточна сума: 0,00 грн";
        // 
        // buttonMainNext
        // 
        buttonMainNext.Location = new Point(420, 410);
        buttonMainNext.Name = "buttonMainNext";
        buttonMainNext.Size = new Size(120, 40);
        buttonMainNext.TabIndex = 4;
        buttonMainNext.Text = "Далі";
        buttonMainNext.UseVisualStyleBackColor = true;
        // 
        // buttonMainBack
        // 
        buttonMainBack.Location = new Point(260, 410);
        buttonMainBack.Name = "buttonMainBack";
        buttonMainBack.Size = new Size(120, 40);
        buttonMainBack.TabIndex = 3;
        buttonMainBack.Text = "Назад";
        buttonMainBack.UseVisualStyleBackColor = true;
        // 
        // pictureMainDish
        // 
        pictureMainDish.Location = new Point(420, 45);
        pictureMainDish.Name = "pictureMainDish";
        pictureMainDish.Size = new Size(330, 270);
        pictureMainDish.SizeMode = PictureBoxSizeMode.Zoom;
        pictureMainDish.TabIndex = 2;
        pictureMainDish.TabStop = false;
        // 
        // groupIngredients
        // 
        groupIngredients.Controls.Add(checkIngredient3);
        groupIngredients.Controls.Add(checkIngredient2);
        groupIngredients.Controls.Add(checkIngredient1);
        groupIngredients.Enabled = false;
        groupIngredients.Location = new Point(30, 275);
        groupIngredients.Name = "groupIngredients";
        groupIngredients.Size = new Size(330, 120);
        groupIngredients.TabIndex = 1;
        groupIngredients.TabStop = false;
        groupIngredients.Text = "Додаткові інгредієнти";
        // 
        // checkIngredient3
        // 
        checkIngredient3.AutoSize = true;
        checkIngredient3.Location = new Point(20, 85);
        checkIngredient3.Name = "checkIngredient3";
        checkIngredient3.Size = new Size(103, 23);
        checkIngredient3.TabIndex = 2;
        checkIngredient3.Text = "Інгредієнт 3";
        checkIngredient3.UseVisualStyleBackColor = true;
        // 
        // checkIngredient2
        // 
        checkIngredient2.AutoSize = true;
        checkIngredient2.Location = new Point(20, 55);
        checkIngredient2.Name = "checkIngredient2";
        checkIngredient2.Size = new Size(103, 23);
        checkIngredient2.TabIndex = 1;
        checkIngredient2.Text = "Інгредієнт 2";
        checkIngredient2.UseVisualStyleBackColor = true;
        // 
        // checkIngredient1
        // 
        checkIngredient1.AutoSize = true;
        checkIngredient1.Location = new Point(20, 25);
        checkIngredient1.Name = "checkIngredient1";
        checkIngredient1.Size = new Size(103, 23);
        checkIngredient1.TabIndex = 0;
        checkIngredient1.Text = "Інгредієнт 1";
        checkIngredient1.UseVisualStyleBackColor = true;
        // 
        // groupMainDishes
        // 
        groupMainDishes.Controls.Add(radioBurger);
        groupMainDishes.Controls.Add(radioSpaghetti);
        groupMainDishes.Controls.Add(radioPizza);
        groupMainDishes.Controls.Add(radioNoMainDish);
        groupMainDishes.Location = new Point(30, 45);
        groupMainDishes.Name = "groupMainDishes";
        groupMainDishes.Size = new Size(330, 220);
        groupMainDishes.TabIndex = 0;
        groupMainDishes.TabStop = false;
        groupMainDishes.Text = "Другі страви";
        // 
        // radioBurger
        // 
        radioBurger.AutoSize = true;
        radioBurger.Location = new Point(20, 165);
        radioBurger.Name = "radioBurger";
        radioBurger.Size = new Size(70, 23);
        radioBurger.TabIndex = 3;
        radioBurger.Text = "Бургер";
        radioBurger.UseVisualStyleBackColor = true;
        // 
        // radioSpaghetti
        // 
        radioSpaghetti.AutoSize = true;
        radioSpaghetti.Location = new Point(20, 120);
        radioSpaghetti.Name = "radioSpaghetti";
        radioSpaghetti.Size = new Size(72, 23);
        radioSpaghetti.TabIndex = 2;
        radioSpaghetti.Text = "Спагеті";
        radioSpaghetti.UseVisualStyleBackColor = true;
        // 
        // radioPizza
        // 
        radioPizza.AutoSize = true;
        radioPizza.Location = new Point(20, 75);
        radioPizza.Name = "radioPizza";
        radioPizza.Size = new Size(55, 23);
        radioPizza.TabIndex = 1;
        radioPizza.Text = "Піца";
        radioPizza.UseVisualStyleBackColor = true;
        // 
        // radioNoMainDish
        // 
        radioNoMainDish.AutoSize = true;
        radioNoMainDish.Checked = true;
        radioNoMainDish.Location = new Point(20, 30);
        radioNoMainDish.Name = "radioNoMainDish";
        radioNoMainDish.Size = new Size(114, 23);
        radioNoMainDish.TabIndex = 0;
        radioNoMainDish.TabStop = true;
        radioNoMainDish.Text = "Не замовляти";
        radioNoMainDish.UseVisualStyleBackColor = true;
        // 
        // panelSummary
        // 
        panelSummary.Controls.Add(buttonNewOrder);
        panelSummary.Controls.Add(buttonSummaryBack);
        panelSummary.Controls.Add(labelTotal);
        panelSummary.Controls.Add(labelTotalCaption);
        panelSummary.Controls.Add(groupDiscount);
        panelSummary.Controls.Add(groupOrderSummary);
        panelSummary.Dock = DockStyle.Fill;
        panelSummary.Location = new Point(0, 0);
        panelSummary.Name = "panelSummary";
        panelSummary.Size = new Size(800, 488);
        panelSummary.TabIndex = 0;
        // 
        // buttonNewOrder
        // 
        buttonNewOrder.Location = new Point(420, 410);
        buttonNewOrder.Name = "buttonNewOrder";
        buttonNewOrder.Size = new Size(170, 40);
        buttonNewOrder.TabIndex = 5;
        buttonNewOrder.Text = "Нове замовлення";
        buttonNewOrder.UseVisualStyleBackColor = true;
        // 
        // buttonSummaryBack
        // 
        buttonSummaryBack.Location = new Point(260, 410);
        buttonSummaryBack.Name = "buttonSummaryBack";
        buttonSummaryBack.Size = new Size(120, 40);
        buttonSummaryBack.TabIndex = 4;
        buttonSummaryBack.Text = "Назад";
        buttonSummaryBack.UseVisualStyleBackColor = true;
        // 
        // labelTotal
        // 
        labelTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelTotal.Location = new Point(490, 285);
        labelTotal.Name = "labelTotal";
        labelTotal.Size = new Size(260, 45);
        labelTotal.TabIndex = 3;
        labelTotal.Text = "0,00 грн";
        // 
        // labelTotalCaption
        // 
        labelTotalCaption.Font = new Font("Segoe UI", 11F);
        labelTotalCaption.Location = new Point(490, 250);
        labelTotalCaption.Name = "labelTotalCaption";
        labelTotalCaption.Size = new Size(250, 25);
        labelTotalCaption.TabIndex = 2;
        labelTotalCaption.Text = "До сплати:";
        // 
        // groupDiscount
        // 
        groupDiscount.Controls.Add(radioStudent);
        groupDiscount.Controls.Add(radioNoDiscount);
        groupDiscount.Location = new Point(490, 50);
        groupDiscount.Name = "groupDiscount";
        groupDiscount.Size = new Size(280, 130);
        groupDiscount.TabIndex = 1;
        groupDiscount.TabStop = false;
        groupDiscount.Text = "Знижка";
        // 
        // radioStudent
        // 
        radioStudent.AutoSize = true;
        radioStudent.Location = new Point(20, 80);
        radioStudent.Name = "radioStudent";
        radioStudent.Size = new Size(136, 23);
        radioStudent.TabIndex = 1;
        radioStudent.Text = "Студентська 10%";
        radioStudent.UseVisualStyleBackColor = true;
        // 
        // radioNoDiscount
        // 
        radioNoDiscount.AutoSize = true;
        radioNoDiscount.Checked = true;
        radioNoDiscount.Location = new Point(20, 35);
        radioNoDiscount.Name = "radioNoDiscount";
        radioNoDiscount.Size = new Size(99, 23);
        radioNoDiscount.TabIndex = 0;
        radioNoDiscount.TabStop = true;
        radioNoDiscount.Text = "Без знижки";
        radioNoDiscount.UseVisualStyleBackColor = true;
        // 
        // groupOrderSummary
        // 
        groupOrderSummary.Controls.Add(listOrderItems);
        groupOrderSummary.Location = new Point(30, 50);
        groupOrderSummary.Name = "groupOrderSummary";
        groupOrderSummary.Size = new Size(440, 320);
        groupOrderSummary.TabIndex = 0;
        groupOrderSummary.TabStop = false;
        groupOrderSummary.Text = "Склад замовлення";
        // 
        // listOrderItems
        // 
        listOrderItems.FormattingEnabled = true;
        listOrderItems.ItemHeight = 17;
        listOrderItems.Location = new Point(15, 30);
        listOrderItems.Name = "listOrderItems";
        listOrderItems.SelectionMode = SelectionMode.None;
        listOrderItems.Size = new Size(410, 259);
        listOrderItems.TabIndex = 0;
        // 
        // OrderForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(800, 488);
        Controls.Add(panelMainDishes);
        Controls.Add(panelDrinks);
        Controls.Add(panelSoups);
        Controls.Add(panelSummary);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "OrderForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Практична №7. Замовлення в кафе";
        panelDrinks.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureDrink).EndInit();
        groupDrinks.ResumeLayout(false);
        groupDrinks.PerformLayout();
        panelSoups.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureSoup).EndInit();
        groupSoups.ResumeLayout(false);
        groupSoups.PerformLayout();
        panelMainDishes.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureMainDish).EndInit();
        groupIngredients.ResumeLayout(false);
        groupIngredients.PerformLayout();
        groupMainDishes.ResumeLayout(false);
        groupMainDishes.PerformLayout();
        panelSummary.ResumeLayout(false);
        groupDiscount.ResumeLayout(false);
        groupDiscount.PerformLayout();
        groupOrderSummary.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panelDrinks;
    private Panel panelSoups;
    private Panel panelMainDishes;
    private Panel panelSummary;
    private GroupBox groupDrinks;
    private RadioButton radioCoffee;
    private RadioButton radioJuice;
    private RadioButton radioTea;
    private RadioButton radioNoDrink;
    private PictureBox pictureDrink;
    private Button buttonDrinksNext;
    private GroupBox groupSoups;
    private RadioButton radioNoSoup;
    private RadioButton radioSolyanka;
    private RadioButton radioBorscht;
    private RadioButton radioChickenSoup;
    private PictureBox pictureSoup;
    private Button buttonSoupsNext;
    private Button buttonSoupsBack;
    private ColorDialog colorDialog1;
    private GroupBox groupMainDishes;
    private RadioButton radioBurger;
    private RadioButton radioSpaghetti;
    private RadioButton radioPizza;
    private RadioButton radioNoMainDish;
    private GroupBox groupIngredients;
    private CheckBox checkIngredient3;
    private CheckBox checkIngredient2;
    private CheckBox checkIngredient1;
    private Button buttonMainNext;
    private Button buttonMainBack;
    private PictureBox pictureMainDish;
    private GroupBox groupDiscount;
    private GroupBox groupOrderSummary;
    private ListBox listOrderItems;
    private Label labelTotal;
    private Label labelTotalCaption;
    private RadioButton radioStudent;
    private RadioButton radioNoDiscount;
    private Button buttonNewOrder;
    private Button buttonSummaryBack;
    private Label labelDrinksTotal;
    private Label labelSoupsTotal;
    private Label labelMainTotal;
}
