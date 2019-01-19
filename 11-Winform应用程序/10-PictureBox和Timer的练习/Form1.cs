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

namespace _10_PictureBox和Timer的练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox1.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");
            pictureBox2.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");
            pictureBox3.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");
            pictureBox4.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");
            pictureBox5.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");
            pictureBox6.Image = Image.FromFile(@"F:\LoveSSJ\ssj.jpg");
        }

        string[] path = Directory.GetFiles(@"F:\Hello");
        int i = 0;
        Random r = new Random();

        /// <summary>
        /// 每一秒切换一个图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //顺序显示下一张图片
            //i = (i + 1) % path.Length;
            //pictureBox1.Image = Image.FromFile(path[i]);
            //pictureBox2.Image = Image.FromFile(path[i]);
            //pictureBox3.Image = Image.FromFile(path[i]);
            //pictureBox4.Image = Image.FromFile(path[i]);
            //pictureBox5.Image = Image.FromFile(path[i]);
            //pictureBox6.Image = Image.FromFile(path[i]);

            //随机显示图片
            pictureBox1.Image = Image.FromFile(path[r.Next(0,path.Length+1)]);
            pictureBox2.Image = Image.FromFile(path[r.Next(0,path.Length+1)]);
            pictureBox3.Image = Image.FromFile(path[r.Next(0,path.Length+1)]);
            pictureBox4.Image = Image.FromFile(path[r.Next(0,path.Length+1)]);
            pictureBox5.Image = Image.FromFile(path[r.Next(0,path.Length+1)]);
            pictureBox6.Image = Image.FromFile(path[r.Next(0,path.Length+1)]);
        }
    }
}
