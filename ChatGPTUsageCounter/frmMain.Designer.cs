namespace ChatGPTUsageCounter
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的設計器變數
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 控制項宣告
        private System.Windows.Forms.Label lblO1;
        private System.Windows.Forms.Label lblO1Count;
        private System.Windows.Forms.Button btnO1Build;
        private System.Windows.Forms.Label lblInfoO1;

        private System.Windows.Forms.Label lblMiniHigh;
        private System.Windows.Forms.Label lblMiniHighCount;
        private System.Windows.Forms.Button btnMiniHighBuild;
        private System.Windows.Forms.Label lblInfoMiniHigh;

        private System.Windows.Forms.Button btnEditSettings;
        private System.Windows.Forms.Timer timerReset;

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
        /// 設計器支持的方法，請勿修改
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblO1 = new System.Windows.Forms.Label();
            this.lblO1Count = new System.Windows.Forms.Label();
            this.btnO1Build = new System.Windows.Forms.Button();
            this.lblInfoO1 = new System.Windows.Forms.Label();
            this.lblMiniHigh = new System.Windows.Forms.Label();
            this.lblMiniHighCount = new System.Windows.Forms.Label();
            this.btnMiniHighBuild = new System.Windows.Forms.Button();
            this.lblInfoMiniHigh = new System.Windows.Forms.Label();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.timerReset = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblO1
            // 
            this.lblO1.AutoSize = true;
            this.lblO1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblO1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblO1.Location = new System.Drawing.Point(30, 30);
            this.lblO1.Name = "lblO1";
            this.lblO1.Size = new System.Drawing.Size(185, 25);
            this.lblO1.TabIndex = 0;
            this.lblO1.Text = "ChatGPT o1 次數：";
            // 
            // lblO1Count
            // 
            this.lblO1Count.AutoSize = true;
            this.lblO1Count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblO1Count.ForeColor = System.Drawing.Color.DarkRed;
            this.lblO1Count.Location = new System.Drawing.Point(324, 24);
            this.lblO1Count.Name = "lblO1Count";
            this.lblO1Count.Size = new System.Drawing.Size(28, 32);
            this.lblO1Count.TabIndex = 1;
            this.lblO1Count.Text = "0";
            // 
            // btnO1Build
            // 
            this.btnO1Build.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnO1Build.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnO1Build.ForeColor = System.Drawing.Color.White;
            this.btnO1Build.Location = new System.Drawing.Point(404, 15);
            this.btnO1Build.Name = "btnO1Build";
            this.btnO1Build.Size = new System.Drawing.Size(130, 50);
            this.btnO1Build.TabIndex = 2;
            this.btnO1Build.Text = "－";
            this.btnO1Build.UseVisualStyleBackColor = false;
            this.btnO1Build.Click += new System.EventHandler(this.btnO1Build_Click);
            // 
            // lblInfoO1
            // 
            this.lblInfoO1.AutoSize = true;
            this.lblInfoO1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfoO1.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoO1.Location = new System.Drawing.Point(30, 70);
            this.lblInfoO1.Name = "lblInfoO1";
            this.lblInfoO1.Size = new System.Drawing.Size(144, 19);
            this.lblInfoO1.TabIndex = 3;
            this.lblInfoO1.Text = "每周重置：星期? ??:??";
            // 
            // lblMiniHigh
            // 
            this.lblMiniHigh.AutoSize = true;
            this.lblMiniHigh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMiniHigh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblMiniHigh.Location = new System.Drawing.Point(30, 110);
            this.lblMiniHigh.Name = "lblMiniHigh";
            this.lblMiniHigh.Size = new System.Drawing.Size(279, 25);
            this.lblMiniHigh.TabIndex = 4;
            this.lblMiniHigh.Text = "ChatGPT o3-mini-high 次數：";
            // 
            // lblMiniHighCount
            // 
            this.lblMiniHighCount.AutoSize = true;
            this.lblMiniHighCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMiniHighCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMiniHighCount.Location = new System.Drawing.Point(324, 104);
            this.lblMiniHighCount.Name = "lblMiniHighCount";
            this.lblMiniHighCount.Size = new System.Drawing.Size(28, 32);
            this.lblMiniHighCount.TabIndex = 5;
            this.lblMiniHighCount.Text = "0";
            // 
            // btnMiniHighBuild
            // 
            this.btnMiniHighBuild.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMiniHighBuild.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnMiniHighBuild.ForeColor = System.Drawing.Color.White;
            this.btnMiniHighBuild.Location = new System.Drawing.Point(404, 95);
            this.btnMiniHighBuild.Name = "btnMiniHighBuild";
            this.btnMiniHighBuild.Size = new System.Drawing.Size(130, 50);
            this.btnMiniHighBuild.TabIndex = 6;
            this.btnMiniHighBuild.Text = "－";
            this.btnMiniHighBuild.UseVisualStyleBackColor = false;
            this.btnMiniHighBuild.Click += new System.EventHandler(this.btnMiniHighBuild_Click);
            // 
            // lblInfoMiniHigh
            // 
            this.lblInfoMiniHigh.AutoSize = true;
            this.lblInfoMiniHigh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInfoMiniHigh.ForeColor = System.Drawing.Color.Gray;
            this.lblInfoMiniHigh.Location = new System.Drawing.Point(30, 155);
            this.lblInfoMiniHigh.Name = "lblInfoMiniHigh";
            this.lblInfoMiniHigh.Size = new System.Drawing.Size(144, 19);
            this.lblInfoMiniHigh.TabIndex = 7;
            this.lblInfoMiniHigh.Text = "每日重置：??:??";
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEditSettings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditSettings.ForeColor = System.Drawing.Color.White;
            this.btnEditSettings.Location = new System.Drawing.Point(404, 186);
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
            this.ClientSize = new System.Drawing.Size(552, 237);
            this.Controls.Add(this.btnEditSettings);
            this.Controls.Add(this.lblInfoMiniHigh);
            this.Controls.Add(this.btnMiniHighBuild);
            this.Controls.Add(this.lblMiniHighCount);
            this.Controls.Add(this.lblMiniHigh);
            this.Controls.Add(this.lblInfoO1);
            this.Controls.Add(this.btnO1Build);
            this.Controls.Add(this.lblO1Count);
            this.Controls.Add(this.lblO1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatGPT 使用次數統計";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
