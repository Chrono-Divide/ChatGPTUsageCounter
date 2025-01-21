namespace ChatGPTUsageCounter
{
    partial class frmEditXML
    {
        /// <summary>
        /// 必需的設計器變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpWeekly;
        private System.Windows.Forms.Label lblWeeklyDay;
        private System.Windows.Forms.Label lblWeeklyHour;
        private System.Windows.Forms.Label lblWeeklyMinute;
        private System.Windows.Forms.NumericUpDown nudWeeklyDay;
        private System.Windows.Forms.NumericUpDown nudWeeklyHour;
        private System.Windows.Forms.NumericUpDown nudWeeklyMinute;
        private System.Windows.Forms.GroupBox grpDaily;
        private System.Windows.Forms.Label lblDailyHour;
        private System.Windows.Forms.Label lblDailyMinute;
        private System.Windows.Forms.NumericUpDown nudDailyHour;
        private System.Windows.Forms.NumericUpDown nudDailyMinute;
        private System.Windows.Forms.Button btnSave;

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
        /// 設計器支持的方法，不要修改
        /// </summary>
        private void InitializeComponent()
        {
            this.grpWeekly = new System.Windows.Forms.GroupBox();
            this.lblWeeklyDay = new System.Windows.Forms.Label();
            this.lblWeeklyHour = new System.Windows.Forms.Label();
            this.lblWeeklyMinute = new System.Windows.Forms.Label();
            this.nudWeeklyDay = new System.Windows.Forms.NumericUpDown();
            this.nudWeeklyHour = new System.Windows.Forms.NumericUpDown();
            this.nudWeeklyMinute = new System.Windows.Forms.NumericUpDown();
            this.grpDaily = new System.Windows.Forms.GroupBox();
            this.lblDailyHour = new System.Windows.Forms.Label();
            this.lblDailyMinute = new System.Windows.Forms.Label();
            this.nudDailyHour = new System.Windows.Forms.NumericUpDown();
            this.nudDailyMinute = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWeekly.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyMinute)).BeginInit();
            this.grpDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // grpWeekly
            // 
            this.grpWeekly.Controls.Add(this.lblWeeklyDay);
            this.grpWeekly.Controls.Add(this.lblWeeklyHour);
            this.grpWeekly.Controls.Add(this.lblWeeklyMinute);
            this.grpWeekly.Controls.Add(this.nudWeeklyDay);
            this.grpWeekly.Controls.Add(this.nudWeeklyHour);
            this.grpWeekly.Controls.Add(this.nudWeeklyMinute);
            this.grpWeekly.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpWeekly.Location = new System.Drawing.Point(20, 20);
            this.grpWeekly.Name = "grpWeekly";
            this.grpWeekly.Size = new System.Drawing.Size(489, 90);
            this.grpWeekly.TabIndex = 0;
            this.grpWeekly.TabStop = false;
            this.grpWeekly.Text = "每周重置設定";
            // 
            // lblWeeklyDay
            // 
            this.lblWeeklyDay.AutoSize = true;
            this.lblWeeklyDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeeklyDay.Location = new System.Drawing.Point(20, 40);
            this.lblWeeklyDay.Name = "lblWeeklyDay";
            this.lblWeeklyDay.Size = new System.Drawing.Size(70, 19);
            this.lblWeeklyDay.TabIndex = 0;
            this.lblWeeklyDay.Text = "星期(0-6):";
            // 
            // lblWeeklyHour
            // 
            this.lblWeeklyHour.AutoSize = true;
            this.lblWeeklyHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeeklyHour.Location = new System.Drawing.Point(177, 40);
            this.lblWeeklyHour.Name = "lblWeeklyHour";
            this.lblWeeklyHour.Size = new System.Drawing.Size(68, 19);
            this.lblWeeklyHour.TabIndex = 1;
            this.lblWeeklyHour.Text = "時 (0-23):";
            // 
            // lblWeeklyMinute
            // 
            this.lblWeeklyMinute.AutoSize = true;
            this.lblWeeklyMinute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeeklyMinute.Location = new System.Drawing.Point(330, 40);
            this.lblWeeklyMinute.Name = "lblWeeklyMinute";
            this.lblWeeklyMinute.Size = new System.Drawing.Size(68, 19);
            this.lblWeeklyMinute.TabIndex = 2;
            this.lblWeeklyMinute.Text = "分 (0-59):";
            // 
            // nudWeeklyDay
            // 
            this.nudWeeklyDay.Location = new System.Drawing.Point(104, 38);
            this.nudWeeklyDay.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudWeeklyDay.Name = "nudWeeklyDay";
            this.nudWeeklyDay.Size = new System.Drawing.Size(50, 25);
            this.nudWeeklyDay.TabIndex = 3;
            // 
            // nudWeeklyHour
            // 
            this.nudWeeklyHour.Location = new System.Drawing.Point(263, 38);
            this.nudWeeklyHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudWeeklyHour.Name = "nudWeeklyHour";
            this.nudWeeklyHour.Size = new System.Drawing.Size(50, 25);
            this.nudWeeklyHour.TabIndex = 4;
            // 
            // nudWeeklyMinute
            // 
            this.nudWeeklyMinute.Location = new System.Drawing.Point(417, 38);
            this.nudWeeklyMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudWeeklyMinute.Name = "nudWeeklyMinute";
            this.nudWeeklyMinute.Size = new System.Drawing.Size(50, 25);
            this.nudWeeklyMinute.TabIndex = 5;
            // 
            // grpDaily
            // 
            this.grpDaily.Controls.Add(this.lblDailyHour);
            this.grpDaily.Controls.Add(this.lblDailyMinute);
            this.grpDaily.Controls.Add(this.nudDailyHour);
            this.grpDaily.Controls.Add(this.nudDailyMinute);
            this.grpDaily.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpDaily.Location = new System.Drawing.Point(20, 120);
            this.grpDaily.Name = "grpDaily";
            this.grpDaily.Size = new System.Drawing.Size(489, 80);
            this.grpDaily.TabIndex = 1;
            this.grpDaily.TabStop = false;
            this.grpDaily.Text = "每日重置設定";
            // 
            // lblDailyHour
            // 
            this.lblDailyHour.AutoSize = true;
            this.lblDailyHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDailyHour.Location = new System.Drawing.Point(20, 40);
            this.lblDailyHour.Name = "lblDailyHour";
            this.lblDailyHour.Size = new System.Drawing.Size(68, 19);
            this.lblDailyHour.TabIndex = 0;
            this.lblDailyHour.Text = "時 (0-23):";
            // 
            // lblDailyMinute
            // 
            this.lblDailyMinute.AutoSize = true;
            this.lblDailyMinute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDailyMinute.Location = new System.Drawing.Point(177, 40);
            this.lblDailyMinute.Name = "lblDailyMinute";
            this.lblDailyMinute.Size = new System.Drawing.Size(68, 19);
            this.lblDailyMinute.TabIndex = 1;
            this.lblDailyMinute.Text = "分 (0-59):";
            // 
            // nudDailyHour
            // 
            this.nudDailyHour.Location = new System.Drawing.Point(104, 38);
            this.nudDailyHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudDailyHour.Name = "nudDailyHour";
            this.nudDailyHour.Size = new System.Drawing.Size(50, 25);
            this.nudDailyHour.TabIndex = 2;
            // 
            // nudDailyMinute
            // 
            this.nudDailyMinute.Location = new System.Drawing.Point(263, 38);
            this.nudDailyMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDailyMinute.Name = "nudDailyMinute";
            this.nudDailyMinute.Size = new System.Drawing.Size(50, 25);
            this.nudDailyMinute.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(379, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲存設定";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 280);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpDaily);
            this.Controls.Add(this.grpWeekly);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯重置設定";
            this.grpWeekly.ResumeLayout(false);
            this.grpWeekly.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeklyMinute)).EndInit();
            this.grpDaily.ResumeLayout(false);
            this.grpDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
