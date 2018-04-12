namespace SoftwareTrigger
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSoftwareTrigger = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnDetect = new System.Windows.Forms.Button();
            this.btnShowImg = new System.Windows.Forms.Button();
            this.hWindowCtrl = new HalconDotNet.HWindowControl();
            this.menuStripSet = new System.Windows.Forms.MenuStrip();
            this.ToolStripSet = new System.Windows.Forms.ToolStripMenuItem();
            this.chkboxMode = new System.Windows.Forms.CheckBox();
            this.groupBoxParamSetting = new System.Windows.Forms.GroupBox();
            this.numericUDDynamicRange = new System.Windows.Forms.NumericUpDown();
            this.trackBarDynamicRange = new System.Windows.Forms.TrackBar();
            this.numericUDFilterSize = new System.Windows.Forms.NumericUpDown();
            this.trackBarFilterSize = new System.Windows.Forms.TrackBar();
            this.numericUDMinArea = new System.Windows.Forms.NumericUpDown();
            this.trackBarMinArea = new System.Windows.Forms.TrackBar();
            this.numericUDGrayThreshold = new System.Windows.Forms.NumericUpDown();
            this.trackBarGrayThreshold = new System.Windows.Forms.TrackBar();
            this.labelDynamicRange = new System.Windows.Forms.Label();
            this.labelFilterSize = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelGrayThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.menuStripSet.SuspendLayout();
            this.groupBoxParamSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDDynamicRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDynamicRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDFilterSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFilterSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDMinArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDGrayThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrayThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(17, 96);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(1001, 620);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOpen.Location = new System.Drawing.Point(235, 28);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 46);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "打开相机";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(888, 36);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭相机";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSoftwareTrigger
            // 
            this.btnSoftwareTrigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSoftwareTrigger.Location = new System.Drawing.Point(407, 29);
            this.btnSoftwareTrigger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoftwareTrigger.Name = "btnSoftwareTrigger";
            this.btnSoftwareTrigger.Size = new System.Drawing.Size(83, 46);
            this.btnSoftwareTrigger.TabIndex = 3;
            this.btnSoftwareTrigger.Text = "采集图像";
            this.btnSoftwareTrigger.UseVisualStyleBackColor = false;
            this.btnSoftwareTrigger.Click += new System.EventHandler(this.btnSoftwareTrigger_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(103, 29);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 41);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "OK";
            // 
            // btnDetect
            // 
            this.btnDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDetect.Location = new System.Drawing.Point(579, 28);
            this.btnDetect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(83, 46);
            this.btnDetect.TabIndex = 5;
            this.btnDetect.Text = "检测";
            this.btnDetect.UseVisualStyleBackColor = false;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // btnShowImg
            // 
            this.btnShowImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowImg.Location = new System.Drawing.Point(745, 28);
            this.btnShowImg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowImg.Name = "btnShowImg";
            this.btnShowImg.Size = new System.Drawing.Size(83, 46);
            this.btnShowImg.TabIndex = 6;
            this.btnShowImg.Text = "显示原图";
            this.btnShowImg.UseVisualStyleBackColor = false;
            this.btnShowImg.Click += new System.EventHandler(this.btnShowImg_Click);
            // 
            // hWindowCtrl
            // 
            this.hWindowCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hWindowCtrl.BackColor = System.Drawing.Color.Black;
            this.hWindowCtrl.BorderColor = System.Drawing.Color.Black;
            this.hWindowCtrl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowCtrl.Location = new System.Drawing.Point(17, 96);
            this.hWindowCtrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hWindowCtrl.Name = "hWindowCtrl";
            this.hWindowCtrl.Size = new System.Drawing.Size(1001, 619);
            this.hWindowCtrl.TabIndex = 9;
            this.hWindowCtrl.WindowSize = new System.Drawing.Size(1001, 619);
            // 
            // menuStripSet
            // 
            this.menuStripSet.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripSet});
            this.menuStripSet.Location = new System.Drawing.Point(0, 0);
            this.menuStripSet.Name = "menuStripSet";
            this.menuStripSet.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripSet.Size = new System.Drawing.Size(1372, 28);
            this.menuStripSet.TabIndex = 10;
            this.menuStripSet.Text = "menuStrip1";
            // 
            // ToolStripSet
            // 
            this.ToolStripSet.Name = "ToolStripSet";
            this.ToolStripSet.Size = new System.Drawing.Size(51, 24);
            this.ToolStripSet.Text = "设置";
            this.ToolStripSet.Click += new System.EventHandler(this.ToolStripSet_Click);
            // 
            // chkboxMode
            // 
            this.chkboxMode.AutoSize = true;
            this.chkboxMode.Location = new System.Drawing.Point(888, 72);
            this.chkboxMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkboxMode.Name = "chkboxMode";
            this.chkboxMode.Size = new System.Drawing.Size(89, 19);
            this.chkboxMode.TabIndex = 11;
            this.chkboxMode.Text = "录像模式";
            this.chkboxMode.UseVisualStyleBackColor = true;
            this.chkboxMode.CheckedChanged += new System.EventHandler(this.chkboxMode_CheckedChanged);
            // 
            // groupBoxParamSetting
            // 
            this.groupBoxParamSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParamSetting.Controls.Add(this.numericUDDynamicRange);
            this.groupBoxParamSetting.Controls.Add(this.trackBarDynamicRange);
            this.groupBoxParamSetting.Controls.Add(this.numericUDFilterSize);
            this.groupBoxParamSetting.Controls.Add(this.trackBarFilterSize);
            this.groupBoxParamSetting.Controls.Add(this.numericUDMinArea);
            this.groupBoxParamSetting.Controls.Add(this.trackBarMinArea);
            this.groupBoxParamSetting.Controls.Add(this.numericUDGrayThreshold);
            this.groupBoxParamSetting.Controls.Add(this.trackBarGrayThreshold);
            this.groupBoxParamSetting.Controls.Add(this.labelDynamicRange);
            this.groupBoxParamSetting.Controls.Add(this.labelFilterSize);
            this.groupBoxParamSetting.Controls.Add(this.labelMinArea);
            this.groupBoxParamSetting.Controls.Add(this.labelGrayThreshold);
            this.groupBoxParamSetting.Location = new System.Drawing.Point(1021, 96);
            this.groupBoxParamSetting.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxParamSetting.Name = "groupBoxParamSetting";
            this.groupBoxParamSetting.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBoxParamSetting.Size = new System.Drawing.Size(352, 352);
            this.groupBoxParamSetting.TabIndex = 12;
            this.groupBoxParamSetting.TabStop = false;
            this.groupBoxParamSetting.Text = "检测参数设置";
            // 
            // numericUDDynamicRange
            // 
            this.numericUDDynamicRange.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUDDynamicRange.Location = new System.Drawing.Point(269, 290);
            this.numericUDDynamicRange.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUDDynamicRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUDDynamicRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDDynamicRange.Name = "numericUDDynamicRange";
            this.numericUDDynamicRange.Size = new System.Drawing.Size(79, 25);
            this.numericUDDynamicRange.TabIndex = 11;
            this.numericUDDynamicRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUDDynamicRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDDynamicRange.ValueChanged += new System.EventHandler(this.numericUD_ValueChanged);
            this.numericUDDynamicRange.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUD_KeyDown);
            this.numericUDDynamicRange.Leave += new System.EventHandler(this.numericUD_Leave);
            // 
            // trackBarDynamicRange
            // 
            this.trackBarDynamicRange.Location = new System.Drawing.Point(8, 282);
            this.trackBarDynamicRange.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackBarDynamicRange.Maximum = 50;
            this.trackBarDynamicRange.Minimum = 1;
            this.trackBarDynamicRange.Name = "trackBarDynamicRange";
            this.trackBarDynamicRange.Size = new System.Drawing.Size(265, 56);
            this.trackBarDynamicRange.TabIndex = 10;
            this.trackBarDynamicRange.TickFrequency = 2;
            this.trackBarDynamicRange.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarDynamicRange.Value = 1;
            this.trackBarDynamicRange.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBarDynamicRange.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarDynamicRange.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // numericUDFilterSize
            // 
            this.numericUDFilterSize.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUDFilterSize.Location = new System.Drawing.Point(269, 205);
            this.numericUDFilterSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUDFilterSize.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUDFilterSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDFilterSize.Name = "numericUDFilterSize";
            this.numericUDFilterSize.Size = new System.Drawing.Size(79, 25);
            this.numericUDFilterSize.TabIndex = 9;
            this.numericUDFilterSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUDFilterSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDFilterSize.ValueChanged += new System.EventHandler(this.numericUD_ValueChanged);
            this.numericUDFilterSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUD_KeyDown);
            this.numericUDFilterSize.Leave += new System.EventHandler(this.numericUD_Leave);
            // 
            // trackBarFilterSize
            // 
            this.trackBarFilterSize.Location = new System.Drawing.Point(8, 198);
            this.trackBarFilterSize.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackBarFilterSize.Maximum = 120;
            this.trackBarFilterSize.Minimum = 1;
            this.trackBarFilterSize.Name = "trackBarFilterSize";
            this.trackBarFilterSize.Size = new System.Drawing.Size(265, 56);
            this.trackBarFilterSize.TabIndex = 8;
            this.trackBarFilterSize.TickFrequency = 5;
            this.trackBarFilterSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarFilterSize.Value = 1;
            this.trackBarFilterSize.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBarFilterSize.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarFilterSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // numericUDMinArea
            // 
            this.numericUDMinArea.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUDMinArea.Location = new System.Drawing.Point(269, 132);
            this.numericUDMinArea.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUDMinArea.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUDMinArea.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDMinArea.Name = "numericUDMinArea";
            this.numericUDMinArea.Size = new System.Drawing.Size(79, 25);
            this.numericUDMinArea.TabIndex = 7;
            this.numericUDMinArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUDMinArea.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDMinArea.ValueChanged += new System.EventHandler(this.numericUD_ValueChanged);
            this.numericUDMinArea.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUD_KeyDown);
            this.numericUDMinArea.Leave += new System.EventHandler(this.numericUD_Leave);
            // 
            // trackBarMinArea
            // 
            this.trackBarMinArea.Location = new System.Drawing.Point(8, 122);
            this.trackBarMinArea.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackBarMinArea.Maximum = 5000;
            this.trackBarMinArea.Minimum = 1;
            this.trackBarMinArea.Name = "trackBarMinArea";
            this.trackBarMinArea.Size = new System.Drawing.Size(265, 56);
            this.trackBarMinArea.TabIndex = 6;
            this.trackBarMinArea.TickFrequency = 200;
            this.trackBarMinArea.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMinArea.Value = 1;
            this.trackBarMinArea.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBarMinArea.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarMinArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // numericUDGrayThreshold
            // 
            this.numericUDGrayThreshold.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUDGrayThreshold.Location = new System.Drawing.Point(269, 60);
            this.numericUDGrayThreshold.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.numericUDGrayThreshold.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUDGrayThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDGrayThreshold.Name = "numericUDGrayThreshold";
            this.numericUDGrayThreshold.Size = new System.Drawing.Size(79, 25);
            this.numericUDGrayThreshold.TabIndex = 5;
            this.numericUDGrayThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUDGrayThreshold.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUDGrayThreshold.ValueChanged += new System.EventHandler(this.numericUD_ValueChanged);
            this.numericUDGrayThreshold.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericUD_KeyDown);
            this.numericUDGrayThreshold.Leave += new System.EventHandler(this.numericUD_Leave);
            // 
            // trackBarGrayThreshold
            // 
            this.trackBarGrayThreshold.Location = new System.Drawing.Point(8, 50);
            this.trackBarGrayThreshold.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.trackBarGrayThreshold.Maximum = 200;
            this.trackBarGrayThreshold.Minimum = 1;
            this.trackBarGrayThreshold.Name = "trackBarGrayThreshold";
            this.trackBarGrayThreshold.Size = new System.Drawing.Size(265, 56);
            this.trackBarGrayThreshold.TabIndex = 4;
            this.trackBarGrayThreshold.TickFrequency = 10;
            this.trackBarGrayThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGrayThreshold.Value = 1;
            this.trackBarGrayThreshold.Scroll += new System.EventHandler(this.trackBar_Scroll);
            this.trackBarGrayThreshold.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBarGrayThreshold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseUp);
            // 
            // labelDynamicRange
            // 
            this.labelDynamicRange.AutoSize = true;
            this.labelDynamicRange.Location = new System.Drawing.Point(8, 252);
            this.labelDynamicRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDynamicRange.Name = "labelDynamicRange";
            this.labelDynamicRange.Size = new System.Drawing.Size(112, 15);
            this.labelDynamicRange.TabIndex = 3;
            this.labelDynamicRange.Text = "动态二值化阈值";
            // 
            // labelFilterSize
            // 
            this.labelFilterSize.AutoSize = true;
            this.labelFilterSize.Location = new System.Drawing.Point(8, 179);
            this.labelFilterSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterSize.Name = "labelFilterSize";
            this.labelFilterSize.Size = new System.Drawing.Size(67, 15);
            this.labelFilterSize.TabIndex = 2;
            this.labelFilterSize.Text = "滤波尺寸";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(8, 105);
            this.labelMinArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(142, 15);
            this.labelMinArea.TabIndex = 1;
            this.labelMinArea.Text = "缺陷区域面积最小值";
            // 
            // labelGrayThreshold
            // 
            this.labelGrayThreshold.AutoSize = true;
            this.labelGrayThreshold.Location = new System.Drawing.Point(8, 31);
            this.labelGrayThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGrayThreshold.Name = "labelGrayThreshold";
            this.labelGrayThreshold.Size = new System.Drawing.Size(127, 15);
            this.labelGrayThreshold.TabIndex = 0;
            this.labelGrayThreshold.Text = "二值化上限灰度值";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 729);
            this.Controls.Add(this.groupBoxParamSetting);
            this.Controls.Add(this.chkboxMode);
            this.Controls.Add(this.btnShowImg);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSoftwareTrigger);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.menuStripSet);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.hWindowCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripSet;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = " 苏州优维毕-缺陷检测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.menuStripSet.ResumeLayout(false);
            this.menuStripSet.PerformLayout();
            this.groupBoxParamSetting.ResumeLayout(false);
            this.groupBoxParamSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDDynamicRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDynamicRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDFilterSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFilterSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDMinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMinArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDGrayThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGrayThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSoftwareTrigger;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnShowImg;
        private HalconDotNet.HWindowControl hWindowCtrl;
        private System.Windows.Forms.MenuStrip menuStripSet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSet;
        private System.Windows.Forms.CheckBox chkboxMode;
        private System.Windows.Forms.GroupBox groupBoxParamSetting;
        private System.Windows.Forms.NumericUpDown numericUDDynamicRange;
        private System.Windows.Forms.TrackBar trackBarDynamicRange;
        private System.Windows.Forms.NumericUpDown numericUDFilterSize;
        private System.Windows.Forms.TrackBar trackBarFilterSize;
        private System.Windows.Forms.NumericUpDown numericUDMinArea;
        private System.Windows.Forms.TrackBar trackBarMinArea;
        private System.Windows.Forms.NumericUpDown numericUDGrayThreshold;
        private System.Windows.Forms.TrackBar trackBarGrayThreshold;
        private System.Windows.Forms.Label labelDynamicRange;
        private System.Windows.Forms.Label labelFilterSize;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelGrayThreshold;
    }
}

