using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> pathList = new List<string>();

        /// <summary>
        /// 打开文件夹选择音乐文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"F:\音乐\wav";
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();

            string[] path = ofd.FileNames;
            foreach (var item in path)
            {
                string fileName = Path.GetFileName(item);
                listBox1.Items.Add(fileName);
                pathList.Add(item);
            }

        }


        SoundPlayer sp = new SoundPlayer();
        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sp.SoundLocation = pathList[listBox1.SelectedIndex];
            sp.Play();
        }

        /// <summary>
        /// 下一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index = (index + 1) % listBox1.Items.Count;
            sp.SoundLocation = pathList[index];
            sp.Play();

            listBox1.SelectedIndex = index;
        }

        /// <summary>
        /// 上一首
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index = (index - 1 + listBox1.Items.Count) % listBox1.Items.Count;
            sp.SoundLocation = pathList[index];
            sp.Play();

            listBox1.SelectedIndex = index;
        }
    }
}
