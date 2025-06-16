// frmMain.cs  -- C# ≤7.3 兼容版
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChatGPTUsageCounter
{
    public partial class frmMain : Form
    {
        private const int LIMIT_PREMIUM = 100; // ChatGPT Premium 每周可用次數
        private const int LIMIT_MINI_HIGH = 50;  // ChatGPT mini-high 每日可用次數
        private const string XML_FILE = "data.xml";

        // 目前剩餘次數
        private int o1Count;         // Premium
        private int miniHighCount;   // mini-high

        // Premium 每周重置設定
        private int o1ResetDay;      // 0(日)~6(六)
        private int o1ResetHour;
        private int o1ResetMinute;

        // mini-high 每日重置設定
        private int miniHighResetHour;
        private int miniHighResetMinute;

        private DateTime? lastClosedTime;

        public frmMain()
        {
            InitializeComponent();

            this.Text = $"ChatGPT 使用次數統計工具 v{Assembly.GetExecutingAssembly().GetName().Version}";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            LoadXmlData();
            UpdateResetInfoLabels();
            CheckResetOnStart();

            lblO1Count.Text = o1Count.ToString();
            lblMiniHighCount.Text = miniHighCount.ToString();

            timerReset.Interval = 60_000;          // 1 分鐘
            timerReset.Tick += TimerReset_Tick;
            timerReset.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            lastClosedTime = DateTime.Now;
            SaveXmlData();
            base.OnFormClosing(e);
        }

        #region 讀取/儲存 XML 與預設值
        private void LoadXmlData()
        {
            if (!File.Exists(XML_FILE))
                CreateDefaultXml();

            try
            {
                XDocument xdoc = XDocument.Load(XML_FILE);
                XElement root = xdoc.Element("UsageData");

                XElement o1Cfg = root.Element("WeeklyConfigO1");
                o1ResetDay = int.Parse(o1Cfg.Element("ResetDay").Value);
                o1ResetHour = int.Parse(o1Cfg.Element("ResetHour").Value);
                o1ResetMinute = int.Parse(o1Cfg.Element("ResetMinute").Value);

                XElement mhCfg = root.Element("DailyConfigMiniHigh");
                miniHighResetHour = int.Parse(mhCfg.Element("ResetHour").Value);
                miniHighResetMinute = int.Parse(mhCfg.Element("ResetMinute").Value);

                XElement history = root.Element("History");
                string lastStr = history.Element("LastClosedTime").Value;

                // ↓↓↓ 改寫：避免三元運算直接回傳 null (C# 7.3 以前不允許推斷)
                if (string.IsNullOrWhiteSpace(lastStr))
                    lastClosedTime = null;
                else
                    lastClosedTime = DateTime.Parse(lastStr);
                // ↑↑↑

                XElement counts = root.Element("Counts");
                o1Count = int.Parse(counts.Element("WeeklyO1").Attribute("value").Value);
                miniHighCount = int.Parse(counts.Element("MiniHigh").Attribute("value").Value);
            }
            catch
            {
                MessageBox.Show("讀取 XML 資料失敗，已重新初始化。");
                CreateDefaultXml();
                LoadXmlData();
            }
        }

        private void CreateDefaultXml()
        {
            XDocument xdoc = new XDocument(
                new XElement("UsageData",
                    new XElement("WeeklyConfigO1",
                        new XElement("ResetDay", 2),
                        new XElement("ResetHour", 15),
                        new XElement("ResetMinute", 29)
                    ),
                    new XElement("DailyConfigMiniHigh",
                        new XElement("ResetHour", 10),
                        new XElement("ResetMinute", 0)
                    ),
                    new XElement("History",
                        new XElement("LastClosedTime", "")
                    ),
                    new XElement("Counts",
                        new XElement("WeeklyO1", new XAttribute("value", LIMIT_PREMIUM)),
                        new XElement("MiniHigh", new XAttribute("value", LIMIT_MINI_HIGH))
                    )
                )
            );
            xdoc.Save(XML_FILE);
        }

        private void SaveXmlData()
        {
            XDocument xdoc = new XDocument(
                new XElement("UsageData",
                    new XElement("WeeklyConfigO1",
                        new XElement("ResetDay", o1ResetDay),
                        new XElement("ResetHour", o1ResetHour),
                        new XElement("ResetMinute", o1ResetMinute)
                    ),
                    new XElement("DailyConfigMiniHigh",
                        new XElement("ResetHour", miniHighResetHour),
                        new XElement("ResetMinute", miniHighResetMinute)
                    ),
                    new XElement("History",
                        new XElement("LastClosedTime",
                            lastClosedTime.HasValue
                                ? lastClosedTime.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                                : "")
                    ),
                    new XElement("Counts",
                        new XElement("WeeklyO1", new XAttribute("value", o1Count)),
                        new XElement("MiniHigh", new XAttribute("value", miniHighCount))
                    )
                )
            );
            xdoc.Save(XML_FILE);
        }
        #endregion

        #region 重置檢查
        private void UpdateResetInfoLabels()
        {
            string[] weekDays = { "日", "一", "二", "三", "四", "五", "六" };
            lblInfoO1.Text = $"每周重置 (Premium)：星期{weekDays[o1ResetDay]} {o1ResetHour:D2}:{o1ResetMinute:D2}";
            lblInfoMiniHigh.Text = $"每日重置 (mini-high)：{miniHighResetHour:D2}:{miniHighResetMinute:D2}";
        }

        private void CheckResetOnStart()
        {
            DateTime now = DateTime.Now;
            bool updated = false;

            if (lastClosedTime.HasValue)
            {
                // Premium：每周
                DateTime sunday = now.Date.AddDays(-(int)now.DayOfWeek);
                DateTime targetO1 = sunday.AddDays(o1ResetDay)
                                           .AddHours(o1ResetHour)
                                           .AddMinutes(o1ResetMinute);
                if (targetO1 > now) targetO1 = targetO1.AddDays(-7);

                if (now >= targetO1 && lastClosedTime.Value < targetO1)
                {
                    o1Count = LIMIT_PREMIUM;
                    updated = true;
                }

                // mini-high：每日
                DateTime targetMh = now.Date.AddHours(miniHighResetHour)
                                            .AddMinutes(miniHighResetMinute);
                if (now >= targetMh && lastClosedTime.Value < targetMh)
                {
                    miniHighCount = LIMIT_MINI_HIGH;
                    updated = true;
                }
            }

            if (updated)
                SaveXmlData();
        }

        private void TimerReset_Tick(object sender, EventArgs e)
        {
            CheckResetOnStart();
            lblO1Count.Text = o1Count.ToString();
            lblMiniHighCount.Text = miniHighCount.ToString();
        }
        #endregion

        #region 按鈕事件
        private void btnO1Build_Click(object sender, EventArgs e)
        {
            if (o1Count > 0)
            {
                o1Count--;
                SaveXmlData();
                lblO1Count.Text = o1Count.ToString();
            }
            else
            {
                MessageBox.Show("ChatGPT Premium 次數已用完！");
            }
        }

        private void btnMiniHighBuild_Click(object sender, EventArgs e)
        {
            if (miniHighCount > 0)
            {
                miniHighCount--;
                SaveXmlData();
                lblMiniHighCount.Text = miniHighCount.ToString();
            }
            else
            {
                MessageBox.Show("ChatGPT mini-high 次數已用完！");
            }
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            // ↓↓↓ 改寫：使用傳統 using (…) 區塊
            using (var frmEdit = new frmEditXML())
            {
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    LoadXmlData();
                    UpdateResetInfoLabels();
                    lblO1Count.Text = o1Count.ToString();
                    lblMiniHighCount.Text = miniHighCount.ToString();
                }
            }
            // ↑↑↑
        }
        #endregion
    }
}
