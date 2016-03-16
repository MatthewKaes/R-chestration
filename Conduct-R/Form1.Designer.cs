namespace Conduct_R
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
      this.components = new System.ComponentModel.Container();
      this.graphTarget = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rScriptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openDataframeDialog = new System.Windows.Forms.OpenFileDialog();
      this.dataFrameHeader2 = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.trendLine = new System.Windows.Forms.CheckBox();
      this.confidenceInterval = new System.Windows.Forms.CheckBox();
      this.modelSelect = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.titleText = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.xLabel = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.yLabel = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.graphDesign = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.elementSizeTrack = new System.Windows.Forms.TrackBar();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.label9 = new System.Windows.Forms.Label();
      this.dpiTicker = new System.Windows.Forms.TrackBar();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.colorizeCheck = new System.Windows.Forms.CheckBox();
      this.dataFeatures = new System.Windows.Forms.CheckedListBox();
      this.saveScriptDialog = new System.Windows.Forms.SaveFileDialog();
      this.openScriptDialog = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.graphTarget)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.elementSizeTrack)).BeginInit();
      this.tabPage3.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dpiTicker)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      // 
      // graphTarget
      // 
      this.graphTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.graphTarget.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.graphTarget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.graphTarget.Location = new System.Drawing.Point(12, 166);
      this.graphTarget.Name = "graphTarget";
      this.graphTarget.Size = new System.Drawing.Size(985, 381);
      this.graphTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.graphTarget.TabIndex = 0;
      this.graphTarget.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 33);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(48, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Features";
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
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
      this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rScriptToolStripMenuItem,
            this.rScriptToolStripMenuItem1});
      this.saveToolStripMenuItem.Enabled = false;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.saveToolStripMenuItem.Text = "Save";
      // 
      // rScriptToolStripMenuItem
      // 
      this.rScriptToolStripMenuItem.Name = "rScriptToolStripMenuItem";
      this.rScriptToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
      this.rScriptToolStripMenuItem.Text = "Render";
      this.rScriptToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // rScriptToolStripMenuItem1
      // 
      this.rScriptToolStripMenuItem1.Name = "rScriptToolStripMenuItem1";
      this.rScriptToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
      this.rScriptToolStripMenuItem1.Text = "R Script";
      this.rScriptToolStripMenuItem1.Click += new System.EventHandler(this.rScriptToolStripMenuItem1_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "Edit";
      // 
      // scriptToolStripMenuItem
      // 
      this.scriptToolStripMenuItem.Enabled = false;
      this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
      this.scriptToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
      this.scriptToolStripMenuItem.Text = "Script";
      // 
      // openDataframeDialog
      // 
      this.openDataframeDialog.Filter = "Dataframe Files|*.csv";
      this.openDataframeDialog.Title = "Open Dataframe";
      // 
      // dataFrameHeader2
      // 
      this.dataFrameHeader2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.dataFrameHeader2.Enabled = false;
      this.dataFrameHeader2.FormattingEnabled = true;
      this.dataFrameHeader2.Location = new System.Drawing.Point(206, 49);
      this.dataFrameHeader2.Name = "dataFrameHeader2";
      this.dataFrameHeader2.Size = new System.Drawing.Size(188, 21);
      this.dataFrameHeader2.TabIndex = 5;
      this.dataFrameHeader2.SelectedIndexChanged += new System.EventHandler(this.dataFrameHeader2_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(206, 33);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(106, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Independent Feature";
      // 
      // trendLine
      // 
      this.trendLine.AutoSize = true;
      this.trendLine.Location = new System.Drawing.Point(297, 26);
      this.trendLine.Name = "trendLine";
      this.trendLine.Size = new System.Drawing.Size(77, 17);
      this.trendLine.TabIndex = 7;
      this.trendLine.Text = "Trend Line";
      this.trendLine.UseVisualStyleBackColor = true;
      this.trendLine.CheckedChanged += new System.EventHandler(this.FlagForRender);
      // 
      // confidenceInterval
      // 
      this.confidenceInterval.AutoSize = true;
      this.confidenceInterval.Location = new System.Drawing.Point(161, 28);
      this.confidenceInterval.Name = "confidenceInterval";
      this.confidenceInterval.Size = new System.Drawing.Size(118, 17);
      this.confidenceInterval.TabIndex = 6;
      this.confidenceInterval.Text = "Confidence Interval";
      this.confidenceInterval.UseVisualStyleBackColor = true;
      this.confidenceInterval.CheckedChanged += new System.EventHandler(this.FlagForRender);
      // 
      // modelSelect
      // 
      this.modelSelect.AutoCompleteCustomSource.AddRange(new string[] {
            "Scatter",
            "Line"});
      this.modelSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.modelSelect.FormattingEnabled = true;
      this.modelSelect.Items.AddRange(new object[] {
            "Local",
            "General",
            "Linear",
            "Quadratic",
            "Cubic"});
      this.modelSelect.Location = new System.Drawing.Point(6, 26);
      this.modelSelect.Name = "modelSelect";
      this.modelSelect.Size = new System.Drawing.Size(135, 21);
      this.modelSelect.TabIndex = 2;
      this.modelSelect.SelectedIndexChanged += new System.EventHandler(this.FlagForRender);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 10);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Model";
      // 
      // titleText
      // 
      this.titleText.Location = new System.Drawing.Point(156, 27);
      this.titleText.Name = "titleText";
      this.titleText.Size = new System.Drawing.Size(137, 20);
      this.titleText.TabIndex = 8;
      this.titleText.TextChanged += new System.EventHandler(this.FlagForRender);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(153, 11);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(27, 13);
      this.label8.TabIndex = 7;
      this.label8.Text = "Title";
      // 
      // xLabel
      // 
      this.xLabel.Location = new System.Drawing.Point(6, 66);
      this.xLabel.Name = "xLabel";
      this.xLabel.Size = new System.Drawing.Size(144, 20);
      this.xLabel.TabIndex = 6;
      this.xLabel.TextChanged += new System.EventHandler(this.FlagForRender);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(3, 50);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(43, 13);
      this.label7.TabIndex = 5;
      this.label7.Text = "X Label";
      // 
      // yLabel
      // 
      this.yLabel.Location = new System.Drawing.Point(6, 26);
      this.yLabel.Name = "yLabel";
      this.yLabel.Size = new System.Drawing.Size(144, 20);
      this.yLabel.TabIndex = 4;
      this.yLabel.TextChanged += new System.EventHandler(this.FlagForRender);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 10);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(43, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Y Label";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 25;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // saveImageDialog
      // 
      this.saveImageDialog.DefaultExt = "png";
      this.saveImageDialog.Filter = "Image Render|*.png";
      this.saveImageDialog.Title = "Save Rendering";
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Location = new System.Drawing.Point(400, 27);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(597, 133);
      this.tabControl1.TabIndex = 12;
      // 
      // tabPage2
      // 
      this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.graphDesign);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.elementSizeTrack);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(589, 107);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Style";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(72, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Graph Design";
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
      this.graphDesign.Location = new System.Drawing.Point(6, 26);
      this.graphDesign.Name = "graphDesign";
      this.graphDesign.Size = new System.Drawing.Size(135, 21);
      this.graphDesign.TabIndex = 2;
      this.graphDesign.SelectedIndexChanged += new System.EventHandler(this.FlagForRender);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(156, 10);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Element Size";
      // 
      // elementSizeTrack
      // 
      this.elementSizeTrack.Enabled = false;
      this.elementSizeTrack.Location = new System.Drawing.Point(147, 26);
      this.elementSizeTrack.Maximum = 70;
      this.elementSizeTrack.Minimum = 10;
      this.elementSizeTrack.Name = "elementSizeTrack";
      this.elementSizeTrack.Size = new System.Drawing.Size(163, 45);
      this.elementSizeTrack.SmallChange = 5;
      this.elementSizeTrack.TabIndex = 4;
      this.elementSizeTrack.TickFrequency = 5;
      this.elementSizeTrack.Value = 20;
      this.elementSizeTrack.Scroll += new System.EventHandler(this.FlagForRender);
      // 
      // tabPage3
      // 
      this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
      this.tabPage3.Controls.Add(this.trendLine);
      this.tabPage3.Controls.Add(this.modelSelect);
      this.tabPage3.Controls.Add(this.label5);
      this.tabPage3.Controls.Add(this.confidenceInterval);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(589, 107);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Analytics";
      // 
      // tabPage4
      // 
      this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
      this.tabPage4.Controls.Add(this.label9);
      this.tabPage4.Controls.Add(this.dpiTicker);
      this.tabPage4.Controls.Add(this.titleText);
      this.tabPage4.Controls.Add(this.label6);
      this.tabPage4.Controls.Add(this.label8);
      this.tabPage4.Controls.Add(this.yLabel);
      this.tabPage4.Controls.Add(this.xLabel);
      this.tabPage4.Controls.Add(this.label7);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(589, 107);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Aesthetics";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(308, 11);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(57, 13);
      this.label9.TabIndex = 10;
      this.label9.Text = "Graph DPI";
      // 
      // dpiTicker
      // 
      this.dpiTicker.LargeChange = 10;
      this.dpiTicker.Location = new System.Drawing.Point(299, 27);
      this.dpiTicker.Maximum = 200;
      this.dpiTicker.Minimum = 70;
      this.dpiTicker.Name = "dpiTicker";
      this.dpiTicker.Size = new System.Drawing.Size(163, 45);
      this.dpiTicker.SmallChange = 10;
      this.dpiTicker.TabIndex = 9;
      this.dpiTicker.TickFrequency = 10;
      this.dpiTicker.Value = 150;
      this.dpiTicker.Scroll += new System.EventHandler(this.FlagForRender);
      // 
      // tabPage1
      // 
      this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
      this.tabPage1.Controls.Add(this.colorizeCheck);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(589, 107);
      this.tabPage1.TabIndex = 4;
      this.tabPage1.Text = "Color";
      // 
      // colorizeCheck
      // 
      this.colorizeCheck.AutoSize = true;
      this.colorizeCheck.Location = new System.Drawing.Point(12, 28);
      this.colorizeCheck.Name = "colorizeCheck";
      this.colorizeCheck.Size = new System.Drawing.Size(63, 17);
      this.colorizeCheck.TabIndex = 7;
      this.colorizeCheck.Text = "Colorize";
      this.colorizeCheck.UseVisualStyleBackColor = true;
      this.colorizeCheck.CheckedChanged += new System.EventHandler(this.FlagForRender);
      // 
      // dataFeatures
      // 
      this.dataFeatures.Enabled = false;
      this.dataFeatures.FormattingEnabled = true;
      this.dataFeatures.Location = new System.Drawing.Point(15, 49);
      this.dataFeatures.Name = "dataFeatures";
      this.dataFeatures.Size = new System.Drawing.Size(185, 109);
      this.dataFeatures.TabIndex = 13;
      this.dataFeatures.SelectedIndexChanged += new System.EventHandler(this.FlagForRender);
      // 
      // saveScriptDialog
      // 
      this.saveScriptDialog.DefaultExt = "png";
      this.saveScriptDialog.Filter = "R Script|*.r";
      this.saveScriptDialog.Title = "Save Rendering Script";
      // 
      // openScriptDialog
      // 
      this.openScriptDialog.Filter = "R Script|*.r";
      this.openScriptDialog.Title = "Execute R Script on Workspace";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 559);
      this.Controls.Add(this.dataFeatures);
      this.Controls.Add(this.dataFrameHeader2);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.graphTarget);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.label1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximumSize = new System.Drawing.Size(1025, 597);
      this.Name = "Form1";
      this.Text = "Conduct-R";
      this.ResizeEnd += new System.EventHandler(this.FlagForRender);
      ((System.ComponentModel.ISupportInitialize)(this.graphTarget)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.elementSizeTrack)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage3.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dpiTicker)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox graphTarget;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openDataframeDialog;
    private System.Windows.Forms.CheckBox confidenceInterval;
    private System.Windows.Forms.CheckBox trendLine;
    private System.Windows.Forms.ComboBox modelSelect;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox dataFrameHeader2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox xLabel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox yLabel;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox titleText;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.SaveFileDialog saveImageDialog;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox graphDesign;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar elementSizeTrack;
    private System.Windows.Forms.CheckedListBox dataFeatures;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TrackBar dpiTicker;
    private System.Windows.Forms.ToolStripMenuItem rScriptToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rScriptToolStripMenuItem1;
    private System.Windows.Forms.SaveFileDialog saveScriptDialog;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openScriptDialog;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.CheckBox colorizeCheck;
  }
}

