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

namespace _09_实现照片的上一张下一张_翻页效果
{
    public partial class Form1 : Form
    {
        string[] path = Directory.GetFiles(@"F:\Hello");
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载时默认显示的图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");

        }

        /// <summary>
        /// 点击下一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            i = (i + 1) % path.Length;
            pictureBox1.Image = Image.FromFile(path[i]);
        }

        /// <summary>
        /// 点击上一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreviou_Click(object sender, EventArgs e)
        {
            i = (i - 1 + path.Length) % path.Length;
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
