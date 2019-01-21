using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_石头剪刀布
{
    public enum Result
    {
        玩家赢,
        电脑赢,
        平手
    }

    class CaiPan
    {


        public static string Judge(int playerNumber, int cpuNUmber)
        {
            if (playerNumber - cpuNUmber == 0)
            {
                return Result.平手.ToString();
            }
            else if ((playerNumber - cpuNUmber == -1) || (playerNumber - cpuNUmber == 2))
            {
                return Result.玩家赢.ToString();
            }
            else
            {
                return Result.电脑赢.ToString();
            }
        }
    }
}
