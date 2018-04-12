namespace SoftwareTrigger
{
    partial class FormConfig
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
            this.tabCtrCam = new System.Windows.Forms.TabControl();
            this.tabPgDet = new System.Windows.Forms.TabPage();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.tabPgCam = new System.Windows.Forms.TabPage();
            this.txtGain = new System.Windows.Forms.TextBox();
            this.lblGain = new System.Windows.Forms.Label();
            this.txtExposure = new System.Windows.Forms.TextBox();
            this.lblExposure = new System.Windows.Forms.Label();
            this.folderBrowsePath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxImageSource = new System.Windows.Forms.GroupBox();
            this.radioButtonCameraImage = new System.Windows.Forms.RadioButton();
            this.radioButtonFileImage = new System.Windows.Forms.RadioButton();
            this.tabCtrCam.SuspendLayout();
            this.tabPgDet.SuspendLayout();
            this.tabPgCam.SuspendLayout();
            this.groupBoxImageSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrCam
            // 
            this.tabCtrCam.Controls.Add(this.tabPgDet);
            this.tabCtrCam.Controls.Add(this.tabPgCam);
            this.tabCtrCam.Location = new System.Drawing.Point(9, 10);
            this.tabCtrCam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabCtrCam.Name = "tabCtrCam";
            this.tabCtrCam.SelectedIndex = 0;
            this.tabCtrCam.Size = new System.Drawing.Size(524, 350);
            this.tabCtrCam.TabIndex = 0;
            // 
            // tabPgDet
            // 
            this.tabPgDet.Controls.Add(this.groupBoxImageSource);
            this.tabPgDet.Controls.Add(this.btnSelectPath);
            this.tabPgDet.Controls.Add(this.txtPath);
            this.tabPgDet.Controls.Add(this.lblSavePath);
            this.tabPgDet.Location = new System.Drawing.Point(4, 22);
            this.tabPgDet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPgDet.Name = "tabPgDet";
            this.tabPgDet.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPgDet.Size = new System.Drawing.Size(516, 324);
            this.tabPgDet.TabIndex = 0;
            this.tabPgDet.Text = "检测参数";
            this.tabPgDet.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(413, 42);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(70, 20);
            this.btnSelectPath.TabIndex = 3;
            this.btnSelectPath.Text = "选择路径";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(26, 42);
            this.txtPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(357, 21);
            this.txtPath.TabIndex = 2;
            // 
            // lblSavePath
            // 
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(23, 25);
            this.lblSavePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(77, 12);
            this.lblSavePath.TabIndex = 0;
            this.lblSavePath.Text = "图片保存路径";
            // 
            // tabPgCam
            // 
            this.tabPgCam.Controls.Add(this.txtGain);
            this.tabPgCam.Controls.Add(this.lblGain);
            this.tabPgCam.Controls.Add(this.txtExposure);
            this.tabPgCam.Controls.Add(this.lblExposure);
            this.tabPgCam.Location = new System.Drawing.Point(4, 22);
            this.tabPgCam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPgCam.Name = "tabPgCam";
            this.tabPgCam.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPgCam.Size = new System.Drawing.Size(516, 324);
            this.tabPgCam.TabIndex = 1;
            this.tabPgCam.Text = "相机参数";
            this.tabPgCam.UseVisualStyleBackColor = true;
            // 
            // txtGain
            // 
            this.txtGain.Location = new System.Drawing.Point(188, 80);
            this.txtGain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(76, 21);
            this.txtGain.TabIndex = 3;
            this.txtGain.Text = "1.0";
            this.txtGain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGain
            // 
            this.lblGain.AutoSize = true;
            this.lblGain.Location = new System.Drawing.Point(76, 82);
            this.lblGain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGain.Name = "lblGain";
            this.lblGain.Size = new System.Drawing.Size(53, 12);
            this.lblGain.TabIndex = 2;
            this.lblGain.Text = "相机增益";
            // 
            // txtExposure
            // 
            this.txtExposure.Location = new System.Drawing.Point(188, 46);
            this.txtExposure.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExposure.Name = "txtExposure";
            this.txtExposure.Size = new System.Drawing.Size(76, 21);
            this.txtExposure.TabIndex = 1;
            this.txtExposure.Text = "1800";
            this.txtExposure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblExposure
            // 
            this.lblExposure.AutoSize = true;
            this.lblExposure.Location = new System.Drawing.Point(76, 48);
            this.lblExposure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExposure.Name = "lblExposure";
            this.lblExposure.Size = new System.Drawing.Size(101, 12);
            this.lblExposure.TabIndex = 0;
            this.lblExposure.Text = "曝光时间（毫秒）";
            // 
            // groupBoxImageSource
            // 
            this.groupBoxImageSource.Controls.Add(this.radioButtonFileImage);
            this.groupBoxImageSource.Controls.Add(this.radioButtonCameraImage);
            this.groupBoxImageSource.Location = new System.Drawing.Point(26, 94);
            this.groupBoxImageSource.Name = "groupBoxImageSource";
            this.groupBoxImageSource.Size = new System.Drawing.Size(457, 52);
            this.groupBoxImageSource.TabIndex = 4;
            this.groupBoxImageSource.TabStop = false;
            this.groupBoxImageSource.Text = "图像来源";
            // 
            // radioButtonCameraImage
            // 
            this.radioButtonCameraImage.AutoSize = true;
            this.radioButtonCameraImage.Location = new System.Drawing.Point(27, 21);
            this.radioButtonCameraImage.Name = "radioButtonCameraImage";
            this.radioButtonCameraImage.Size = new System.Drawing.Size(47, 16);
            this.radioButtonCameraImage.TabIndex = 0;
            this.radioButtonCameraImage.TabStop = true;
            this.radioButtonCameraImage.Text = "相机";
            this.radioButtonCameraImage.UseVisualStyleBackColor = true;
            // 
            // radioButtonFileImage
            // 
            this.radioButtonFileImage.AutoSize = true;
            this.radioButtonFileImage.Location = new System.Drawing.Point(131, 20);
            this.radioButtonFileImage.Name = "radioButtonFileImage";
            this.radioButtonFileImage.Size = new System.Drawing.Size(47, 16);
            this.radioButtonFileImage.TabIndex = 1;
            this.radioButtonFileImage.TabStop = true;
            this.radioButtonFileImage.Text = "图片";
            this.radioButtonFileImage.UseVisualStyleBackColor = true;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 369);
            this.Controls.Add(this.tabCtrCam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "参数设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.tabCtrCam.ResumeLayout(false);
            this.tabPgDet.ResumeLayout(false);
            this.tabPgDet.PerformLayout();
            this.tabPgCam.ResumeLayout(false);
            this.tabPgCam.PerformLayout();
            this.groupBoxImageSource.ResumeLayout(false);
            this.groupBoxImageSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrCam;
        private System.Windows.Forms.TabPage tabPgDet;
        private System.Windows.Forms.TabPage tabPgCam;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowsePath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Label lblExposure;
        private System.Windows.Forms.TextBox txtExposure;
        private System.Windows.Forms.TextBox txtGain;
        private System.Windows.Forms.Label lblGain;
        private System.Windows.Forms.GroupBox groupBoxImageSource;
        private System.Windows.Forms.RadioButton radioButtonFileImage;
        private System.Windows.Forms.RadioButton radioButtonCameraImage;
    }
}