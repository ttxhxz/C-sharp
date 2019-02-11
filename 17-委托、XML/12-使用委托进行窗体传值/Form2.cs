using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_使用委托进行窗体传值
{
    //声明一个委托
    public delegate void DelTest(string str);

    public partial class Form2 : Form
    {
        public DelTest _del;
        public Form2(DelTest del)
        {
            this._del = del;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text);
        }
    }
}
