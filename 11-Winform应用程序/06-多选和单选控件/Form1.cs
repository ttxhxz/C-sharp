using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_多选和单选控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;

            if (rdoStudent.Checked)
            {
                if (name == "student" && pwd == "student")
                {
                    MessageBox.Show("登陆成功");
                }
                else
                {
                    MessageBox.Show("登陆失败");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();

                }
            }
            else
            {
                if (name == "teacher" && pwd == "teacher")
                {
                    MessageBox.Show("登陆成功");
                }
                else
                {
                    MessageBox.Show("登陆失败");
                    txtName.Text = "";
                    txtPwd.Text = "";
                    txtName.Focus();

                }
            }
        }
    }
}
