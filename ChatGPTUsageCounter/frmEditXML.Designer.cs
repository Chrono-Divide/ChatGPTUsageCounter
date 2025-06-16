// frmEditXML.Designer.cs
namespace ChatGPTUsageCounter
{
    partial class frmEditXML
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWeekly;
        private System.Windows.Forms.DateTimePicker dtpWeeklyReset;
        private System.Windows.Forms.Label lblMiniHigh;
        private System.Windows.Forms.NumericUpDown nudMhHour;
        private System.Windows.Forms.NumericUpDown nudMhMinute;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblWeekly = new System.Windows.Forms.Label();
            this.dtpWeeklyReset = new System.Windows.Forms.DateTimePicker();
            this.lblMiniHigh = new System.Windows.Forms.Label();
            this.nudMhHour = new System.Windows.Forms.NumericUpDown();
            this.lblColon = new System.Windows.Forms.Label();
            this.nudMhMinute = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMhHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMhMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeekly
            // 
            this.lblWeekly.AutoSize = true;
            this.lblWeekly.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblWeekly.Location = new System.Drawing.Point(24, 26);
            this.lblWeekly.Name = "lblWeekly";
            this.lblWeekly.Size = new System.Drawing.Size(177, 20);
            this.lblWeekly.TabIndex = 0;
            this.lblWeekly.Text = "Premium 每周重置時間：";
            // 
            // dtpWeeklyReset
            // 
            this.dtpWeeklyReset.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpWeeklyReset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpWeeklyReset.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWeeklyReset.Location = new System.Drawing.Point(207, 22);
            this.dtpWeeklyReset.Name = "dtpWeeklyReset";
            this.dtpWeeklyReset.ShowUpDown = true;
            this.dtpWeeklyReset.Size = new System.Drawing.Size(187, 27);
            this.dtpWeeklyReset.TabIndex = 1;
            // 
            // lblMiniHigh
            // 
            this.lblMiniHigh.AutoSize = true;
            this.lblMiniHigh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMiniHigh.Location = new System.Drawing.Point(24, 74);
            this.lblMiniHigh.Name = "lblMiniHigh";
            this.lblMiniHigh.Size = new System.Drawing.Size(161, 20);
            this.lblMiniHigh.TabIndex = 2;
            this.lblMiniHigh.Text = "mini-high 每日重置：";
            // 
            // nudMhHour
            // 
            this.nudMhHour.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudMhHour.Location = new System.Drawing.Point(207, 72);
            this.nudMhHour.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            this.nudMhHour.Name = "nudMhHour";
            this.nudMhHour.Size = new System.Drawing.Size(55, 27);
            this.nudMhHour.TabIndex = 3;
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblColon.Location = new System.Drawing.Point(267, 74);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(12, 20);
            this.lblColon.TabIndex = 4;
            this.lblColon.Text = ":";
            // 
            // nudMhMinute
            // 
            this.nudMhMinute.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.nudMhMinute.Location = new System.Drawing.Point(285, 72);
            this.nudMhMinute.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            this.nudMhMinute.Name = "nudMhMinute";
            this.nudMhMinute.Size = new System.Drawing.Size(55, 27);
            this.nudMhMinute.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(207, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "儲存(&S)";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SlateGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(304, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmEditXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 178);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudMhMinute);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.nudMhHour);
            this.Controls.Add(this.lblMiniHigh);
            this.Controls.Add(this.dtpWeeklyReset);
            this.Controls.Add(this.lblWeekly);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEditXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "重置時間設定";
            ((System.ComponentModel.ISupportInitialize)(this.nudMhHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMhMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
