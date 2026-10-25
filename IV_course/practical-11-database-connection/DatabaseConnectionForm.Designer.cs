namespace DatabaseConnection;

partial class DatabaseConnectionForm
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
        buttonCheckConnection = new Button();
        labelStatus = new Label();
        dataGridViewServer = new DataGridView();
        dataGridViewDatabases = new DataGridView();
        labelServerTitle = new Label();
        labelDatabaseTitl = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridViewServer).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewDatabases).BeginInit();
        SuspendLayout();
        // 
        // buttonCheckConnection
        // 
        buttonCheckConnection.Location = new Point(20, 20);
        buttonCheckConnection.Name = "buttonCheckConnection";
        buttonCheckConnection.Size = new Size(180, 35);
        buttonCheckConnection.TabIndex = 0;
        buttonCheckConnection.Text = "Перевірити підключення";
        buttonCheckConnection.UseVisualStyleBackColor = true;
        // 
        // labelStatus
        // 
        labelStatus.Location = new Point(220, 29);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(400, 25);
        labelStatus.TabIndex = 1;
        labelStatus.Text = "Підключення не перевірено";
        // 
        // dataGridViewServer
        // 
        dataGridViewServer.AllowUserToAddRows = false;
        dataGridViewServer.AllowUserToDeleteRows = false;
        dataGridViewServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewServer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewServer.BackgroundColor = Color.White;
        dataGridViewServer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewServer.Location = new Point(20, 100);
        dataGridViewServer.Name = "dataGridViewServer";
        dataGridViewServer.ReadOnly = true;
        dataGridViewServer.Size = new Size(940, 160);
        dataGridViewServer.TabIndex = 2;
        // 
        // dataGridViewDatabases
        // 
        dataGridViewDatabases.AllowUserToAddRows = false;
        dataGridViewDatabases.AllowUserToDeleteRows = false;
        dataGridViewDatabases.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dataGridViewDatabases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridViewDatabases.BackgroundColor = Color.White;
        dataGridViewDatabases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewDatabases.Location = new Point(20, 320);
        dataGridViewDatabases.Name = "dataGridViewDatabases";
        dataGridViewDatabases.ReadOnly = true;
        dataGridViewDatabases.Size = new Size(940, 180);
        dataGridViewDatabases.TabIndex = 3;
        // 
        // labelServerTitle
        // 
        labelServerTitle.Location = new Point(20, 75);
        labelServerTitle.Name = "labelServerTitle";
        labelServerTitle.Size = new Size(400, 25);
        labelServerTitle.TabIndex = 4;
        labelServerTitle.Text = "Інформація про сервер PostgreSQL";
        // 
        // labelDatabaseTitl
        // 
        labelDatabaseTitl.Location = new Point(20, 295);
        labelDatabaseTitl.Name = "labelDatabaseTitl";
        labelDatabaseTitl.Size = new Size(400, 25);
        labelDatabaseTitl.TabIndex = 5;
        labelDatabaseTitl.Text = "Перевірка бази даних";
        // 
        // DatabaseConnectionForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 561);
        Controls.Add(labelDatabaseTitl);
        Controls.Add(labelServerTitle);
        Controls.Add(dataGridViewDatabases);
        Controls.Add(dataGridViewServer);
        Controls.Add(labelStatus);
        Controls.Add(buttonCheckConnection);
        MinimumSize = new Size(800, 500);
        Name = "DatabaseConnectionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Підключення до PostgreSQL";
        ((System.ComponentModel.ISupportInitialize)dataGridViewServer).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridViewDatabases).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonCheckConnection;
    private Label labelStatus;
    private DataGridView dataGridViewServer;
    private DataGridView dataGridViewDatabases;
    private Label labelServerTitle;
    private Label labelDatabaseTitl;
}
