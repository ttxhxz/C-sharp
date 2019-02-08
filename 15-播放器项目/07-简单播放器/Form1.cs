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

            label1.Image = Image.FromFile(@"E:\Visual Studio Project\C-sharp\15-播放器项目\07-简单播放器\Resource\放音.png");
        }
        List<string> pathList = new List<string>();


        bool b = true;
        /// <summary>
        /// 播放暂停按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayorPause_Click(object sender, EventArgs e)
        {
            if (btnPlayorPause.Text == "播放")
            {
                if (b)
                {
                    musicPlayer.URL = pathList[listBox1.SelectedIndex];
                    IsExistLrc(pathList[listBox1.SelectedIndex]);
                }

                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            else
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayorPause.Text = "播放";
                b = false;
            }
        }



        /// <summary>
        /// 打开对话框 选择音乐 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"F:\音乐";
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

        /// <summary>
        /// listbox双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                IsExistLrc(pathList[listBox1.SelectedIndex]);
            }
            catch { }


        }

        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 点击删除 选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //要删除列表中的选中项
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //先删集合
                pathList.RemoveAt(listBox1.SelectedIndex);

                //再删列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

        }

        /// <summary>
        /// 静音按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Tag.ToString() == "1")
            {
                //目的：让你静音
                musicPlayer.settings.mute = true;
                label1.Tag = "2";
                label1.Image = Image.FromFile(@"E:\Visual Studio Project\C-sharp\15-播放器项目\07-简单播放器\Resource\静音.png");
            }
            else if (label1.Tag.ToString() == "2")
            {
                musicPlayer.settings.mute = false;
                label1.Tag = "1";
                label1.Image = Image.FromFile(@"E:\Visual Studio Project\C-sharp\15-播放器项目\07-简单播放器\Resource\放音.png");
            }

        }

        /// <summary>
        /// 显示歌曲时间计时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //当歌曲在播放的时候才更新信息
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInformation.Text = "总秒数：" + musicPlayer.currentMedia.duration.ToString() + "\r\n" +
                    musicPlayer.currentMedia.durationString + "\r\n" +
                    "当前秒数：" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" +
                    musicPlayer.Ctlcontrols.currentPositionString;

                double d1 = double.Parse(musicPlayer.currentMedia.duration.ToString());
                double d2 = double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) + 1;
                //如果当前播放秒数大于等于总秒数，则下一曲
                if (d2 >= d1)
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
            }
        }

        //开始做歌词
        void IsExistLrc(string songPath)
        {
            songPath = songPath + ".lrc";
            if (File.Exists(songPath))
            {
                string[] lrcText = File.ReadAllLines(songPath);
                //格式化歌词
                FormatLrc(lrcText);
            }
            else
            {
                lblLrc.Text = "-----------未找到歌词-----------";
            }
        }

        //存储时间
        List<double> listTime = new List<double>();
        //存储歌词
        List<string> listLrcText = new List<string>();

        //格式化歌词
        void FormatLrc(string[] lrcText)
        {
            listTime.Clear();
            listLrcText.Clear();

            for (int i = 0; i < lrcText.Length; i++)
            {
                try
                {
                    //[00:19.09]手中雕刻生花  lrcText[i]
                    string[] tempLrc = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                    //00:19.09      tempLrc[0]
                    //手中雕刻生花    tempLrc[1]

                    string[] tempLrcNew = tempLrc[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                    //00    tempLrcNew[0]
                    //19.09 tempLrcNew[1]

                    double time = double.Parse(tempLrcNew[0]) * 60 + double.Parse(tempLrcNew[1]);
                    listTime.Add(time);
                    listLrcText.Add(tempLrc[1]);
                }
                catch { }
            }
        }

        //歌词显示
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                double nowTime = double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString());
                for (int i = 0; i < listTime.Count - 1; i++)
                {
                    //直接按照歌词时间戳有点晚，，让歌词提前0.5秒出现(1秒太多)
                    if (listTime[i] - 0.5 <= nowTime && listTime[i + 1] - 0.5 >= nowTime)
                    {
                        lblLrc.Text = listLrcText[i];
                    }
                }
            }
        }
    }
}
