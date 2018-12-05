using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_方法练习
{
    class Program
    {
        //方法的功能一定要单一！！！！！！！！
        static void Main(string[] args)
        {
            //1.读取输入的整数，定义成方法
            //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入）
            Console.WriteLine("请输入一个数字：");
            string input = Console.ReadLine();
            int number = GetNumber(input);
            Console.WriteLine(number);

            Console.ReadKey();

        }
        //4、方法中最忌讳的就是出现提示用户输入的字眼

        /// <summary>
        /// 这个方法需要判断用户的输入是否是数字
        /// 如果是数字，则返回
        /// 如果不是数字，提示用户重新输入
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }
        
    }
}
