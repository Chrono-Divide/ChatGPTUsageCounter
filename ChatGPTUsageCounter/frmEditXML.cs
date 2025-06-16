// frmEditXML.cs  -- C# ≤7.3 兼容版
using System;
using System.Globalization;
using System.IO;
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
            LoadCurrentValues();
        }

        private void LoadCurrentValues()
        {
            if (!File.Exists(XML_FILE))
                return;

            try
            {
                XDocument xdoc = XDocument.Load(XML_FILE);
                XElement root = xdoc.Element("UsageData");

                // Premium (weekly)
                XElement o1Cfg = root.Element("WeeklyConfigO1");
                int resetDay = int.Parse(o1Cfg.Element("ResetDay").Value);
                int resetHour = int.Parse(o1Cfg.Element("ResetHour").Value);
                int resetMinute = int.Parse(o1Cfg.Element("ResetMinute").Value);

                DateTime today = DateTime.Today;
                // 将当天移到最近的指定星期几
                int delta = (resetDay - (int)today.DayOfWeek + 7) % 7;
                DateTime next = today.AddDays(delta)
                                     .AddHours(resetHour)
                                     .AddMinutes(resetMinute);

                dtpWeeklyReset.Value = next;

                // mini-high (daily)
                XElement mhCfg = root.Element("DailyConfigMiniHigh");
                nudMhHour.Value = decimal.Parse(mhCfg.Element("ResetHour").Value);
                nudMhMinute.Value = decimal.Parse(mhCfg.Element("ResetMinute").Value);
            }
            catch
            {
                MessageBox.Show("讀取 XML 設定失敗，請檢查檔案內容。");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists(XML_FILE))
            {
                MessageBox.Show("缺少 data.xml，請先在主視窗運行一次再重試。");
                return;
            }

            try
            {
                XDocument xdoc = XDocument.Load(XML_FILE);
                XElement root = xdoc.Element("UsageData");

                // Premium 每周
                DateTime dt = dtpWeeklyReset.Value;
                XElement o1Cfg = root.Element("WeeklyConfigO1");
                o1Cfg.Element("ResetDay").Value = ((int)dt.DayOfWeek).ToString();
                o1Cfg.Element("ResetHour").Value = dt.Hour.ToString();
                o1Cfg.Element("ResetMinute").Value = dt.Minute.ToString();

                // mini-high 每日
                XElement mhCfg = root.Element("DailyConfigMiniHigh");
                mhCfg.Element("ResetHour").Value = ((int)nudMhHour.Value).ToString();
                mhCfg.Element("ResetMinute").Value = ((int)nudMhMinute.Value).ToString();

                xdoc.Save(XML_FILE);
                MessageBox.Show("設定已儲存！");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("寫入失敗：" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
