using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候 将年份添加到下拉框中
            //获得当前的年份
            int year = DateTime.Now.Year;

            for (int i = year; i >= 1949; i--)
            {
                cboYears.Items.Add(i + "年");
            }
        }

        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboMonths.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonths.Items.Add(i + "月");
            }
        }

        private void cboMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDays.Items.Clear();

            string strMonth = cboMonths.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];//返回的数组只接收0
            string strYear = cboYears.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];//返回的数组只接收0
            int year = Convert.ToInt32(strYear);
            int month = Convert.ToInt32(strMonth);

            int day = 0;//定义一个变量来存储天数

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:
                    day = 30;
                    break;
            }

            //MessageBox.Show(cboMonths.SelectedItem.ToString());


            for (int i = 1; i <= day; i++)
            {
                cboDays.Items.Add(i + "日");
            }
        }
    }
}
