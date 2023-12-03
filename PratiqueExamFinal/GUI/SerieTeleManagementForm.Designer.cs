namespace PratiqueExamFinal.GUI;

partial class SerieTeleManagementForm
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
        panel1 = new Panel();
        actionButton = new Button();
        cancelButton = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        controlsPanel = new Panel();
        serietelevisionActeurListBox = new ListBox();
        acteurLabel = new Label();
        genreTextBox = new TextBox();
        genreLabel = new Label();
        serieteleTextBox = new TextBox();
        serieteleLabel = new Label();
        idField = new NumericUpDown();
        idLabel = new Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        controlsPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)idField).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(actionButton);
        panel1.Controls.Add(cancelButton);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 401);
        panel1.Name = "panel1";
        panel1.Size = new Size(484, 60);
        panel1.TabIndex = 0;
        // 
        // actionButton
        // 
        actionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        actionButton.Location = new Point(286, 18);
        actionButton.Name = "actionButton";
        actionButton.Size = new Size(90, 30);
        actionButton.TabIndex = 1;
        actionButton.Text = "ACTION";
        actionButton.UseVisualStyleBackColor = true;
        // actionButton.Click += actionButton_Click;
        // 
        // cancelButton
        // 
        cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cancelButton.Location = new Point(382, 18);
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(90, 30);
        cancelButton.TabIndex = 0;
        cancelButton.Text = "Annuler";
        cancelButton.UseVisualStyleBackColor = true;
        //cancelButton.Click += cancelButton_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.Controls.Add(controlsPanel, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(484, 401);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // controlsPanel
        // 
        controlsPanel.Controls.Add(serietelevisionActeurListBox);
        controlsPanel.Controls.Add(acteurLabel);
        controlsPanel.Controls.Add(genreTextBox);
        controlsPanel.Controls.Add(genreLabel);
        controlsPanel.Controls.Add(serieteleTextBox);
        controlsPanel.Controls.Add(serieteleLabel);
        controlsPanel.Controls.Add(idField);
        controlsPanel.Controls.Add(idLabel);
        controlsPanel.Dock = DockStyle.Fill;
        controlsPanel.Location = new Point(124, 3);
        controlsPanel.Name = "controlsPanel";
        controlsPanel.Padding = new Padding(10, 20, 10, 20);
        controlsPanel.Size = new Size(236, 395);
        controlsPanel.TabIndex = 0;
        // 
        // serietelevisionActeurListBox
        // 
        serietelevisionActeurListBox.Dock = DockStyle.Fill;
        serietelevisionActeurListBox.FormattingEnabled = true;
        serietelevisionActeurListBox.ItemHeight = 15;
        serietelevisionActeurListBox.Location = new Point(10, 149);
        serietelevisionActeurListBox.Name = "serietelevisionActeurListBox";
        serietelevisionActeurListBox.Size = new Size(216, 226);
        serietelevisionActeurListBox.TabIndex = 7;
        // 
        // acteurLabel
        // 
        acteurLabel.Dock = DockStyle.Top;
        acteurLabel.Location = new Point(10, 134);
        acteurLabel.Name = "acteurLabel";
        acteurLabel.Size = new Size(216, 15);
        acteurLabel.TabIndex = 6;
        acteurLabel.Text = "Acteurs dans la Série Télévision :";
        // 
        // genreTextBox
        // 
        genreTextBox.Dock = DockStyle.Top;
        genreTextBox.Location = new Point(10, 111);
        genreTextBox.Name = "genreTextBox";
        genreTextBox.PlaceholderText = "Genre de la Série Télévision";
        genreTextBox.Size = new Size(216, 23);
        genreTextBox.TabIndex = 5;
        // 
        // genreLabel
        // 
        genreLabel.Dock = DockStyle.Top;
        genreLabel.Location = new Point(10, 96);
        genreLabel.Name = "genreLabel";
        genreLabel.Size = new Size(216, 15);
        genreLabel.TabIndex = 4;
        genreLabel.Text = "Genre de la Série Télévision :";
        //genreLabel.Click += genreLabel_Click;
        // 
        // serieteleTextBox
        // 
        serieteleTextBox.Dock = DockStyle.Top;
        serieteleTextBox.Location = new Point(10, 73);
        serieteleTextBox.Name = "serieteleTextBox";
        serieteleTextBox.PlaceholderText = " Nom Série Télévision";
        serieteleTextBox.Size = new Size(216, 23);
        serieteleTextBox.TabIndex = 3;
        // 
        // serieteleLabel
        // 
        serieteleLabel.Dock = DockStyle.Top;
        serieteleLabel.Location = new Point(10, 58);
        serieteleLabel.Name = "serieteleLabel";
        serieteleLabel.Size = new Size(216, 15);
        serieteleLabel.TabIndex = 2;
        serieteleLabel.Text = "Nom Série Télélvison :";
        // 
        // idField
        // 
        idField.Dock = DockStyle.Top;
        idField.Enabled = false;
        idField.Location = new Point(10, 35);
        idField.Name = "idField";
        idField.Size = new Size(216, 23);
        idField.TabIndex = 1;
        // 
        // idLabel
        // 
        idLabel.Dock = DockStyle.Top;
        idLabel.Location = new Point(10, 20);
        idLabel.Name = "idLabel";
        idLabel.Size = new Size(216, 15);
        idLabel.TabIndex = 0;
        idLabel.Text = "ID:";
        //idLabel.Click += idLabel_Click;
        // 
        // SerieTeleManagementForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(484, 461);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(panel1);
        Name = "SerieTeleManagementForm";
        Text = "SerieTeleManagementForm";
        panel1.ResumeLayout(false);
        tableLayoutPanel1.ResumeLayout(false);
        controlsPanel.ResumeLayout(false);
        controlsPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)idField).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel controlsPanel;
    private NumericUpDown idField;
    private Label idLabel;
    private Label genreLabel;
    private TextBox serieteleTextBox;
    private Label serieteleLabel;
    private TextBox genreTextBox;
    private Label acteurLabel;
    private Button cancelButton;
    private ListBox serietelevisionActeurListBox;
    private Button actionButton;
}