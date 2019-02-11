using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_单例模式
{
    public partial class Form2 : Form
    {
        //全局唯一单例
        public static Form2 FrmSingle = null;

        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetSingle()
        {
            if (FrmSingle == null)
            {
                FrmSingle = new Form2();
            }
            return FrmSingle;
        }
    }
}
