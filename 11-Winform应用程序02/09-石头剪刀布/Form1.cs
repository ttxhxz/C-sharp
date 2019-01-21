using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_石头剪刀布
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PlayGame(string str)
        {
            lblPlayer.Text = str;
            Player player = new Player();
            int playerNumber = player.ShowFist(str);
            Computer cpu = new Computer();
            int cpuNumber = cpu.ShowFist();
            lblComputer.Text = cpu.Fist;

            string result = CaiPan.Judge(playerNumber, cpuNumber);
            lblResult.Text = result;
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void btnCloth_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }
    }
}
