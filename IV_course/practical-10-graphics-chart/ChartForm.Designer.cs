namespace GraphicsChart;

partial class ChartForm
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
        formsPlot = new ScottPlot.WinForms.FormsPlot();
        panelControls = new Panel();
        comboData = new ComboBox();
        comboChartType = new ComboBox();
        panelControls.SuspendLayout();
        SuspendLayout();
        // 
        // formsPlot
        // 
        formsPlot.Dock = DockStyle.Fill;
        formsPlot.Location = new Point(0, 0);
        formsPlot.Name = "formsPlot";
        formsPlot.Size = new Size(984, 611);
        formsPlot.TabIndex = 0;
        // 
        // panelControls
        // 
        panelControls.Controls.Add(comboChartType);
        panelControls.Controls.Add(comboData);
        panelControls.Dock = DockStyle.Top;
        panelControls.Location = new Point(0, 0);
        panelControls.Name = "panelControls";
        panelControls.Size = new Size(984, 50);
        panelControls.TabIndex = 1;
        // 
        // comboData
        // 
        comboData.DropDownStyle = ComboBoxStyle.DropDownList;
        comboData.FormattingEnabled = true;
        comboData.Location = new Point(15, 12);
        comboData.Name = "comboData";
        comboData.Size = new Size(160, 23);
        comboData.TabIndex = 0;
        // 
        // comboChartType
        // 
        comboChartType.DropDownStyle = ComboBoxStyle.DropDownList;
        comboChartType.FormattingEnabled = true;
        comboChartType.Location = new Point(181, 12);
        comboChartType.Name = "comboChartType";
        comboChartType.Size = new Size(160, 23);
        comboChartType.TabIndex = 1;
        // 
        // ChartForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 611);
        Controls.Add(panelControls);
        Controls.Add(formsPlot);
        Name = "ChartForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Графік даних товарів";
        panelControls.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ScottPlot.WinForms.FormsPlot formsPlot;
    private Panel panelControls;
    private ComboBox comboData;
    private ComboBox comboChartType;
}
