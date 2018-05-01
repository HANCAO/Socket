using System;
using System.IO;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SocketPro
{
    public partial class Form1 : Form
    {
        private IPAddress myIP;
        private IPEndPoint myServer;
        private Socket sock;
        private bool threadHalt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void targett()
        {
            while (!threadHalt)
            {
                int n = sock.Available;
                if (n > 0)
                {
                    try
                    {
                        Byte[] bya = new Byte[n];
                        sock.Receive(bya, n, 0);
                        string s = System.Text.Encoding.Default.GetString(bya);

                        rTBMessage.AppendText(s);
                    }
                    catch { };
                }
                Thread.Sleep(300);
            }
        }

        private void btStart_Click(object sender, System.EventArgs e)
        {
            try
            {
                myIP = IPAddress.Parse(tBService.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确的IP地址");
            }
            try
            {
                myServer = new IPEndPoint(myIP, Int32.Parse(tBTcpPort.Text));
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.Bind(myServer);
                sock.Listen(1);
                toolStripStatusLabel1.Text = " 主机" + tBService.Text + " 端口" + tBTcpPort.Text + "开始监听...";
                btStart.Enabled = false;
                btConn.Enabled = false;
                btExit.Enabled = false;
                btSend.Enabled = true;
                btStop.Enabled = true;
                sock = sock.Accept();

                threadHalt = false;
                toolStripStatusLabel1.Text = "与客户建立连接成功";
                Thread thread = new Thread(new ThreadStart(targett));
                thread.Start();
            }
            catch
            {
                MessageBox.Show("请检查端口是否被占用");
            }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            try
            {
                threadHalt = true;
                sock.Close();
                toolStripStatusLabel1.Text = " 主机" + tBService.Text + ",端口" + tBTcpPort.Text + "监听停止";
                btStart.Enabled = true;
                btConn.Enabled = true;
                btExit.Enabled = false;
                btSend.Enabled = false;
                btStop.Enabled = false;
            }
            catch { };
        }

        private void btConn_Click(object sender, EventArgs e)
        {
            try
            {
                myIP = IPAddress.Parse(tBService.Text);
            }
            catch
            {
                MessageBox.Show("请检查IP地址格式");
            }
            try
            {
                myServer = new IPEndPoint(myIP, Int32.Parse(tBTcpPort.Text));
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                btStart.Enabled = false;
                btConn.Enabled = false;
                btExit.Enabled = false;
                btSend.Enabled = true;
                btStop.Enabled = true;
                sock.Connect(myServer);
                toolStripStatusLabel1.Text = " 与主机" + tBService.Text + " 端口" + tBTcpPort.Text + "连接成功";
                threadHalt = false;
                Thread thread = new Thread(new ThreadStart(targett));
                thread.Start();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            try
            {
                threadHalt = true;
                sock.Close();
                toolStripStatusLabel1.Text = "连接的主机已断开";
                btStart.Enabled = true;
                btConn.Enabled = true;
                btExit.Enabled = false;
                btSend.Enabled = false;
                btStop.Enabled = false;
            }
            catch { };
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = tBNickName.Text + " - >" + rTBSend.Text + "\r\n";
                Byte[] bya = System.Text.Encoding.Default.GetBytes(msg.ToCharArray());
                sock.Send(bya, bya.Length, SocketFlags.None);
            }
            catch
            {
                MessageBox.Show("发送前请先连接");
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (sock.Connected)
                {
                    toolStripStatusLabel1.Text = "正在关闭连接...";
                    threadHalt = true;
                    sock.Close();
                }
            }
            catch
            {

            }
            
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "文件类型(*.txt)|*.txt|所有类型(*.*)|*.*";
            saveFileDialog1.FileName = tBNickName.Text + ".txt";
            saveFileDialog1.RestoreDirectory = true;

            DialogResult rst = saveFileDialog1.ShowDialog();
            StreamWriter sw;

            if (rst == DialogResult.OK)
            {
                try
                {
                    sw = new StreamWriter(saveFileDialog1.FileName);

                    sw.WriteLine(rTBMessage.Text);

                    sw.Flush();
                    sw.Close();
                }
                catch
                {

                }
            }
        }

        private void BtLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文件类型(*.txt)|*.txt|所有类型(*.*)|*.*";
            openFileDialog1.FileName="";

            DialogResult rst = openFileDialog1.ShowDialog();

            if (rst == DialogResult.OK)
            {
                try
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);

                    StreamReader sr = new StreamReader(fs);

                    string buffer = "";

                    while (sr.Peek() > -1)
                    {
                        buffer += sr.ReadLine();
                    }

                    sr.Close();
                    fs.Close();
                    rTBMessage.Text = buffer;
                    rTBMessage.Update();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
