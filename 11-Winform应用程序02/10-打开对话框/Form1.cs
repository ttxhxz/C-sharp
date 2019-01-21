using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开文件对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //设置对话框标题
            ofd.Title = "请选择要打开的文本";
            //设置对话框可以多选
            ofd.Multiselect = true;
            //设置对话框的初始目录
            ofd.InitialDirectory = @"C:\Users\liuwe\Desktop";
            //设置对话框的文件类型
            ofd.Filter = "文本文件|*.txt|音乐文件|*.flac|所有文件|*.*";
            //展示对话框
            ofd.ShowDialog();

            string path = ofd.FileName;
            if (path == "")
                return;

            using (FileStream fsReader = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int count = fsReader.Read(buffer, 0, buffer.Length);

                txtBox.Text = Encoding.UTF8.GetString(buffer, 0, count);
            }
        }
    }
}
