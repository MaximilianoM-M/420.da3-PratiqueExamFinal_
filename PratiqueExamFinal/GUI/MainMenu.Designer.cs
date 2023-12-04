namespace PratiqueExamFinal.GUI;

partial class MainMenu
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
        panel1 = new Panel();
        tableLayoutPanel1 = new TableLayoutPanel();
        SérieTeleListBox = new ListBox();
        buttonsPanel = new Panel();
        quitBtn = new Button();
        deleteSerieTeleBtn = new Button();
        editSerieTeleBtn = new Button();
        serieteleViewBtn = new Button();
        createSerieTeleBtn = new Button();
        tableLayoutPanel1.SuspendLayout();
        buttonsPanel.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Location = new Point(188, 93);
        panel1.Name = "panel1";
        panel1.Size = new Size(0, 0);
        panel1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(SérieTeleListBox, 0, 0);
        tableLayoutPanel1.Controls.Add(buttonsPanel, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(584, 361);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // SérieTeleListBox
        // 
        SérieTeleListBox.Dock = DockStyle.Fill;
        SérieTeleListBox.FormattingEnabled = true;
        SérieTeleListBox.ItemHeight = 15;
        SérieTeleListBox.Location = new Point(3, 3);
        SérieTeleListBox.Name = "SérieTeleListBox";
        SérieTeleListBox.Size = new Size(286, 355);
        SérieTeleListBox.TabIndex = 0;
        SérieTeleListBox.SelectedIndexChanged += SérieTeleListBox_SelectedIndexChanged;
        // 
        // buttonsPanel
        // 
        buttonsPanel.Controls.Add(quitBtn);
        buttonsPanel.Controls.Add(deleteSerieTeleBtn);
        buttonsPanel.Controls.Add(editSerieTeleBtn);
        buttonsPanel.Controls.Add(serieteleViewBtn);
        buttonsPanel.Controls.Add(createSerieTeleBtn);
        buttonsPanel.Dock = DockStyle.Fill;
        buttonsPanel.Location = new Point(295, 3);
        buttonsPanel.Name = "buttonsPanel";
        buttonsPanel.Padding = new Padding(10);
        buttonsPanel.Size = new Size(286, 355);
        buttonsPanel.TabIndex = 1;
        // 
        // quitBtn
        // 
        quitBtn.Dock = DockStyle.Bottom;
        quitBtn.Location = new Point(10, 304);
        quitBtn.Name = "quitBtn";
        quitBtn.Size = new Size(266, 41);
        quitBtn.TabIndex = 4;
        quitBtn.Text = "Quitter";
        quitBtn.UseVisualStyleBackColor = true;
        quitBtn.Click += quitBtn_Click;
        // 
        // deleteSerieTeleBtn
        // 
        deleteSerieTeleBtn.Dock = DockStyle.Top;
        deleteSerieTeleBtn.Enabled = false;
        deleteSerieTeleBtn.Location = new Point(10, 133);
        deleteSerieTeleBtn.Name = "deleteSerieTeleBtn";
        deleteSerieTeleBtn.Size = new Size(266, 41);
        deleteSerieTeleBtn.TabIndex = 3;
        deleteSerieTeleBtn.Text = "Supprimer Série Téle";
        deleteSerieTeleBtn.UseVisualStyleBackColor = true;
        deleteSerieTeleBtn.Click += deleteSerieTeleBtn_Click;
        // 
        // editSerieTeleBtn
        // 
        editSerieTeleBtn.Dock = DockStyle.Top;
        editSerieTeleBtn.Enabled = false;
        editSerieTeleBtn.Location = new Point(10, 92);
        editSerieTeleBtn.Name = "editSerieTeleBtn";
        editSerieTeleBtn.Size = new Size(266, 41);
        editSerieTeleBtn.TabIndex = 2;
        editSerieTeleBtn.Text = "Modifier Série Téle";
        editSerieTeleBtn.UseVisualStyleBackColor = true;
        editSerieTeleBtn.Click += editSerieTeleBtn_Click;
        // 
        // serieteleViewBtn
        // 
        serieteleViewBtn.Dock = DockStyle.Top;
        serieteleViewBtn.Enabled = false;
        serieteleViewBtn.Location = new Point(10, 51);
        serieteleViewBtn.Name = "serieteleViewBtn";
        serieteleViewBtn.Size = new Size(266, 41);
        serieteleViewBtn.TabIndex = 1;
        serieteleViewBtn.Text = "Détails de la Série Téle";
        serieteleViewBtn.UseVisualStyleBackColor = true;
        serieteleViewBtn.Click += serieteleViewBtn_Click;
        // 
        // createSerieTeleBtn
        // 
        createSerieTeleBtn.Dock = DockStyle.Top;
        createSerieTeleBtn.Location = new Point(10, 10);
        createSerieTeleBtn.Name = "createSerieTeleBtn";
        createSerieTeleBtn.Size = new Size(266, 41);
        createSerieTeleBtn.TabIndex = 0;
        createSerieTeleBtn.Text = "Crée Nouvelle Série Téle";
        createSerieTeleBtn.UseVisualStyleBackColor = true;
        createSerieTeleBtn.Click += createSerieTeleBtn_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 361);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(panel1);
        Name = "MainMenu";
        Text = "Main Menu";
        tableLayoutPanel1.ResumeLayout(false);
        buttonsPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private ListBox SérieTeleListBox;
    private Panel buttonsPanel;
    private Button createSerieTeleBtn;
    private Button deleteSerieTeleBtn;
    private Button editSerieTeleBtn;
    private Button serieteleViewBtn;
    private Button quitBtn;
}
