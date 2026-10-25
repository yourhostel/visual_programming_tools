namespace DatabaseOperations;

partial class DatabaseOperationsForm
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
        tabControlMain = new TabControl();
        tabPageProducts = new TabPage();
        panelProducts = new Panel();
        dataGridViewProducts = new DataGridView();
        panelEditor = new Panel();
        buttonDelete = new Button();
        buttonUpdate = new Button();
        buttonAdd = new Button();
        labelWeight = new Label();
        labelPrice = new Label();
        labelQuantity = new Label();
        labelCategory = new Label();
        Назва = new Label();
        numericWeight = new NumericUpDown();
        numericPrice = new NumericUpDown();
        numericQuantity = new NumericUpDown();
        textBoxCategory = new TextBox();
        textBoxName = new TextBox();
        panelFilters = new Panel();
        comboBoxQueryType = new ComboBox();
        textBoxSearch = new TextBox();
        labelQueryType = new Label();
        labelSearch = new Label();
        buttonSearch = new Button();
        buttonRefresh = new Button();
        tabPageCharts = new TabPage();
        formsPlot = new ScottPlot.WinForms.FormsPlot();
        panelChartControls = new Panel();
        buttonRefreshChart = new Button();
        buttonBuildChart = new Button();
        comboBoxChartType = new ComboBox();
        labelChartType = new Label();
        tabControlMain.SuspendLayout();
        tabPageProducts.SuspendLayout();
        panelProducts.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
        panelEditor.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericWeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
        panelFilters.SuspendLayout();
        tabPageCharts.SuspendLayout();
        panelChartControls.SuspendLayout();
        SuspendLayout();
        // 
        // tabControlMain
        // 
        tabControlMain.Controls.Add(tabPageProducts);
        tabControlMain.Controls.Add(tabPageCharts);
        tabControlMain.Dock = DockStyle.Fill;
        tabControlMain.Location = new Point(0, 0);
        tabControlMain.Name = "tabControlMain";
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new Size(1084, 661);
        tabControlMain.TabIndex = 0;
        // 
        // tabPageProducts
        // 
        tabPageProducts.Controls.Add(panelProducts);
        tabPageProducts.Controls.Add(panelEditor);
        tabPageProducts.Controls.Add(panelFilters);
        tabPageProducts.Location = new Point(4, 24);
        tabPageProducts.Name = "tabPageProducts";
        tabPageProducts.Padding = new Padding(3);
        tabPageProducts.Size = new Size(1076, 633);
        tabPageProducts.TabIndex = 0;
        tabPageProducts.Text = "Товари";
        tabPageProducts.UseVisualStyleBackColor = true;
        // 
        // panelProducts
        // 
        panelProducts.Controls.Add(dataGridViewProducts);
        panelProducts.Dock = DockStyle.Fill;
        panelProducts.Location = new Point(3, 68);
        panelProducts.Name = "panelProducts";
        panelProducts.Size = new Size(1070, 412);
        panelProducts.TabIndex = 2;
        // 
        // dataGridViewProducts
        // 
        dataGridViewProducts.AllowUserToAddRows = false;
        dataGridViewProducts.AllowUserToDeleteRows = false;
        dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewProducts.Dock = DockStyle.Fill;
        dataGridViewProducts.Location = new Point(0, 0);
        dataGridViewProducts.MultiSelect = false;
        dataGridViewProducts.Name = "dataGridViewProducts";
        dataGridViewProducts.ReadOnly = true;
        dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridViewProducts.Size = new Size(1070, 412);
        dataGridViewProducts.TabIndex = 0;
        // 
        // panelEditor
        // 
        panelEditor.Controls.Add(buttonDelete);
        panelEditor.Controls.Add(buttonUpdate);
        panelEditor.Controls.Add(buttonAdd);
        panelEditor.Controls.Add(labelWeight);
        panelEditor.Controls.Add(labelPrice);
        panelEditor.Controls.Add(labelQuantity);
        panelEditor.Controls.Add(labelCategory);
        panelEditor.Controls.Add(Назва);
        panelEditor.Controls.Add(numericWeight);
        panelEditor.Controls.Add(numericPrice);
        panelEditor.Controls.Add(numericQuantity);
        panelEditor.Controls.Add(textBoxCategory);
        panelEditor.Controls.Add(textBoxName);
        panelEditor.Dock = DockStyle.Bottom;
        panelEditor.Location = new Point(3, 480);
        panelEditor.Name = "panelEditor";
        panelEditor.Size = new Size(1070, 150);
        panelEditor.TabIndex = 1;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new Point(335, 90);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(130, 32);
        buttonDelete.TabIndex = 12;
        buttonDelete.Text = "Видалити";
        buttonDelete.UseVisualStyleBackColor = true;
        // 
        // buttonUpdate
        // 
        buttonUpdate.Location = new Point(160, 90);
        buttonUpdate.Name = "buttonUpdate";
        buttonUpdate.Size = new Size(160, 32);
        buttonUpdate.TabIndex = 11;
        buttonUpdate.Text = "Зберегти зміни";
        buttonUpdate.UseVisualStyleBackColor = true;
        // 
        // buttonAdd
        // 
        buttonAdd.Location = new Point(15, 90);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(130, 32);
        buttonAdd.TabIndex = 10;
        buttonAdd.Text = "Додати";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // labelWeight
        // 
        labelWeight.Location = new Point(685, 15);
        labelWeight.Name = "labelWeight";
        labelWeight.Size = new Size(100, 20);
        labelWeight.TabIndex = 9;
        labelWeight.Text = "Вага";
        // 
        // labelPrice
        // 
        labelPrice.Location = new Point(550, 15);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(100, 20);
        labelPrice.TabIndex = 8;
        labelPrice.Text = "Ціна";
        // 
        // labelQuantity
        // 
        labelQuantity.Location = new Point(425, 15);
        labelQuantity.Name = "labelQuantity";
        labelQuantity.Size = new Size(100, 20);
        labelQuantity.TabIndex = 7;
        labelQuantity.Text = "Кількість";
        // 
        // labelCategory
        // 
        labelCategory.Location = new Point(230, 15);
        labelCategory.Name = "labelCategory";
        labelCategory.Size = new Size(160, 20);
        labelCategory.TabIndex = 6;
        labelCategory.Text = "Категорія";
        // 
        // Назва
        // 
        Назва.Location = new Point(15, 15);
        Назва.Name = "Назва";
        Назва.Size = new Size(160, 20);
        Назва.TabIndex = 5;
        Назва.Text = "Назва";
        // 
        // numericWeight
        // 
        numericWeight.DecimalPlaces = 3;
        numericWeight.Increment = new decimal(new int[] { 100, 0, 0, 196608 });
        numericWeight.Location = new Point(685, 40);
        numericWeight.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericWeight.Name = "numericWeight";
        numericWeight.Size = new Size(120, 23);
        numericWeight.TabIndex = 4;
        // 
        // numericPrice
        // 
        numericPrice.DecimalPlaces = 2;
        numericPrice.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
        numericPrice.Location = new Point(550, 40);
        numericPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
        numericPrice.Name = "numericPrice";
        numericPrice.Size = new Size(120, 23);
        numericPrice.TabIndex = 3;
        // 
        // numericQuantity
        // 
        numericQuantity.Location = new Point(425, 40);
        numericQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        numericQuantity.Name = "numericQuantity";
        numericQuantity.Size = new Size(110, 23);
        numericQuantity.TabIndex = 2;
        // 
        // textBoxCategory
        // 
        textBoxCategory.Location = new Point(230, 40);
        textBoxCategory.Name = "textBoxCategory";
        textBoxCategory.Size = new Size(180, 23);
        textBoxCategory.TabIndex = 1;
        // 
        // textBoxName
        // 
        textBoxName.Location = new Point(15, 40);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(200, 23);
        textBoxName.TabIndex = 0;
        // 
        // panelFilters
        // 
        panelFilters.Controls.Add(comboBoxQueryType);
        panelFilters.Controls.Add(textBoxSearch);
        panelFilters.Controls.Add(labelQueryType);
        panelFilters.Controls.Add(labelSearch);
        panelFilters.Controls.Add(buttonSearch);
        panelFilters.Controls.Add(buttonRefresh);
        panelFilters.Dock = DockStyle.Top;
        panelFilters.Location = new Point(3, 3);
        panelFilters.Name = "panelFilters";
        panelFilters.Size = new Size(1070, 65);
        panelFilters.TabIndex = 0;
        // 
        // comboBoxQueryType
        // 
        comboBoxQueryType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxQueryType.FormattingEnabled = true;
        comboBoxQueryType.Location = new Point(260, 28);
        comboBoxQueryType.Name = "comboBoxQueryType";
        comboBoxQueryType.Size = new Size(210, 23);
        comboBoxQueryType.TabIndex = 5;
        // 
        // textBoxSearch
        // 
        textBoxSearch.Location = new Point(15, 28);
        textBoxSearch.Name = "textBoxSearch";
        textBoxSearch.PlaceholderText = "Назва або категорія";
        textBoxSearch.Size = new Size(230, 23);
        textBoxSearch.TabIndex = 4;
        // 
        // labelQueryType
        // 
        labelQueryType.Location = new Point(260, 5);
        labelQueryType.Name = "labelQueryType";
        labelQueryType.Size = new Size(120, 20);
        labelQueryType.TabIndex = 3;
        labelQueryType.Text = "Тип запиту";
        // 
        // labelSearch
        // 
        labelSearch.Location = new Point(15, 5);
        labelSearch.Name = "labelSearch";
        labelSearch.Size = new Size(120, 20);
        labelSearch.TabIndex = 2;
        labelSearch.Text = "Пошук товару";
        // 
        // buttonSearch
        // 
        buttonSearch.Location = new Point(485, 27);
        buttonSearch.Name = "buttonSearch";
        buttonSearch.Size = new Size(110, 27);
        buttonSearch.TabIndex = 1;
        buttonSearch.Text = "Знайти";
        buttonSearch.UseVisualStyleBackColor = true;
        // 
        // buttonRefresh
        // 
        buttonRefresh.Location = new Point(610, 27);
        buttonRefresh.Name = "buttonRefresh";
        buttonRefresh.Size = new Size(110, 27);
        buttonRefresh.TabIndex = 0;
        buttonRefresh.Text = "Оновити";
        buttonRefresh.UseVisualStyleBackColor = true;
        // 
        // tabPageCharts
        // 
        tabPageCharts.Controls.Add(formsPlot);
        tabPageCharts.Controls.Add(panelChartControls);
        tabPageCharts.Location = new Point(4, 24);
        tabPageCharts.Name = "tabPageCharts";
        tabPageCharts.Padding = new Padding(3);
        tabPageCharts.Size = new Size(1076, 633);
        tabPageCharts.TabIndex = 1;
        tabPageCharts.Text = "Діаграми";
        tabPageCharts.UseVisualStyleBackColor = true;
        // 
        // formsPlot
        // 
        formsPlot.Dock = DockStyle.Fill;
        formsPlot.Location = new Point(3, 68);
        formsPlot.Name = "formsPlot";
        formsPlot.Size = new Size(1070, 562);
        formsPlot.TabIndex = 1;
        // 
        // panelChartControls
        // 
        panelChartControls.Controls.Add(buttonRefreshChart);
        panelChartControls.Controls.Add(buttonBuildChart);
        panelChartControls.Controls.Add(comboBoxChartType);
        panelChartControls.Controls.Add(labelChartType);
        panelChartControls.Dock = DockStyle.Top;
        panelChartControls.Location = new Point(3, 3);
        panelChartControls.Name = "panelChartControls";
        panelChartControls.Size = new Size(1070, 65);
        panelChartControls.TabIndex = 0;
        // 
        // buttonRefreshChart
        // 
        buttonRefreshChart.Location = new Point(405, 27);
        buttonRefreshChart.Name = "buttonRefreshChart";
        buttonRefreshChart.Size = new Size(140, 27);
        buttonRefreshChart.TabIndex = 4;
        buttonRefreshChart.Text = "Оновити дані";
        buttonRefreshChart.UseVisualStyleBackColor = true;
        // 
        // buttonBuildChart
        // 
        buttonBuildChart.Location = new Point(260, 27);
        buttonBuildChart.Name = "buttonBuildChart";
        buttonBuildChart.Size = new Size(130, 27);
        buttonBuildChart.TabIndex = 3;
        buttonBuildChart.Text = "Побудувати";
        buttonBuildChart.UseVisualStyleBackColor = true;
        // 
        // comboBoxChartType
        // 
        comboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxChartType.FormattingEnabled = true;
        comboBoxChartType.Location = new Point(15, 28);
        comboBoxChartType.Name = "comboBoxChartType";
        comboBoxChartType.Size = new Size(230, 23);
        comboBoxChartType.TabIndex = 2;
        // 
        // labelChartType
        // 
        labelChartType.Location = new Point(15, 5);
        labelChartType.Name = "labelChartType";
        labelChartType.Size = new Size(120, 20);
        labelChartType.TabIndex = 0;
        labelChartType.Text = "Тип діаграми";
        // 
        // DatabaseOperationsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1084, 661);
        Controls.Add(tabControlMain);
        MinimumSize = new Size(900, 550);
        Name = "DatabaseOperationsForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Керування базою даних PostgreSQL";
        tabControlMain.ResumeLayout(false);
        tabPageProducts.ResumeLayout(false);
        panelProducts.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
        panelEditor.ResumeLayout(false);
        panelEditor.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericWeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
        panelFilters.ResumeLayout(false);
        panelFilters.PerformLayout();
        tabPageCharts.ResumeLayout(false);
        panelChartControls.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TabControl tabControlMain;
    private TabPage tabPageProducts;
    private TabPage tabPageCharts;
    private Panel panelProducts;
    private Panel panelEditor;
    private Panel panelFilters;
    private DataGridView dataGridViewProducts;
    private TextBox textBoxCategory;
    private TextBox textBoxName;
    private NumericUpDown numericWeight;
    private NumericUpDown numericPrice;
    private NumericUpDown numericQuantity;
    private Label labelCategory;
    private Label Назва;
    private Label labelWeight;
    private Label labelPrice;
    private Label labelQuantity;
    private Button buttonDelete;
    private Button buttonUpdate;
    private Button buttonAdd;
    private Button buttonRefresh;
    private ComboBox comboBoxQueryType;
    private TextBox textBoxSearch;
    private Label labelQueryType;
    private Label labelSearch;
    private Button buttonSearch;
    private Panel panelChartControls;
    private ComboBox comboBoxChartType;
    private Button buttonBuildChart;
    private Button buttonRefreshChart;
    private Label labelChartType;
    private ScottPlot.WinForms.FormsPlot formsPlot;
}
