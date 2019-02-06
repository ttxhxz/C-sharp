using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_简单播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候取消播放器的自动播放功能
            musicPlayer.settings.autoStart = false;

            musicPlayer.URL = @"F:\音乐\2015 - Ori and the Blind Forest (Original Soundtrack)\01. Ori, Lost In the Storm (feat. Aeralie Brighton).flac";
        }

        private void btnPlayorPause_Click(object sender, EventArgs e)
        {
            if (btnPlayorPause.Text == "播放")
            {
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            else
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayorPause.Text = "播放";
            }
        }

        /// <summary>
        /// 打开对话框 选择音乐 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
