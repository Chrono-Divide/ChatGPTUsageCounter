// frmEditXML.Designer.cs
namespace ChatGPTUsageCounter
{
    partial class frmEditXML
    {
        /// <summary>
        /// 必需的設計器變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpO1;
        private System.Windows.Forms.Label lblO1Day;
        private System.Windows.Forms.Label lblO1Hour;
        private System.Windows.Forms.Label lblO1Minute;
        private System.Windows.Forms.NumericUpDown nudO1Day;
        private System.Windows.Forms.NumericUpDown nudO1Hour;
        private System.Windows.Forms.NumericUpDown nudO1Minute;

        private System.Windows.Forms.GroupBox grpMiniHigh;
        private System.Windows.Forms.Label lblMiniHighHour;
        private System.Windows.Forms.Label lblMiniHighMinute;
        private System.Windows.Forms.NumericUpDown nudMiniHighHour;
        private System.Windows.Forms.NumericUpDown nudMiniHighMinute;

        private System.Windows.Forms.Button btnSave;

        /// <summary>
        /// 清理正在使用的資源
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form 設計器生成的程式碼

        /// <summary>
        /// 設計器支持的方法，請勿修改
        /// </summary>
        private void InitializeComponent()
        {
            this.grpO1 = new System.Windows.Forms.GroupBox();
            this.lblO1Day = new System.Windows.Forms.Label();
            this.lblO1Hour = new System.Windows.Forms.Label();
            this.lblO1Minute = new System.Windows.Forms.Label();
            this.nudO1Day = new System.Windows.Forms.NumericUpDown();
            this.nudO1Hour = new System.Windows.Forms.NumericUpDown();
            this.nudO1Minute = new System.Windows.Forms.NumericUpDown();
            this.grpMiniHigh = new System.Windows.Forms.GroupBox();
            this.lblMiniHighHour = new System.Windows.Forms.Label();
            this.lblMiniHighMinute = new System.Windows.Forms.Label();
            this.nudMiniHighHour = new System.Windows.Forms.NumericUpDown();
            this.nudMiniHighMinute = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpO1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudO1Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudO1Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudO1Minute)).BeginInit();
            this.grpMiniHigh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiniHighHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiniHighMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // grpO1
            // 
            this.grpO1.Controls.Add(this.lblO1Day);
            this.grpO1.Controls.Add(this.lblO1Hour);
            this.grpO1.Controls.Add(this.lblO1Minute);
            this.grpO1.Controls.Add(this.nudO1Day);
            this.grpO1.Controls.Add(this.nudO1Hour);
            this.grpO1.Controls.Add(this.nudO1Minute);
            this.grpO1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpO1.Location = new System.Drawing.Point(20, 20);
            this.grpO1.Name = "grpO1";
            this.grpO1.Size = new System.Drawing.Size(544, 95);
            this.grpO1.TabIndex = 0;
            this.grpO1.TabStop = false;
            this.grpO1.Text = "ChatGPT Premium 每周重置設定";
            // 
            // lblO1Day
            // 
            this.lblO1Day.AutoSize = true;
            this.lblO1Day.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblO1Day.Location = new System.Drawing.Point(20, 40);
            this.lblO1Day.Name = "lblO1Day";
            this.lblO1Day.Size = new System.Drawing.Size(74, 19);
            this.lblO1Day.TabIndex = 0;
            this.lblO1Day.Text = "星期 (0-6):";
            // 
            // lblO1Hour
            // 
            this.lblO1Hour.AutoSize = true;
            this.lblO1Hour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblO1Hour.Location = new System.Drawing.Point(200, 40);
            this.lblO1Hour.Name = "lblO1Hour";
            this.lblO1Hour.Size = new System.Drawing.Size(68, 19);
            this.lblO1Hour.TabIndex = 1;
            this.lblO1Hour.Text = "時 (0-23):";
            // 
            // lblO1Minute
            // 
            this.lblO1Minute.AutoSize = true;
            this.lblO1Minute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblO1Minute.Location = new System.Drawing.Point(380, 40);
            this.lblO1Minute.Name = "lblO1Minute";
            this.lblO1Minute.Size = new System.Drawing.Size(68, 19);
            this.lblO1Minute.TabIndex = 2;
            this.lblO1Minute.Text = "分 (0-59):";
            // 
            // nudO1Day
            // 
            this.nudO1Day.Location = new System.Drawing.Point(110, 38);
            this.nudO1Day.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudO1Day.Name = "nudO1Day";
            this.nudO1Day.Size = new System.Drawing.Size(60, 25);
            this.nudO1Day.TabIndex = 3;
            // 
            // nudO1Hour
            // 
            this.nudO1Hour.Location = new System.Drawing.Point(285, 38);
            this.nudO1Hour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudO1Hour.Name = "nudO1Hour";
            this.nudO1Hour.Size = new System.Drawing.Size(60, 25);
            this.nudO1Hour.TabIndex = 4;
            // 
            // nudO1Minute
            // 
            this.nudO1Minute.Location = new System.Drawing.Point(465, 38);
            this.nudO1Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudO1Minute.Name = "nudO1Minute";
            this.nudO1Minute.Size = new System.Drawing.Size(60, 25);
            this.nudO1Minute.TabIndex = 5;
            // 
            // grpMiniHigh
            // 
            this.grpMiniHigh.Controls.Add(this.lblMiniHighHour);
            this.grpMiniHigh.Controls.Add(this.lblMiniHighMinute);
            this.grpMiniHigh.Controls.Add(this.nudMiniHighHour);
            this.grpMiniHigh.Controls.Add(this.nudMiniHighMinute);
            this.grpMiniHigh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMiniHigh.Location = new System.Drawing.Point(20, 130);
            this.grpMiniHigh.Name = "grpMiniHigh";
            this.grpMiniHigh.Size = new System.Drawing.Size(544, 85);
            this.grpMiniHigh.TabIndex = 1;
            this.grpMiniHigh.TabStop = false;
            this.grpMiniHigh.Text = "ChatGPT mini‑high 每日重置設定";
            // 
            // lblMiniHighHour
            // 
            this.lblMiniHighHour.AutoSize = true;
            this.lblMiniHighHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMiniHighHour.Location = new System.Drawing.Point(20, 40);
            this.lblMiniHighHour.Name = "lblMiniHighHour";
            this.lblMiniHighHour.Size = new System.Drawing.Size(68, 19);
            this.lblMiniHighHour.TabIndex = 0;
            this.lblMiniHighHour.Text = "時 (0-23):";
            // 
            // lblMiniHighMinute
            // 
            this.lblMiniHighMinute.AutoSize = true;
            this.lblMiniHighMinute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMiniHighMinute.Location = new System.Drawing.Point(240, 40);
            this.lblMiniHighMinute.Name = "lblMiniHighMinute";
            this.lblMiniHighMinute.Size = new System.Drawing.Size(68, 19);
            this.lblMiniHighMinute.TabIndex = 1;
            this.lblMiniHighMinute.Text = "分 (0-59):";
            // 
            // nudMiniHighHour
            // 
            this.nudMiniHighHour.Location = new System.Drawing.Point(105, 38);
            this.nudMiniHighHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudMiniHighHour.Name = "nudMiniHighHour";
            this.nudMiniHighHour.Size = new System.Drawing.Size(60, 25);
            this.nudMiniHighHour.TabIndex = 2;
            // 
            // nudMiniHighMinute
            // 
            this.nudMiniHighMinute.Location = new System.Drawing.Point(325, 38);
            this.nudMiniHighMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMiniHighMinute.Name = "nudMiniHighMinute";
            this.nudMiniHighMinute.Size = new System.Drawing.Size(60, 25);
            this.nudMiniHighMinute.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(390, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "儲存設定";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 290);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpMiniHigh);
            this.Controls.Add(this.grpO1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯重置設定";
            this.grpO1.ResumeLayout(false);
            this.grpO1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudO1Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudO1Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudO1Minute)).EndInit();
            this.grpMiniHigh.ResumeLayout(false);
            this.grpMiniHigh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiniHighHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiniHighMinute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
