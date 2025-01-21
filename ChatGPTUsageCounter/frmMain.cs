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

        // 剩餘次數（僅一個值，各自存 weekly 與 daily）
        private int weeklyCount;
        private int dailyCount;

        // 配置：每周、每日重置設定（從 XML 讀取）
        private int weeklyResetDay;    // 0～6（0 表示星期日）
        private int weeklyResetHour;
        private int weeklyResetMinute;
        private int dailyResetHour;
        private int dailyResetMinute;

        // 歷史記錄：僅記錄上一次程序關閉的時間
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

            // 更新介面提示：顯示設定的重置時間
            UpdateResetInfoLabels();

            // 啟動時依據 LastClosedTime 判斷是否需要重置
            CheckResetOnStart();

            // 更新顯示剩餘次數
            lblWeeklyCount.Text = weeklyCount.ToString();
            lblDailyCount.Text = dailyCount.ToString();

            // 啟動 timer，每分鐘檢查一次重置條件
            timerReset.Interval = 60000;
            timerReset.Tick += TimerReset_Tick;
            timerReset.Start();
        }

        /// <summary>
        /// 程序關閉時，記錄關閉時間到 XML
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            lastClosedTime = DateTime.Now;
            SaveXmlData();
            base.OnFormClosing(e);
        }

        /// <summary>
        /// 更新介面下方提示資訊標籤，以顯示 XML 中的重置設定
        /// </summary>
        private void UpdateResetInfoLabels()
        {
            // 將星期數轉換為中文表示（0=日, 1=一, ...）
            string[] weekDays = { "日", "一", "二", "三", "四", "五", "六" };
            lblInfoWeekly.Text = $"每周重置：星期{weekDays[weeklyResetDay]} {weeklyResetHour:D2}:{weeklyResetMinute:D2}";
            lblInfoDaily.Text = $"每日重置：{dailyResetHour:D2}:{dailyResetMinute:D2}";
        }

        /// <summary>
        /// 從 XML 讀取資料，若 XML 不存在則創建預設 XML
        /// </summary>
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

                // 讀取 WeeklyConfig
                XElement weeklyConfig = root.Element("WeeklyConfig");
                weeklyResetDay = int.Parse(weeklyConfig.Element("ResetDay").Value);
                weeklyResetHour = int.Parse(weeklyConfig.Element("ResetHour").Value);
                weeklyResetMinute = int.Parse(weeklyConfig.Element("ResetMinute").Value);

                // 讀取 DailyConfig
                XElement dailyConfig = root.Element("DailyConfig");
                dailyResetHour = int.Parse(dailyConfig.Element("ResetHour").Value);
                dailyResetMinute = int.Parse(dailyConfig.Element("ResetMinute").Value);

                // 讀取 History（LastClosedTime）
                XElement history = root.Element("History");
                string lastClosedStr = history.Element("LastClosedTime").Value;
                lastClosedTime = string.IsNullOrWhiteSpace(lastClosedStr) ? (DateTime?)null : DateTime.Parse(lastClosedStr);

                // 讀取 Counts
                XElement counts = root.Element("Counts");
                weeklyCount = int.Parse(counts.Element("Weekly").Attribute("value").Value);
                dailyCount = int.Parse(counts.Element("Daily").Attribute("value").Value);
            }
            catch
            {
                MessageBox.Show("讀取 XML 資料失敗，將重新建立預設值。");
                CreateDefaultXml();
                LoadXmlData();
            }
        }

        /// <summary>
        /// 創建預設 XML 結構  
        /// 預設 WeeklyConfig 為「星期二 15:29」、DailyConfig 為「00:00」，Counts 全為 50，History 為空
        /// </summary>
        private void CreateDefaultXml()
        {
            XDocument xdoc = new XDocument(
                new XElement("UsageData",
                    new XElement("WeeklyConfig",
                        new XElement("ResetDay", 2),
                        new XElement("ResetHour", 15),
                        new XElement("ResetMinute", 29)
                    ),
                    new XElement("DailyConfig",
                        new XElement("ResetHour", 0),
                        new XElement("ResetMinute", 0)
                    ),
                    new XElement("History",
                        new XElement("LastClosedTime", "")
                    ),
                    new XElement("Counts",
                        new XElement("Weekly", new XAttribute("value", LIMIT)),
                        new XElement("Daily", new XAttribute("value", LIMIT))
                    )
                )
            );
            xdoc.Save(XML_FILE);
        }

        /// <summary>
        /// 將當前狀態保存到 XML
        /// </summary>
        private void SaveXmlData()
        {
            XDocument xdoc = new XDocument(
                new XElement("UsageData",
                    new XElement("WeeklyConfig",
                        new XElement("ResetDay", weeklyResetDay),
                        new XElement("ResetHour", weeklyResetHour),
                        new XElement("ResetMinute", weeklyResetMinute)
                    ),
                    new XElement("DailyConfig",
                        new XElement("ResetHour", dailyResetHour),
                        new XElement("ResetMinute", dailyResetMinute)
                    ),
                    new XElement("History",
                        new XElement("LastClosedTime", lastClosedTime.HasValue ? lastClosedTime.Value.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) : "")
                    ),
                    new XElement("Counts",
                        new XElement("Weekly", new XAttribute("value", weeklyCount)),
                        new XElement("Daily", new XAttribute("value", dailyCount))
                    )
                )
            );
            xdoc.Save(XML_FILE);
        }

        /// <summary>
        /// 檢查啟動時是否需自動重置次數  
        /// 判定邏輯：  
        /// 1. 若 XML 有 LastClosedTime（表示曾關閉程序），則：  
        ///    - 每周：以本週（以星期日為起點）計算目標重置時間 targetWeekly  
        ///      如果 now ≥ targetWeekly 且 LastClosedTime &lt; targetWeekly，則 weeklyCount 重置為 50  
        ///    - 每日：組合出今日目標重置時間 targetDaily  
        ///      如果 now ≥ targetDaily 且 LastClosedTime &lt; targetDaily，則 dailyCount 重置為 50  
        /// 2. 否則不做重置
        /// </summary>
        private void CheckResetOnStart()
        {
            DateTime now = DateTime.Now;
            bool updated = false;

            if (lastClosedTime.HasValue)
            {
                // 每周重置檢查
                DateTime sunday = now.Date.AddDays(-(int)now.DayOfWeek);
                DateTime targetWeekly = sunday.AddDays(weeklyResetDay)
                    .AddHours(weeklyResetHour)
                    .AddMinutes(weeklyResetMinute);
                if (targetWeekly > now)
                    targetWeekly = targetWeekly.AddDays(-7);
                if (now >= targetWeekly && lastClosedTime.Value < targetWeekly)
                {
                    weeklyCount = LIMIT;
                    updated = true;
                }

                // 每日重置檢查
                DateTime targetDaily = new DateTime(now.Year, now.Month, now.Day, dailyResetHour, dailyResetMinute, 0);
                if (now >= targetDaily && lastClosedTime.Value < targetDaily)
                {
                    dailyCount = LIMIT;
                    updated = true;
                }
            }
            if (updated)
            {
                SaveXmlData();
            }
        }

        /// <summary>
        /// Timer 每分鐘觸發，檢查是否達到重置條件
        /// </summary>
        private void TimerReset_Tick(object sender, EventArgs e)
        {
            CheckResetOnStart();
            lblWeeklyCount.Text = weeklyCount.ToString();
            lblDailyCount.Text = dailyCount.ToString();
        }

        /// <summary>
        /// Weekly 扣減操作（按鈕文字為「－」）  
        /// 如果剩餘數值大於 0 則減 1
        /// </summary>
        private void btnWeeklyBuild_Click(object sender, EventArgs e)
        {
            if (weeklyCount > 0)
            {
                weeklyCount--;
                SaveXmlData();
                lblWeeklyCount.Text = weeklyCount.ToString();
            }
            else
            {
                MessageBox.Show("ChatGPT o1 次數已用完！");
            }
        }

        /// <summary>
        /// Daily 扣減操作（按鈕文字為「－」）
        /// </summary>
        private void btnDailyBuild_Click(object sender, EventArgs e)
        {
            if (dailyCount > 0)
            {
                dailyCount--;
                SaveXmlData();
                lblDailyCount.Text = dailyCount.ToString();
            }
            else
            {
                MessageBox.Show("ChatGPT o1-mini 次數已用完！");
            }
        }

        /// <summary>
        /// 呼叫編輯設定窗體，方便用戶修改 XML 中的配置  
        /// 編輯完畢後，更新主窗體提示資訊（重置時間）並保存 XML
        /// </summary>
        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            frmEditXML frmEdit = new frmEditXML();
            // 以對話視窗模式顯示，編輯完成後重新讀取 XML 與更新提示資訊
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                LoadXmlData();
                UpdateResetInfoLabels();
                // 同時更新主窗體顯示的次數
                lblWeeklyCount.Text = weeklyCount.ToString();
                lblDailyCount.Text = dailyCount.ToString();
            }
        }
    }
}
