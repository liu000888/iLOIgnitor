namespace iLOIgnitor
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblLastRefresh = new System.Windows.Forms.Label();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurTime = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPowerOnTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPowerOffTime = new System.Windows.Forms.Label();
            this.cbPowerOn = new System.Windows.Forms.CheckBox();
            this.cbPowerOff = new System.Windows.Forms.CheckBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblWorkStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblServer);
            this.flowLayoutPanel1.Controls.Add(this.lblStatus);
            this.flowLayoutPanel1.Controls.Add(this.lblPower);
            this.flowLayoutPanel1.Controls.Add(this.lblLastRefresh);
            this.flowLayoutPanel1.Controls.Add(this.lblConnStatus);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 130);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(356, 15);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(3, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(50, 12);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "<Server>";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(59, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 12);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "<Status>";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(115, 0);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(48, 12);
            this.lblPower.TabIndex = 2;
            this.lblPower.Text = "<Power>";
            // 
            // lblLastRefresh
            // 
            this.lblLastRefresh.AutoSize = true;
            this.lblLastRefresh.Location = new System.Drawing.Point(169, 0);
            this.lblLastRefresh.Name = "lblLastRefresh";
            this.lblLastRefresh.Size = new System.Drawing.Size(79, 12);
            this.lblLastRefresh.TabIndex = 3;
            this.lblLastRefresh.Text = "<Last_refresh>";
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(254, 0);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(79, 12);
            this.lblConnStatus.TabIndex = 4;
            this.lblConnStatus.Text = "<Conn_status>";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblCurTime
            // 
            this.lblCurTime.AutoSize = true;
            this.lblCurTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurTime.Location = new System.Drawing.Point(96, 0);
            this.lblCurTime.Name = "lblCurTime";
            this.lblCurTime.Size = new System.Drawing.Size(236, 20);
            this.lblCurTime.TabIndex = 1;
            this.lblCurTime.Text = "label1";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.80899F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.19101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPowerOnTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPowerOffTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbPowerOn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPowerOff, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWorkStatus, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 130);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Power on time";
            // 
            // lblPowerOnTime
            // 
            this.lblPowerOnTime.AutoSize = true;
            this.lblPowerOnTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPowerOnTime.Location = new System.Drawing.Point(96, 20);
            this.lblPowerOnTime.Name = "lblPowerOnTime";
            this.lblPowerOnTime.Size = new System.Drawing.Size(236, 20);
            this.lblPowerOnTime.TabIndex = 3;
            this.lblPowerOnTime.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Power off time";
            // 
            // lblPowerOffTime
            // 
            this.lblPowerOffTime.AutoSize = true;
            this.lblPowerOffTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPowerOffTime.Location = new System.Drawing.Point(96, 40);
            this.lblPowerOffTime.Name = "lblPowerOffTime";
            this.lblPowerOffTime.Size = new System.Drawing.Size(236, 20);
            this.lblPowerOffTime.TabIndex = 5;
            this.lblPowerOffTime.Text = "label5";
            // 
            // cbPowerOn
            // 
            this.cbPowerOn.AutoSize = true;
            this.cbPowerOn.Checked = true;
            this.cbPowerOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPowerOn.Location = new System.Drawing.Point(338, 23);
            this.cbPowerOn.Name = "cbPowerOn";
            this.cbPowerOn.Size = new System.Drawing.Size(15, 14);
            this.cbPowerOn.TabIndex = 6;
            this.cbPowerOn.Text = "checkBox1";
            this.cbPowerOn.UseVisualStyleBackColor = true;
            // 
            // cbPowerOff
            // 
            this.cbPowerOff.AutoSize = true;
            this.cbPowerOff.Checked = true;
            this.cbPowerOff.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPowerOff.Location = new System.Drawing.Point(338, 43);
            this.cbPowerOff.Name = "cbPowerOff";
            this.cbPowerOff.Size = new System.Drawing.Size(15, 14);
            this.cbPowerOff.TabIndex = 7;
            this.cbPowerOff.Text = "checkBox2";
            this.cbPowerOff.UseVisualStyleBackColor = true;
            // 
            // lblWorkStatus
            // 
            this.lblWorkStatus.AutoSize = true;
            this.lblWorkStatus.Location = new System.Drawing.Point(96, 60);
            this.lblWorkStatus.Name = "lblWorkStatus";
            this.lblWorkStatus.Size = new System.Drawing.Size(23, 12);
            this.lblWorkStatus.TabIndex = 8;
            this.lblWorkStatus.Text = "Idle";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 145);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblLastRefresh;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCurTime;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPowerOnTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPowerOffTime;
        private System.Windows.Forms.CheckBox cbPowerOn;
        private System.Windows.Forms.CheckBox cbPowerOff;
        private System.Windows.Forms.Label lblWorkStatus;
        private System.Windows.Forms.Timer timer2;
    }
}

