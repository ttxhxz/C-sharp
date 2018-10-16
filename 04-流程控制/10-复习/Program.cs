using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出。
            //string input = "";
            //while (input != "q")
            //{
            //    Console.WriteLine("请输入一个数字，输入q程序结束");
            //    input = Console.ReadLine();
            //    if (input != "q")
            //    {
            //        try
            //        {
            //            int num = Convert.ToInt32(input);
            //            Console.WriteLine("您输入的数字的2倍是{0}", num * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的字符串不能转换成数字，请重新输入：");
            //        }
            //    }
            //}
            //Console.ReadKey();

            //练习5：不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值
            string input = "";
            int max = 0;                                                                    
            while (input != "end")
            {
                Console.WriteLine("请输入一个正整数，输入end程序结束");
                input = Console.ReadLine();
                if (input != "end")
                {
                    try
                    {
                        int num = Convert.ToInt32(input);
                        if (num > max)
                            max = num;
                    }
                    catch
                    {
                        Console.WriteLine("输入的字符串不能转换成数字，请重新输入：");
                    }
                }
            }
            Console.WriteLine("刚才输入数字中的最大值是：{0}", max);
            Console.ReadKey();

        }
    }
}
