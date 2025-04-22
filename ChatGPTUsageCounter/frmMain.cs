// frmMain.cs
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChatGPTUsageCounter
{
    public partial class frmMain : Form
    {
        private const int LIMIT = 50;
        private const string XML_FILE = "data.xml";

        // ChatGPT Premium 每周次數
        private int o1Count;
        // ChatGPT mini‑high 每日次數
        private int miniHighCount;

        // ChatGPT Premium 重置設定（從 XML 讀取）：每周（星期、時、分）
        private int o1ResetDay;    // 0～6（0 表示星期日）
        private int o1ResetHour;
        private int o1ResetMinute;

        // ChatGPT mini‑high 重置設定（從 XML 讀取）：每日（僅時、分）
        private int miniHighResetHour;
        private int miniHighResetMinute;

        // 記錄上一次程序關閉的時間
        private DateTime? lastClosedTime;

        public frmMain()
        {
            InitializeComponent();

            // 窗體屬性：居中、固定大小，不允許最大化
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // 讀取 XML 資料（若不存在則建立預設 XML）
            LoadXmlData();

            // 更新介面提示：顯示各自設定的重置時間
            UpdateResetInfoLabels();

            // 啟動時依據 LastClosedTime 判斷是否需要重置（分別檢查兩項）
            CheckResetOnStart();

            // 更新顯示剩餘次數
            lblO1Count.Text = o1Count.ToString();
            lblMiniHighCount.Text = miniHighCount.ToString();

            // 啟動 timer，每分鐘檢查一次重置條件
            timerReset.Interval = 60000;
            timerReset.Tick += TimerReset_Tick;
            timerReset.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            lastClosedTime = DateTime.Now;
            SaveXmlData();
            base.OnFormClosing(e);
        }

        private void UpdateResetInfoLabels()
        {
            // ChatGPT Premium 為每周重置
            string[] weekDays = { "日", "一", "二", "三", "四", "五", "六" };
            lblInfoO1.Text = $"每周重置 (Premium)：星期{weekDays[o1ResetDay]} {o1ResetHour:D2}:{o1ResetMinute:D2}";

            // ChatGPT mini‑high 為每日重置
            lblInfoMiniHigh.Text = $"每日重置 (mini‑high)：{miniHighResetHour:D2}:{miniHighResetMinute:D2}";
        }

        private void LoadXmlData()
        {
            if (!File.Exists(XML_FILE))
            {
                CreateDefaultXml();
            }
            try
            {
                XDocument xdoc = XDocument.Load(XML_FILE);
                XElement root = xdoc.Element("UsageData");

                // 讀取 ChatGPT Premium 重置設定（每周）
                XElement o1Config = root.Element("WeeklyConfigO1");
                o1ResetDay = int.Parse(o1Config.Element("ResetDay").Value);
                o1ResetHour = int.Parse(o1Config.Element("ResetHour").Value);
                o1ResetMinute = int.Parse(o1Config.Element("ResetMinute").Value);

                // 讀取 ChatGPT mini‑high 重置設定（每日設定）
                XElement miniHighConfig = root.Element("DailyConfigMiniHigh");
                miniHighResetHour = int.Parse(miniHighConfig.Element("ResetHour").Value);
                miniHighResetMinute = int.Parse(miniHighConfig.Element("ResetMinute").Value);

                // 讀取 History（LastClosedTime）
                XElement history = root.Element("History");
                string lastClosedStr = history.Element("LastClosedTime").Value;
                lastClosedTime = string.IsNullOrWhiteSpace(lastClosedStr)
                    ? (DateTime?)null
                    : DateTime.Parse(lastClosedStr);

                // 讀取 Counts（Premium 與 mini‑high）
                XElement counts = root.Element("Counts");
                o1Count = int.Parse(counts.Element("WeeklyO1").Attribute("value").Value);
                miniHighCount = int.Parse(counts.Element("MiniHigh").Attribute("value").Value);
            }
            catch
            {
                MessageBox.Show("讀取 XML 資料失敗，將重新建立預設值。");
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
                        new XElement("WeeklyO1", new XAttribute("value", LIMIT)),
                        new XElement("MiniHigh", new XAttribute("value", LIMIT))
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
                        new XElement("LastClosedTime", lastClosedTime.HasValue
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

        private void CheckResetOnStart()
        {
            DateTime now = DateTime.Now;
            bool updated = false;
            if (lastClosedTime.HasValue)
            {
                // Premium 重置檢查（每周）
                DateTime sunday = now.Date.AddDays(-(int)now.DayOfWeek);
                DateTime targetO1 = sunday.AddDays(o1ResetDay)
                    .AddHours(o1ResetHour)
                    .AddMinutes(o1ResetMinute);
                if (targetO1 > now)
                    targetO1 = targetO1.AddDays(-7);
                if (now >= targetO1 && lastClosedTime.Value < targetO1)
                {
                    o1Count = LIMIT;
                    updated = true;
                }

                // mini‑high 重置檢查（每日）
                DateTime targetMiniHigh = now.Date
                    .AddHours(miniHighResetHour)
                    .AddMinutes(miniHighResetMinute);
                if (now >= targetMiniHigh && lastClosedTime.Value < targetMiniHigh)
                {
                    miniHighCount = LIMIT;
                    updated = true;
                }
            }
            if (updated)
            {
                SaveXmlData();
            }
        }

        private void TimerReset_Tick(object sender, EventArgs e)
        {
            CheckResetOnStart();
            lblO1Count.Text = o1Count.ToString();
            lblMiniHighCount.Text = miniHighCount.ToString();
        }

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
                MessageBox.Show("ChatGPT mini‑high 次數已用完！");
            }
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            frmEditXML frmEdit = new frmEditXML();
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                LoadXmlData();
                UpdateResetInfoLabels();
                lblO1Count.Text = o1Count.ToString();
                lblMiniHighCount.Text = miniHighCount.ToString();
            }
        }
    }
}
