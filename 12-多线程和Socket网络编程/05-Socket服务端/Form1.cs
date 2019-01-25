using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Socket服务端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //当点击开始监听的时候在服务器端创建一个负责监IP地址跟端囗号的Socket
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress ip = IPAddress.Parse(txtSever.Text);
                IPAddress ip = IPAddress.Any;

                //创建端口号对象
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //监听
                socketWatch.Bind(point);
                ShowMsg("监听成功");
                socketWatch.Listen(10);

                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch
            { }


        }

        /// <summary>
        /// 服务器端不停的接受客户端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive(Object o)
        {
            Socket socketSend = o as Socket;
            byte[] buffer = new byte[1024 * 1024 * 2];
            while (true)
            {
                try
                {
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                        break;

                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                }
                catch
                { }
            }
        }

        /// <summary>
        /// 等待客户端的连接 并且创建与之通信的Socket
        /// </summary>
        void Listen(Object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                try
                {
                    //等待客户端的连接  并且创建一个负责通信的Socket
                    Socket socketSend = socketWatch.Accept();
                    //192.168.0.105  连接成功
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");

                    Thread th = new Thread(Recive);
                    th.IsBackground = true;
                    th.Start(socketSend);
                }
                catch
                { }
            }

        }

        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
