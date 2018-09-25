using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_接受用户的输入
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的姓名：");
            //string name = Console.ReadLine();

            //Console.WriteLine("您的姓名是：{0}", name);
            //Console.ReadKey();

            //1.练习：问用户喜欢吃什么水果（fruits），假如用户输入”苹果”，
            //则显示”哈哈，这么巧，我也喜欢吃苹果”
            //Console.WriteLine("美女，你喜欢吃什么水果啊？");
            //string str = Console.ReadLine();
            //Console.WriteLine("这么巧，我也喜欢吃{0}",str);
            //Console.ReadKey();


            //2.练习：请用户输入姓名性别年龄，当用户按下某个键子后在屏幕上显示：您好：XX您的年龄是XX是个X生
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("请输入你的性别：");
            string gender = Console.ReadLine();
            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();
            Console.WriteLine("您好：{0},您的年龄是{1}是个{2}生", name, age, gender);
            Console.ReadKey();
        }
    }
}
