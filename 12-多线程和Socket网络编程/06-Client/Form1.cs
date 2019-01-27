using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Socket socketSend;
        private void btnstart_Click(object sender, EventArgs e)
        {
            try
            {
                //创建负责通信的Socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtSever.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                socketSend.Connect(point);
                ShowMsg("连接成功");

                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start();
            }
            catch
            { }
        }

        /// <summary>
        /// 接收服务器端发来的消息
        /// </summary>
        void Recive()
        {
            byte[] buffer = new byte[1024 * 1024 * 5];
            while (true)
            {
                try
                {
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                        break;

                    if (buffer[0] == 0)
                    {
                        string str = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Title = "请选择要保存的文件";
                        sfd.InitialDirectory = @"C:\Users\liuwe\Desktop";
                        sfd.Filter = "所有文件|*.*";

                        sfd.ShowDialog(this);

                        string path = sfd.FileName;
                        //没选择路径就return
                        if (path == "")
                            return;

                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                            MessageBox.Show("保存成功");
                        }
                    }
                    else if (buffer[0] == 2)
                    {
                        ZD();
                    }


                }
                catch
                { }
            }
        }

        /// <summary>
        /// 窗口震动
        /// </summary>
        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(250, 250);
                this.Location = new Point(220, 220);

            }
        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        /// <summary>
        /// 客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text.Trim();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
            txtMsg.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
