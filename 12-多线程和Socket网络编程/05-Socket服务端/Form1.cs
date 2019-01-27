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

        Socket socketSend;
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 等待客户端的连接 并且创建与之通信的Socket
        /// </summary>
        void Listen(Object o)
        {
            Socket socketWatch = o as Socket;
            //等待客户端的连接  并且创建一个负责通信的Socket
            while (true)
            {
                try
                {
                    //负责和客户端通信的Socket
                    socketSend = socketWatch.Accept();

                    //添加ip地址及其对应的Socket并保存
                    dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                    cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());

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

        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text.Trim());

            string ip = cboUsers.SelectedItem.ToString();
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();
            dicSocket[ip].Send(newBuffer);

            //dicSocket[ip].Send(buffer);

            //socketSend.Send(buffer);

            txtMsg.Text = "";
        }

        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要发送的文件";
            ofd.InitialDirectory = @"C:\Users\liuwe\Desktop";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();

            //得到用户选择的文件放到文件路径对话框中
            txtPath.Text = ofd.FileName;
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //获取要发送文件的文件路径
            string path = txtPath.Text;
            //如果用户未选择文件就点发送就提示用户选择文件并return
            if (path == "")
            {
                MessageBox.Show("请先选择需要发送的文件");
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();

                //获取用户当前选择的IP
                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer, 0, r + 1, SocketFlags.None);
            }
        }

        /// <summary>
        /// 震动按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;

            string ip = cboUsers.SelectedItem.ToString();
            dicSocket[ip].Send(buffer);
        }
    }
}
