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

namespace _07_实现点击更换照片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] path = Directory.GetFiles(@"f:\Hello");
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < path.Length; i++)
            {
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pathName = path[listBox1.SelectedIndex];
            pictureBox1.Image = Image.FromFile(pathName);
        }
    }
}
