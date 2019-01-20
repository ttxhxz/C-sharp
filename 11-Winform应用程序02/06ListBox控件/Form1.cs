using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06ListBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(1);
            listBox1.Items.Add(2);
            listBox1.Items.Add(3);
            listBox1.Items.Add(4);
            listBox1.Items.Add(5);
        }
    }
}
