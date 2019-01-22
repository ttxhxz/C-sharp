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

namespace _14_记事本应用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            txtBox.WordWrap = false;
        }

        List<string> pathList = new List<string>();

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择需要打开的文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\liuwe\Desktop";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.ShowDialog();

            string path = ofd.FileName;
            if (path == "")
                return;

            pathList.Add(path);

            string fileName = Path.GetFileName(path);
            listBox1.Items.Add(fileName);

            //读取文件前先清除原文本
            txtBox.Text = "";
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //如何读几百兆的文件还是要思考一下怎么做
                byte[] buffer = new byte[1024 * 1024 * 10];
                while (true)
                {
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    if (r == 0)
                        break;

                    txtBox.Text += Encoding.UTF8.GetString(buffer);
                }
            }

        }

        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.InitialDirectory = @"C:\Users\liuwe\Desktop";
            sfd.Filter = "文本文件|*.txt";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
                return;

            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(txtBox.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtBox.WordWrap)
            {
                txtBox.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
            else
            {
                txtBox.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "取消自动换行";
            }
        }

        /// <summary>
        /// 双击历史记录打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string path = pathList[listBox1.SelectedIndex];

            //读取文件前先清除原文本
            txtBox.Text = "";
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //如何读几百兆的文件还是要思考一下怎么做
                byte[] buffer = new byte[1024 * 1024 * 10];
                while (true)
                {
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    if (r == 0)
                        break;

                    txtBox.Text += Encoding.UTF8.GetString(buffer);
                }
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();

            txtBox.Font = fd.Font;
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();

            txtBox.ForeColor = cd.Color;
        }
    }
}
