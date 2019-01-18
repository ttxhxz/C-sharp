using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当文本框中的内容发生改变的时候  将值赋值给Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //lblText.Text = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblText.Text = lblText.Text.Substring(1) + lblText.Text.Substring(0, 1);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
            //11:17分播放音乐 叫我起床
            if (DateTime.Now.Hour == 11 && DateTime.Now.Minute == 21 && DateTime.Now.Second == 15)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"F:\音乐\测试.wav";
                sp.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString();
        }
    }
}
