using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftwareTrigger
{
    public partial class FormConfig : Form
    {
        /// <summary>
        /// 文件保存路径
        /// </summary>
        public String strSavePath { get; set; }

        /// <summary>
        /// 相机模式
        /// </summary>
        public ImageMode imageMode { get; set; }

        /// <summary>
        /// 相机曝光时间
        /// </summary>
        public Int32 nExpTime { get; set; }

        /// <summary>
        /// 相机增益
        /// </summary>
        public float fCamGain { get; set; }

        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            txtPath.Text = strSavePath;
            if (imageMode == ImageMode.Online)
            {
                radioButtonCameraImage.Checked = true;
            }
            else if (imageMode == ImageMode.Offline)
            {
                radioButtonFileImage.Checked = true;
            }
            txtExposure.Text = nExpTime.ToString();
            txtGain.Text = fCamGain.ToString();
        }

        /* 保存路径按钮事件 */
        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (folderBrowsePath.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowsePath.SelectedPath.Length != 0)
                {
                    txtPath.Text = folderBrowsePath.SelectedPath;
                }
            }
        }

        /* 参数设置窗口关闭事件：将窗口上的变量值传回主窗口对应变量 */
        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            strSavePath = txtPath.Text;
            if (radioButtonCameraImage.Checked==true)
            {
                imageMode = ImageMode.Online;
            }
            else if (radioButtonFileImage.Checked ==true)
            {
                imageMode = ImageMode.Offline;
            }
            nExpTime = int.Parse(txtExposure.Text);
            fCamGain =float.Parse(txtGain.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
