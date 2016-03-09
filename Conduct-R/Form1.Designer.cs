﻿namespace Conduct_R
{
  partial class Form1
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
      this.graphTarget = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      this.dataFrameHeader1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.plotButton = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openDataframeDialog = new System.Windows.Forms.OpenFileDialog();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.graphDesign = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.graphTarget)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // graphTarget
      // 
      this.graphTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.graphTarget.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.graphTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.graphTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.graphTarget.Location = new System.Drawing.Point(12, 126);
      this.graphTarget.Name = "graphTarget";
      this.graphTarget.Size = new System.Drawing.Size(800, 512);
      this.graphTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.graphTarget.TabIndex = 0;
      this.graphTarget.TabStop = false;
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(818, 602);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(112, 36);
      this.button1.TabIndex = 1;
      this.button1.Text = "Regression";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // dataFrameHeader1
      // 
      this.dataFrameHeader1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.dataFrameHeader1.Enabled = false;
      this.dataFrameHeader1.FormattingEnabled = true;
      this.dataFrameHeader1.Location = new System.Drawing.Point(6, 33);
      this.dataFrameHeader1.Name = "dataFrameHeader1";
      this.dataFrameHeader1.Size = new System.Drawing.Size(188, 21);
      this.dataFrameHeader1.Sorted = true;
      this.dataFrameHeader1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(39, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Data 1";
      // 
      // plotButton
      // 
      this.plotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.plotButton.Enabled = false;
      this.plotButton.Location = new System.Drawing.Point(818, 560);
      this.plotButton.Name = "plotButton";
      this.plotButton.Size = new System.Drawing.Size(112, 36);
      this.plotButton.TabIndex = 4;
      this.plotButton.Text = "Plot";
      this.plotButton.UseVisualStyleBackColor = true;
      this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(942, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.saveToolStripMenuItem.Text = "Save";
      // 
      // openDataframeDialog
      // 
      this.openDataframeDialog.Filter = "Dataframe Files|*.csv";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dataFrameHeader1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 93);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Data Selection";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.graphDesign);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(218, 27);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(316, 93);
      this.groupBox2.TabIndex = 9;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Data Selection";
      // 
      // graphDesign
      // 
      this.graphDesign.AutoCompleteCustomSource.AddRange(new string[] {
            "Scatter",
            "Line"});
      this.graphDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.graphDesign.FormattingEnabled = true;
      this.graphDesign.Items.AddRange(new object[] {
            "Scatter",
            "Line"});
      this.graphDesign.Location = new System.Drawing.Point(6, 33);
      this.graphDesign.Name = "graphDesign";
      this.graphDesign.Size = new System.Drawing.Size(135, 21);
      this.graphDesign.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 17);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Graph Design";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(942, 650);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.plotButton);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.graphTarget);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(788, 550);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.graphTarget)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox graphTarget;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox dataFrameHeader1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button plotButton;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openDataframeDialog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox graphDesign;
    private System.Windows.Forms.Label label2;
  }
}
