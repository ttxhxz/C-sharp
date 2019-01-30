using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_练习25_计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(textBox1.Text.Trim());
                int n2 = Convert.ToInt32(textBox1.Text.Trim());

                string oper = comboBox1.SelectedItem.ToString();

                switch (oper)
                {
                    case "+":
                        label1.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        label1.Text = (n1 - n2).ToString();
                        break;
                    case "*":
                        label1.Text = (n1 * n2).ToString();
                        break;
                    case "/":
                        label1.Text = (n1 / n2).ToString();
                        break;
                    default:
                        MessageBox.Show("请选择正确的操作符");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("请输入正确的数字");
            }
        }
    }
}
