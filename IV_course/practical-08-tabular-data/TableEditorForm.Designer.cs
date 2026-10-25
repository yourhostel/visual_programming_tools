namespace TabularData;

partial class TableEditorForm
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
        components = new System.ComponentModel.Container();
        menuMain = new MenuStrip();
        menuFile = new ToolStripMenuItem();
        menuCreate = new ToolStripMenuItem();
        menuOpenXml = new ToolStripMenuItem();
        menuSaveXml = new ToolStripMenuItem();
        menuExit = new ToolStripMenuItem();
        menuTable = new ToolStripMenuItem();
        menuAddRow = new ToolStripMenuItem();
        menuDeleteRow = new ToolStripMenuItem();
        menuChart = new ToolStripMenuItem();
        menuRefreshChart = new ToolStripMenuItem();
        menuTableContext = new ContextMenuStrip(components);
        contextCreate = new ToolStripMenuItem();
        contextOpenXml = new ToolStripMenuItem();
        contextSaveXml = new ToolStripMenuItem();
        toolMain = new ToolStrip();
        splitMain = new SplitContainer();
        gridData = new DataGridView();
        panelChart = new Panel();
        comboChartType = new ComboBox();
        statusMain = new StatusStrip();
        statusRows = new ToolStripStatusLabel();
        menuMain.SuspendLayout();
        menuTableContext.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridData).BeginInit();
        statusMain.SuspendLayout();
        SuspendLayout();
        // 
        // menuMain
        // 
        menuMain.Items.AddRange(new ToolStripItem[] { menuFile, menuTable, menuChart });
        menuMain.Location = new Point(0, 0);
        menuMain.Name = "menuMain";
        menuMain.Size = new Size(1084, 24);
        menuMain.TabIndex = 0;
        menuMain.Text = "menuStrip1";
        // 
        // menuFile
        // 
        menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuCreate, menuOpenXml, menuSaveXml, menuExit });
        menuFile.Name = "menuFile";
        menuFile.Size = new Size(48, 20);
        menuFile.Text = "Файл";
        // 
        // menuCreate
        // 
        menuCreate.Name = "menuCreate";
        menuCreate.Size = new Size(151, 22);
        menuCreate.Text = "Створити";
        // 
        // menuOpenXml
        // 
        menuOpenXml.Name = "menuOpenXml";
        menuOpenXml.Size = new Size(151, 22);
        menuOpenXml.Text = "Відкрити XML";
        // 
        // menuSaveXml
        // 
        menuSaveXml.Name = "menuSaveXml";
        menuSaveXml.Size = new Size(151, 22);
        menuSaveXml.Text = "Зберегти XML";
        // 
        // menuExit
        // 
        menuExit.Name = "menuExit";
        menuExit.Size = new Size(151, 22);
        menuExit.Text = "Вихід";
        // 
        // menuTable
        // 
        menuTable.DropDownItems.AddRange(new ToolStripItem[] { menuAddRow, menuDeleteRow });
        menuTable.Name = "menuTable";
        menuTable.Size = new Size(66, 20);
        menuTable.Text = "Таблиця";
        // 
        // menuAddRow
        // 
        menuAddRow.Name = "menuAddRow";
        menuAddRow.Size = new Size(161, 22);
        menuAddRow.Text = "Додати рядок";
        // 
        // menuDeleteRow
        // 
        menuDeleteRow.Name = "menuDeleteRow";
        menuDeleteRow.Size = new Size(161, 22);
        menuDeleteRow.Text = "Видалити рядок";
        // 
        // menuChart
        // 
        menuChart.DropDownItems.AddRange(new ToolStripItem[] { menuRefreshChart });
        menuChart.Name = "menuChart";
        menuChart.Size = new Size(69, 20);
        menuChart.Text = "Діаграма";
        // 
        // menuRefreshChart
        // 
        menuRefreshChart.Name = "menuRefreshChart";
        menuRefreshChart.Size = new Size(122, 22);
        menuRefreshChart.Text = "Оновити";
        // 
        // menuTableContext
        // 
        menuTableContext.Items.AddRange(new ToolStripItem[] { contextCreate, contextOpenXml, contextSaveXml });
        menuTableContext.Name = "menuTableContext";
        menuTableContext.Size = new Size(127, 70);
        // 
        // contextCreate
        // 
        contextCreate.Name = "contextCreate";
        contextCreate.Size = new Size(126, 22);
        contextCreate.Text = "Створити";
        // 
        // contextOpenXml
        // 
        contextOpenXml.Name = "contextOpenXml";
        contextOpenXml.Size = new Size(126, 22);
        contextOpenXml.Text = "Відкрити";
        // 
        // contextSaveXml
        // 
        contextSaveXml.Name = "contextSaveXml";
        contextSaveXml.Size = new Size(126, 22);
        contextSaveXml.Text = "Зберегти";
        // 
        // toolMain
        // 
        toolMain.Location = new Point(0, 24);
        toolMain.Name = "toolMain";
        toolMain.Size = new Size(1084, 25);
        toolMain.TabIndex = 2;
        toolMain.Text = "toolStrip1";
        // 
        // splitMain
        // 
        splitMain.Dock = DockStyle.Fill;
        splitMain.Location = new Point(0, 49);
        splitMain.Name = "splitMain";
        // 
        // splitMain.Panel1
        // 
        splitMain.Panel1.Controls.Add(gridData);
        splitMain.Panel1.Padding = new Padding(10);
        splitMain.Panel1MinSize = 300;
        // 
        // splitMain.Panel2
        // 
        splitMain.Panel2.Controls.Add(panelChart);
        splitMain.Panel2.Controls.Add(comboChartType);
        splitMain.Panel2.Padding = new Padding(10);
        splitMain.Panel2MinSize = 300;
        splitMain.Size = new Size(1084, 700);
        splitMain.SplitterDistance = 600;
        splitMain.TabIndex = 5;
        // 
        // gridData
        // 
        gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        gridData.BackgroundColor = Color.White;
        gridData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridData.ContextMenuStrip = menuTableContext;
        gridData.Dock = DockStyle.Fill;
        gridData.Location = new Point(10, 10);
        gridData.Name = "gridData";
        gridData.RowHeadersWidth = 30;
        gridData.Size = new Size(580, 680);
        gridData.TabIndex = 4;
        // 
        // panelChart
        // 
        panelChart.BackColor = Color.White;
        panelChart.BorderStyle = BorderStyle.FixedSingle;
        panelChart.Dock = DockStyle.Fill;
        panelChart.Location = new Point(10, 35);
        panelChart.Name = "panelChart";
        panelChart.Size = new Size(460, 655);
        panelChart.TabIndex = 6;
        // 
        // comboChartType
        // 
        comboChartType.Dock = DockStyle.Top;
        comboChartType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboChartType.FormattingEnabled = true;
        comboChartType.Items.AddRange(new object[] { "Стовпчикова", "Лінійна" });
        comboChartType.Location = new Point(10, 10);
        comboChartType.Name = "comboChartType";
        comboChartType.Size = new Size(460, 25);
        comboChartType.TabIndex = 5;
        // 
        // statusMain
        // 
        statusMain.Items.AddRange(new ToolStripItem[] { statusRows });
        statusMain.Location = new Point(0, 727);
        statusMain.Name = "statusMain";
        statusMain.Size = new Size(1084, 22);
        statusMain.TabIndex = 6;
        statusMain.Text = "statusStrip1";
        // 
        // statusRows
        // 
        statusRows.Name = "statusRows";
        statusRows.Size = new Size(61, 17);
        statusRows.Text = "Записів: 0";
        // 
        // TableEditorForm
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1084, 749);
        Controls.Add(statusMain);
        Controls.Add(splitMain);
        Controls.Add(toolMain);
        Controls.Add(menuMain);
        Font = new Font("Segoe UI", 10F);
        MainMenuStrip = menuMain;
        MinimumSize = new Size(900, 675);
        Name = "TableEditorForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Практична №8. Табличне введення даних";
        menuMain.ResumeLayout(false);
        menuMain.PerformLayout();
        menuTableContext.ResumeLayout(false);
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridData).EndInit();
        statusMain.ResumeLayout(false);
        statusMain.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuMain;
    private ToolStripMenuItem menuFile;
    private ToolStripMenuItem menuCreate;
    private ToolStripMenuItem menuOpenXml;
    private ToolStripMenuItem menuSaveXml;
    private ToolStripMenuItem menuExit;
    private ToolStripMenuItem menuTable;
    private ToolStripMenuItem menuChart;
    private ToolStripMenuItem menuAddRow;
    private ToolStripMenuItem menuDeleteRow;
    private ToolStripMenuItem menuRefreshChart;
    private ContextMenuStrip menuTableContext;
    private ToolStripMenuItem contextCreate;
    private ToolStripMenuItem contextOpenXml;
    private ToolStripMenuItem contextSaveXml;
    private ToolStrip toolMain;
    private SplitContainer splitMain;
    private StatusStrip statusMain;
    private DataGridView gridData;
    private ComboBox comboChartType;
    private Panel panelChart;
    private ToolStripStatusLabel statusRows;
}
