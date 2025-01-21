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

                // 讀取 WeeklyConfig
                XElement weeklyConfig = root.Element("WeeklyConfig");
                int resetDay = int.Parse(weeklyConfig.Element("ResetDay").Value);
                int resetHour = int.Parse(weeklyConfig.Element("ResetHour").Value);
                int resetMinute = int.Parse(weeklyConfig.Element("ResetMinute").Value);
                // 設定控制項
                nudWeeklyDay.Value = resetDay;
                nudWeeklyHour.Value = resetHour;
                nudWeeklyMinute.Value = resetMinute;

                // 讀取 DailyConfig
                XElement dailyConfig = root.Element("DailyConfig");
                int dHour = int.Parse(dailyConfig.Element("ResetHour").Value);
                int dMinute = int.Parse(dailyConfig.Element("ResetMinute").Value);
                nudDailyHour.Value = dHour;
                nudDailyMinute.Value = dMinute;
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

                // 更新 WeeklyConfig
                XElement weeklyConfig = root.Element("WeeklyConfig");
                weeklyConfig.Element("ResetDay").Value = nudWeeklyDay.Value.ToString();
                weeklyConfig.Element("ResetHour").Value = nudWeeklyHour.Value.ToString();
                weeklyConfig.Element("ResetMinute").Value = nudWeeklyMinute.Value.ToString();

                // 更新 DailyConfig
                XElement dailyConfig = root.Element("DailyConfig");
                dailyConfig.Element("ResetHour").Value = nudDailyHour.Value.ToString();
                dailyConfig.Element("ResetMinute").Value = nudDailyMinute.Value.ToString();

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
