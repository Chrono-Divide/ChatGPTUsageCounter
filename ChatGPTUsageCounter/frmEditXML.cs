// frmEditXML.cs
using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChatGPTUsageCounter
{
    public partial class frmEditXML : Form
    {
        private const string XML_FILE = "data.xml";

        public frmEditXML()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            LoadSettings();
        }

        private void LoadSettings()
        {
            try
            {
                XDocument xdoc = XDocument.Load(XML_FILE);
                XElement root = xdoc.Element("UsageData");

                // 讀取 ChatGPT Premium 重置設定（每周）
                XElement o1Config = root.Element("WeeklyConfigO1");
                int o1Day = int.Parse(o1Config.Element("ResetDay").Value);
                int o1Hour = int.Parse(o1Config.Element("ResetHour").Value);
                int o1Minute = int.Parse(o1Config.Element("ResetMinute").Value);
                nudO1Day.Value = o1Day;
                nudO1Hour.Value = o1Hour;
                nudO1Minute.Value = o1Minute;

                // 讀取 ChatGPT mini‑high 重置設定（每日，只需時、分）
                XElement miniHighConfig = root.Element("DailyConfigMiniHigh");
                int mhHour = int.Parse(miniHighConfig.Element("ResetHour").Value);
                int mhMinute = int.Parse(miniHighConfig.Element("ResetMinute").Value);
                nudMiniHighHour.Value = mhHour;
                nudMiniHighMinute.Value = mhMinute;
            }
            catch
            {
                MessageBox.Show("讀取 XML 配置時出錯！");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load(XML_FILE);
                XElement root = xdoc.Element("UsageData");

                // 更新 ChatGPT Premium 重置設定（每周）
                XElement o1Config = root.Element("WeeklyConfigO1");
                o1Config.Element("ResetDay").Value = nudO1Day.Value.ToString();
                o1Config.Element("ResetHour").Value = nudO1Hour.Value.ToString();
                o1Config.Element("ResetMinute").Value = nudO1Minute.Value.ToString();

                // 更新 ChatGPT mini‑high 重置設定（每日）
                XElement miniHighConfig = root.Element("DailyConfigMiniHigh");
                miniHighConfig.Element("ResetHour").Value = nudMiniHighHour.Value.ToString();
                miniHighConfig.Element("ResetMinute").Value = nudMiniHighMinute.Value.ToString();

                xdoc.Save(XML_FILE);
                MessageBox.Show("設定已儲存！");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("儲存設定失敗！");
            }
        }
    }
}
