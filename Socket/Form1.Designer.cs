namespace SocketPro
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btConn = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.tBService = new System.Windows.Forms.TextBox();
            this.tBTcpPort = new System.Windows.Forms.TextBox();
            this.tBNickName = new System.Windows.Forms.TextBox();
            this.rTBMessage = new System.Windows.Forms.RichTextBox();
            this.rTBSend = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "TCP端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "昵称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "接受信息：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "发送信息：";
            // 
            // btConn
            // 
            this.btConn.Location = new System.Drawing.Point(14, 144);
            this.btConn.Name = "btConn";
            this.btConn.Size = new System.Drawing.Size(75, 23);
            this.btConn.TabIndex = 1;
            this.btConn.Text = "连接";
            this.btConn.UseVisualStyleBackColor = true;
            this.btConn.Click += new System.EventHandler(this.btConn_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(14, 98);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "开始监听";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(140, 98);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "停止监听";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(140, 144);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 1;
            this.btExit.Text = "断开";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(14, 249);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "另存为记录";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(140, 249);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 1;
            this.btLoad.Text = "加载记录";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(14, 198);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 1;
            this.btSend.Text = "发送信息";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btQuit
            // 
            this.btQuit.Location = new System.Drawing.Point(140, 198);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(75, 23);
            this.btQuit.TabIndex = 1;
            this.btQuit.Text = "退出";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // tBService
            // 
            this.tBService.Location = new System.Drawing.Point(71, 6);
            this.tBService.Name = "tBService";
            this.tBService.Size = new System.Drawing.Size(144, 21);
            this.tBService.TabIndex = 2;
            // 
            // tBTcpPort
            // 
            this.tBTcpPort.Location = new System.Drawing.Point(71, 47);
            this.tBTcpPort.Name = "tBTcpPort";
            this.tBTcpPort.Size = new System.Drawing.Size(144, 21);
            this.tBTcpPort.TabIndex = 2;
            // 
            // tBNickName
            // 
            this.tBNickName.Location = new System.Drawing.Point(351, 6);
            this.tBNickName.Name = "tBNickName";
            this.tBNickName.Size = new System.Drawing.Size(100, 21);
            this.tBNickName.TabIndex = 2;
            // 
            // rTBMessage
            // 
            this.rTBMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBMessage.Location = new System.Drawing.Point(306, 71);
            this.rTBMessage.Name = "rTBMessage";
            this.rTBMessage.Size = new System.Drawing.Size(145, 96);
            this.rTBMessage.TabIndex = 3;
            this.rTBMessage.Text = "";
            // 
            // rTBSend
            // 
            this.rTBSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBSend.Location = new System.Drawing.Point(306, 198);
            this.rTBSend.Name = "rTBSend";
            this.rTBSend.Size = new System.Drawing.Size(145, 96);
            this.rTBSend.TabIndex = 3;
            this.rTBSend.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(487, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "就绪";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(487, 316);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rTBSend);
            this.Controls.Add(this.rTBMessage);
            this.Controls.Add(this.tBTcpPort);
            this.Controls.Add(this.tBNickName);
            this.Controls.Add(this.tBService);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btConn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "点对点聊天";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConn;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.TextBox tBService;
        private System.Windows.Forms.TextBox tBTcpPort;
        private System.Windows.Forms.TextBox tBNickName;
        private System.Windows.Forms.RichTextBox rTBMessage;
        private System.Windows.Forms.RichTextBox rTBSend;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

