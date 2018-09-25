using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_switch_case练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入姓名，然后显示出这个人上辈子是什么职业。
            Console.WriteLine("请输入一个姓名，我们将显示出来这个人上辈子的职业:(老杨、老苏、老马、老蒋、老牛、老虎、老赵)");
            string name = Console.ReadLine();
            //老杨、老苏、老马、老蒋、老牛、老虎、老赵
            switch (name)
            {
                case "老杨":
                    Console.WriteLine("上辈子是抽大烟的");
                    break;
                case "老苏":
                    Console.WriteLine("上辈子是个老鸭子");
                    break;
                case "老马":
                    Console.WriteLine("上辈子是老苏手下的头牌");
                    break;
                case "老蒋":
                    Console.WriteLine("上辈子是拉皮条的");
                    break;
                case "老牛":
                    Console.WriteLine("上辈子是一坨翔");
                    break;
                case "老虎":
                    Console.WriteLine("上辈子是个大病猫");
                    break;
                case "老赵":
                    Console.WriteLine("上辈子是光芒万丈救苦救难的菩萨呀");
                    break;
                default:
                    Console.WriteLine("不认识，估计是一坨翔");
                    break;
            }
            Console.ReadKey();

        }
    }
}
