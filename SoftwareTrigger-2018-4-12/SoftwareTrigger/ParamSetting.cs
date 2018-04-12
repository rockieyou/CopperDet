using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SoftwareTrigger
{
    public class ParamSetting
    {
        private const string CONFIGFILENAME = "AppSetting.config";


        private static string _imageSavePath;

        /// <summary>
        /// 图片保存路径
        /// </summary>
        public static string ImageSavePath
        {
            get { return _imageSavePath; }
            set { _imageSavePath = value; }
        }

        private static ImageMode _snapMode = ImageMode.Offline;

        /// <summary>
        /// 采图模式
        /// </summary>
        public static ImageMode SnapMode
        {
            get { return _snapMode; }
            set { _snapMode = value; }
        }


        private static int _exposureTime = 1800;

        /// <summary>
        ///  相机曝光时间
        /// </summary>
        public static int ExposureTime
        {
            get { return _exposureTime; }
            set { _exposureTime = value; }
        }

        /// <summary>
        /// 相机增益
        /// </summary>
        private static float _cameraGain = 1.0f;

        public static float CameraGain
        {
            get { return _cameraGain; }
            set { _cameraGain = value; }
        }

        private static MeasureParameter _measureParam = new MeasureParameter();

        /// <summary>
        /// 检测参数29
        /// </summary>
        public static MeasureParameter MeasureParam
        {
            get { return _measureParam; }
            set { _measureParam = value; }
        }

        public static bool LoadConfig()
        {
            try
            {
                if (File.Exists(Path.Combine(Application.StartupPath, CONFIGFILENAME)))  //文件存在，通过文件加载文件信息
                {
                    XmlDocument doc = new XmlDocument();

                    doc.Load(Path.Combine(Application.StartupPath, CONFIGFILENAME));

                    XmlNode nodeGlobalSetting = doc.SelectSingleNode("/Configuration/GlobalSetting");
                    if (nodeGlobalSetting.Attributes["ImageSavePath"] != null)
                    {
                        string imageSavePath = nodeGlobalSetting.Attributes["ImageSavePath"].Value.ToString();
                        _imageSavePath = string.IsNullOrEmpty(imageSavePath) ? Application.StartupPath : imageSavePath;
                    }
                    if (nodeGlobalSetting.Attributes["SnapMode"] != null)
                    {
                        ImageMode snapMode;
                        if (Enum.TryParse(nodeGlobalSetting.Attributes["SnapMode"].Value.ToString(), out snapMode))
                        {
                            _snapMode = snapMode;
                        }
                    }

                    XmlNode nodeCameraParam = doc.SelectSingleNode("/Configuration/CameraParam");
                    if (nodeCameraParam.Attributes["ExposureTime"] != null)
                    {
                        int exposureTime = 0;
                        if (int.TryParse(nodeCameraParam.Attributes["ExposureTime"].Value.ToString(), out exposureTime))
                        {
                            _exposureTime = exposureTime;
                        }
                    }
                    if (nodeCameraParam.Attributes["CameraGain"] != null)
                    {
                        float cameraGain = 0.0f;
                        if (float.TryParse(nodeCameraParam.Attributes["CameraGain"].Value.ToString(), out cameraGain))
                        {
                            _cameraGain = cameraGain;
                        }
                    }

                    XmlNode nodeMeasureParam = doc.SelectSingleNode("/Configuration/MeasureParam");
                    if (nodeMeasureParam.Attributes["GrayThreshold"] != null)
                    {
                        int grayThreshold = 0;
                        if (int.TryParse(nodeMeasureParam.Attributes["GrayThreshold"].Value.ToString(), out grayThreshold))
                        {
                            _measureParam.GrayThreshold = grayThreshold;
                        }
                    }
                    if (nodeMeasureParam.Attributes["MinArea"] != null)
                    {
                        int minArea = 0;
                        if (int.TryParse(nodeMeasureParam.Attributes["MinArea"].Value.ToString(), out minArea))
                        {
                            _measureParam.MinArea = minArea;
                        }
                    }
                    if (nodeMeasureParam.Attributes["FilterSize"] != null)
                    {
                        int filterSize = 0;
                        if (int.TryParse(nodeMeasureParam.Attributes["FilterSize"].Value.ToString(), out filterSize))
                        {
                            _measureParam.FilterSize = filterSize;
                        }
                    }
                    if (nodeMeasureParam.Attributes["DynamicRange"] != null)
                    {
                        int dynamicRange = 0;
                        if (int.TryParse(nodeMeasureParam.Attributes["DynamicRange"].Value.ToString(), out dynamicRange))
                        {
                            _measureParam.DynamicRange = dynamicRange;
                        }
                    }
                }
                else
                {
                    //文件不存在，使用默认值
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 保存地区设置
        /// </summary>
        public static void SaveConfig()
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(Path.Combine(Application.StartupPath, CONFIGFILENAME), Encoding.UTF8);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartDocument();
                writer.WriteStartElement("Configuration");
                //------------------------
                writer.WriteStartElement("GlobalSetting");
                writer.WriteAttributeString("ImageSavePath", _imageSavePath);
                writer.WriteAttributeString("SnapMode", _snapMode.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("CameraParam");
                writer.WriteAttributeString("ExposureTime", _exposureTime.ToString());
                writer.WriteAttributeString("CameraGain", _cameraGain.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("MeasureParam");
                writer.WriteAttributeString("GrayThreshold", _measureParam.GrayThreshold.ToString());
                writer.WriteAttributeString("MinArea", _measureParam.MinArea.ToString());
                writer.WriteAttributeString("FilterSize", _measureParam.FilterSize.ToString());
                writer.WriteAttributeString("DynamicRange", _measureParam.DynamicRange.ToString());
                writer.WriteEndElement();
                //------------------------
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
            catch
            {
                return;
            }
        }
    }

    public class MeasureParameter
    {
        private int _grayThreshold = 120;

        /// <summary>
        /// 二值化上限灰度值
        /// </summary>
        public int GrayThreshold
        {
            get { return _grayThreshold; }
            set { _grayThreshold = value; }
        }

        private int _minArea = 800;

        /// <summary>
        /// 缺陷区域面积最小值
        /// </summary>
        public int MinArea
        {
            get { return _minArea; }
            set { _minArea = value; }
        }

        private int _filterSize = 60;

        /// <summary>
        /// 滤波尺寸
        /// </summary>
        public int FilterSize
        {
            get { return _filterSize; }
            set { _filterSize = value; }
        }

        private int _dynamicRange = 4;

        /// <summary>
        /// 动态二值化阈值
        /// </summary>
        public int DynamicRange
        {
            get { return _dynamicRange; }
            set { _dynamicRange = value; }
        }
    }

    public enum ImageMode
    {
        Online,
        Offline
    }
}
