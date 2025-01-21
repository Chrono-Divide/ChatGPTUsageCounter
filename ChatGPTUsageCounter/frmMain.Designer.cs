namespace ChatGPTUsageCounter
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的設計器變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 控制項宣告
        private System.Windows.Forms.Label lblWeekly;
        private System.Windows.Forms.Label lblDaily;
        private System.Windows.Forms.Label lblWeeklyCount;
        private System.Windows.Forms.Label lblDailyCount;
        private System.Windows.Forms.Button btnWeeklyBuild;
        private System.Windows.Forms.Button btnDailyBuild;
        private System.Windows.Forms.Timer timerReset;
        private System.Windows.Forms.Label lblInfoWeekly;
        private System.Windows.Forms.Label lblInfoDaily;
        private System.Windows.Forms.Button btnEditSettings;

        /// <summary>
        /// 清理正在使用的資源
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計器生成的程式碼

        /// <summary>
        /// 由設計器支持的方法，不要修改
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWeekly = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.lblWeeklyCount = new System.Windows.Forms.Label();
            this.lblDailyCount = new System.Windows.Forms.Label();
            this.btnWeeklyBuild = new System.Windows.Forms.Button();
            this.btnDailyBuild = new System.Windows.Forms.Button();
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.lblInfoWeekly = new System.Windows.Forms.Label();
            this.lblInfoDaily = new System.Windows.Forms.Label();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWeekly
            // 
            this.lblWeekly.AutoSize = true;
            this.lblWeekly.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWeekly.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWeekly.Location = new System.Drawing.Point(30, 30);
            this.lblWeekly.Name = "lblWeekly";
            this.lblWeekly.Size = new System.Drawing.Size(185, 25);
            this.lblWeekly.TabIndex = 0;
            this.lblWeekly.Text = "ChatGPT o1 次數：";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDaily.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDaily.Location = new System.Drawing.Point(30, 100);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(232, 25);
            this.lblDaily.TabIndex = 3;
            this.lblDaily.Text = "ChatGPT o1-mini 次數：";
            // 
            // lblWeeklyCount
            // 
            this.lblWeeklyCount.AutoSize = true;
            this.lblWeeklyCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblWeeklyCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWeeklyCount.Location = new System.Drawing.Point(286, 24);
            this.lblWeeklyCount.Name = "lblWeeklyCount";
            this.lblWeeklyCount.Size = new System.Drawing.Size(28, 32);
            this.lblWeeklyCount.TabIndex = 1;
            this.lblWeeklyCount.Text = "0";
            // 
            // lblDailyCount
            // 
            this.lblDailyCount.AutoSize = true;
            this.lblDailyCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDailyCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDailyCount.Location = new System.Drawing.Point(286, 94);
            this.lblDailyCount.Name = "lblDailyCount";
            this.lblDailyCount.Size = new System.Drawing.Size(28, 32);
            this.lblDailyCount.TabIndex = 4;
            this.lblDailyCount.Text = "0";
            // 
            // btnWeeklyBuild
            // 
            this.btnWeeklyBuild.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnWeeklyBuild.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnWeeklyBuild.ForeColor = System.Drawing.Color.White;
            this.btnWeeklyBuild.Location = new System.Drawing.Point(360, 15);
            this.btnWeeklyBuild.Name = "btnWeeklyBuild";
            this.btnWeeklyBuild.Size = new System.Drawing.Size(130, 50);
            this.btnWeeklyBuild.TabIndex = 2;
            this.btnWeeklyBuild.Text = "－";
            this.btnWeeklyBuild.UseVisualStyleBackColor = false;
            this.btnWeeklyBuild.Click += new System.EventHandler(this.btnWeeklyBuild_Click);
            // 
            // btnDailyBuild
            // 
            this.btnDailyBuild.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDailyBuild.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnDailyBuild.ForeColor = System.Drawing.Color.White;
            this.btnDailyBuild.Location = new System.Drawing.Point(360, 85);
            this.btnDailyBuild.Name = "btnDailyBuild";
            this.btnDailyBuild.Size = new System.Drawing.Size(130, 50);
            this.btnDailyBuild.TabIndex = 5;
            this.btnDailyBuild.Text = "－";
            this.btnDailyBuild.UseVisualStyleBackColor = false;
            this.btnDailyBuild.Click += new System.EventHandler(this.btnDailyBuild_Click);
            // 
            // lblInfoWeekly
            // 
            this.lblInfoWeekly.AutoSize = true;
            this.lblInfoWeekly.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfoWeekly.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoWeekly.Location = new System.Drawing.Point(30, 70);
            this.lblInfoWeekly.Name = "lblInfoWeekly";
            this.lblInfoWeekly.Size = new System.Drawing.Size(284, 19);
            this.lblInfoWeekly.TabIndex = 6;
            this.lblInfoWeekly.Text = "自動判斷每周重置（XML設定：星期? ??:??）";
            // 
            // lblInfoDaily
            // 
            this.lblInfoDaily.AutoSize = true;
            this.lblInfoDaily.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfoDaily.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoDaily.Location = new System.Drawing.Point(30, 150);
            this.lblInfoDaily.Name = "lblInfoDaily";
            this.lblInfoDaily.Size = new System.Drawing.Size(246, 19);
            this.lblInfoDaily.TabIndex = 7;
            this.lblInfoDaily.Text = "自動判斷每日重置（XML設定：??:??）";
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEditSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditSettings.ForeColor = System.Drawing.Color.White;
            this.btnEditSettings.Location = new System.Drawing.Point(360, 150);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(130, 40);
            this.btnEditSettings.TabIndex = 8;
            this.btnEditSettings.Text = "編輯設定";
            this.btnEditSettings.UseVisualStyleBackColor = false;
            this.btnEditSettings.Click += new System.EventHandler(this.btnEditSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 210);
            this.Controls.Add(this.btnEditSettings);
            this.Controls.Add(this.lblInfoDaily);
            this.Controls.Add(this.lblInfoWeekly);
            this.Controls.Add(this.btnDailyBuild);
            this.Controls.Add(this.lblDailyCount);
            this.Controls.Add(this.lblDaily);
            this.Controls.Add(this.btnWeeklyBuild);
            this.Controls.Add(this.lblWeeklyCount);
            this.Controls.Add(this.lblWeekly);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Name = "frmMain";
            this.Text = "ChatGPT 使用次數統計";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
