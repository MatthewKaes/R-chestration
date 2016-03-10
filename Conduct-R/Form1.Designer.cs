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
      this.dataFrameHeader1 = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openDataframeDialog = new System.Windows.Forms.OpenFileDialog();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dataFrameHeader2 = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.trendLine = new System.Windows.Forms.CheckBox();
      this.confidenceInterval = new System.Windows.Forms.CheckBox();
      this.label3 = new System.Windows.Forms.Label();
      this.elementSizeTrack = new System.Windows.Forms.TrackBar();
      this.graphDesign = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.modelSelect = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.titleText = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.xLabel = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.yLabel = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.graphTarget)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.elementSizeTrack)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.groupBox4.SuspendLayout();
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
      this.graphTarget.Location = new System.Drawing.Point(12, 139);
      this.graphTarget.Name = "graphTarget";
      this.graphTarget.Size = new System.Drawing.Size(985, 554);
      this.graphTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.graphTarget.TabIndex = 0;
      this.graphTarget.TabStop = false;
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
      this.dataFrameHeader1.SelectedIndexChanged += new System.EventHandler(this.dataFrameHeader1_SelectedIndexChanged);
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
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
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
      this.saveToolStripMenuItem.Enabled = false;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // openDataframeDialog
      // 
      this.openDataframeDialog.Filter = "Dataframe Files|*.csv";
      this.openDataframeDialog.Title = "Open Dataframe";
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.dataFrameHeader2);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.dataFrameHeader1);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 27);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(200, 106);
      this.groupBox1.TabIndex = 8;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Data Selection";
      // 
      // dataFrameHeader2
      // 
      this.dataFrameHeader2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.dataFrameHeader2.Enabled = false;
      this.dataFrameHeader2.FormattingEnabled = true;
      this.dataFrameHeader2.Location = new System.Drawing.Point(6, 73);
      this.dataFrameHeader2.Name = "dataFrameHeader2";
      this.dataFrameHeader2.Size = new System.Drawing.Size(188, 21);
      this.dataFrameHeader2.TabIndex = 5;
      this.dataFrameHeader2.SelectedIndexChanged += new System.EventHandler(this.dataFrameHeader2_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 57);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(39, 13);
      this.label4.TabIndex = 4;
      this.label4.Text = "Data 2";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.trendLine);
      this.groupBox2.Controls.Add(this.confidenceInterval);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.elementSizeTrack);
      this.groupBox2.Controls.Add(this.graphDesign);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Location = new System.Drawing.Point(218, 27);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(316, 106);
      this.groupBox2.TabIndex = 9;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Graph Style";
      // 
      // trendLine
      // 
      this.trendLine.AutoSize = true;
      this.trendLine.Location = new System.Drawing.Point(148, 73);
      this.trendLine.Name = "trendLine";
      this.trendLine.Size = new System.Drawing.Size(77, 17);
      this.trendLine.TabIndex = 7;
      this.trendLine.Text = "Trend Line";
      this.trendLine.UseVisualStyleBackColor = true;
      this.trendLine.CheckedChanged += new System.EventHandler(this.trendLine_CheckedChanged);
      // 
      // confidenceInterval
      // 
      this.confidenceInterval.AutoSize = true;
      this.confidenceInterval.Location = new System.Drawing.Point(10, 73);
      this.confidenceInterval.Name = "confidenceInterval";
      this.confidenceInterval.Size = new System.Drawing.Size(118, 17);
      this.confidenceInterval.TabIndex = 6;
      this.confidenceInterval.Text = "Confidence Interval";
      this.confidenceInterval.UseVisualStyleBackColor = true;
      this.confidenceInterval.CheckedChanged += new System.EventHandler(this.confidenceInterval_CheckedChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(156, 17);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Element Size";
      // 
      // elementSizeTrack
      // 
      this.elementSizeTrack.Enabled = false;
      this.elementSizeTrack.Location = new System.Drawing.Point(147, 33);
      this.elementSizeTrack.Maximum = 70;
      this.elementSizeTrack.Minimum = 10;
      this.elementSizeTrack.Name = "elementSizeTrack";
      this.elementSizeTrack.Size = new System.Drawing.Size(163, 45);
      this.elementSizeTrack.SmallChange = 5;
      this.elementSizeTrack.TabIndex = 4;
      this.elementSizeTrack.TickFrequency = 5;
      this.elementSizeTrack.Value = 20;
      this.elementSizeTrack.Scroll += new System.EventHandler(this.elementSizeTrack_Scroll);
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
      this.graphDesign.SelectedIndexChanged += new System.EventHandler(this.graphDesign_SelectedIndexChanged);
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
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.modelSelect);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Location = new System.Drawing.Point(540, 27);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(149, 106);
      this.groupBox3.TabIndex = 10;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Analytics";
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
      this.modelSelect.Location = new System.Drawing.Point(6, 33);
      this.modelSelect.Name = "modelSelect";
      this.modelSelect.Size = new System.Drawing.Size(135, 21);
      this.modelSelect.TabIndex = 2;
      this.modelSelect.SelectedIndexChanged += new System.EventHandler(this.modelSelect_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(6, 17);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(36, 13);
      this.label5.TabIndex = 3;
      this.label5.Text = "Model";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.titleText);
      this.groupBox4.Controls.Add(this.label8);
      this.groupBox4.Controls.Add(this.xLabel);
      this.groupBox4.Controls.Add(this.label7);
      this.groupBox4.Controls.Add(this.yLabel);
      this.groupBox4.Controls.Add(this.label6);
      this.groupBox4.Location = new System.Drawing.Point(695, 27);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(302, 106);
      this.groupBox4.TabIndex = 11;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Aesthetics";
      // 
      // titleText
      // 
      this.titleText.Location = new System.Drawing.Point(159, 34);
      this.titleText.Name = "titleText";
      this.titleText.Size = new System.Drawing.Size(137, 20);
      this.titleText.TabIndex = 8;
      this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(156, 18);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(27, 13);
      this.label8.TabIndex = 7;
      this.label8.Text = "Title";
      // 
      // xLabel
      // 
      this.xLabel.Location = new System.Drawing.Point(9, 73);
      this.xLabel.Name = "xLabel";
      this.xLabel.Size = new System.Drawing.Size(144, 20);
      this.xLabel.TabIndex = 6;
      this.xLabel.TextChanged += new System.EventHandler(this.yLabel_TextChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(6, 57);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(43, 13);
      this.label7.TabIndex = 5;
      this.label7.Text = "X Label";
      // 
      // yLabel
      // 
      this.yLabel.Location = new System.Drawing.Point(9, 33);
      this.yLabel.Name = "yLabel";
      this.yLabel.Size = new System.Drawing.Size(144, 20);
      this.yLabel.TabIndex = 4;
      this.yLabel.TextChanged += new System.EventHandler(this.xLabel_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(6, 17);
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1009, 705);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.graphTarget);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(1025, 743);
      this.Name = "Form1";
      this.Text = "Conduct-R";
      this.ResizeEnd += new System.EventHandler(this.ResizeRedraw);
      ((System.ComponentModel.ISupportInitialize)(this.graphTarget)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.elementSizeTrack)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox graphTarget;
    private System.Windows.Forms.ComboBox dataFrameHeader1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openDataframeDialog;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox graphDesign;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TrackBar elementSizeTrack;
    private System.Windows.Forms.CheckBox confidenceInterval;
    private System.Windows.Forms.CheckBox trendLine;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.ComboBox modelSelect;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox dataFrameHeader2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.TextBox xLabel;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox yLabel;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.TextBox titleText;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.SaveFileDialog saveImageDialog;
  }
}

