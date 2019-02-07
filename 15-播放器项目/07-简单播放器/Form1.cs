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
            btnPlayorPause.Text = "播放";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候取消播放器的自动播放功能
            musicPlayer.settings.autoStart = false;

            //musicPlayer.URL = @"F:\音乐\2015 - Ori and the Blind Forest (Original Soundtrack)\01. Ori, Lost In the Storm (feat. Aeralie Brighton).flac";
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

        List<string> pathList = new List<string>();

        /// <summary>
        /// 打开对话框 选择音乐 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"F:\音乐\2015 - Ori and the Blind Forest (Original Soundtrack)";
            ofd.Filter = "所有文件|*.*|MP3文件|*.mp3|Flac文件|*.flac";
            ofd.Multiselect = true;

            ofd.ShowDialog();

            //再次打开对话框选文件时，先把列表的原数据清除一遍
            pathList.Clear();
            listBox1.Items.Clear();

            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将选中的路径存到List数组中
                pathList.Add(path[i]);

                //将文件名放入listbox中
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);

            }

            //初始化列表框和播放器的默认歌曲
            if (pathList.Count > 0)
            {
                musicPlayer.URL = pathList[0];
                listBox1.SelectedIndex = 0;
                btnPlayorPause.Text = "播放";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请先选择音乐文件！");
                return;
            }

            try
            {
                musicPlayer.URL = pathList[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            catch { }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //获取当前选中音乐的索引
            int index = listBox1.SelectedIndex;

            //清空所有选中项的索引
            listBox1.SelectedIndices.Clear();

            index++;
            if (index == pathList.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            musicPlayer.URL = pathList[index];
            musicPlayer.Ctlcontrols.play();
            btnPlayorPause.Text = "暂停";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //获取当前选中音乐的索引
            int index = listBox1.SelectedIndex;

            //清空所有选中项的索引
            listBox1.SelectedIndices.Clear();

            index--;
            if (index == -1)
            {
                index = pathList.Count - 1;
            }
            listBox1.SelectedIndex = index;
            musicPlayer.URL = pathList[index];
            musicPlayer.Ctlcontrols.play();
            btnPlayorPause.Text = "暂停";
        }
    }
}
