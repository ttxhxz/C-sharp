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

namespace _05_简单记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWords.WordWrap = false;
            btnWordWrap.Visible = false;
            btnSave.Visible = false;
            txtWords.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;

            if (name == "admin" && pwd == "123456")
            {
                MessageBox.Show("欢迎━(*｀∀´*)ノ亻!");
                btnWordWrap.Visible = true;
                btnSave.Visible = true;
                txtWords.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                txtName.Visible = false;
                txtPwd.Visible = false;
                btnLogin.Visible = false;
                btnRest.Visible = false;
            }
            else
            {
                MessageBox.Show("用户名和密码错误，请重新输入");
                txtName.Text = "";
                txtPwd.Text = "";
                //让文本框获取焦点
                txtName.Focus();
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPwd.Text = "";
        }

        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            //先判断当前是否自动换行
            if (txtWords.WordWrap == true)
            {
                //取消自动换行
                txtWords.WordWrap = false;
                btnWordWrap.Text = "自动换行";
            }
            else
            {
                txtWords.WordWrap = true;
                btnWordWrap.Text = "取消自动换行";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite = new FileStream(@"C:\Users\liuwe\Desktop\save.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = txtWords.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
