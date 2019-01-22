using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个线程去执行这个方法
            Thread th = new Thread(Test);
            //标记这个线程准备就绪了，可以随时被执行。具体什么时候执行这个线程，
            //由cpu决定
            th.IsBackground = true;
            th.Start();
        }

        private void Test()
        {
            for (int i = 0; i < 1000000; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
