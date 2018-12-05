using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_方法的两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //2还记得学循环时做的那道题吗？只允许用户输入y或n，请改成方法
            //Console.WriteLine("请输入y或者n：");
            //string str = Console.ReadLine();
            //Console.WriteLine(GetYN(str));
            //Console.ReadKey();

            //3查找两个整数中的最大值：int Max（int i1，int i2)
            //int n1 = 1027;
            //int n2 = 1018;
            //Console.WriteLine(Max(n1,n2));
            //Console.ReadKey();
            //4计算输入数组的和：int Sum（int[] values)
            int[] arrays = { 1, 2, 5, 8, 46, 46, 456, 456, 456, 456, 456 };
            Console.WriteLine(Sum(arrays));
            Console.ReadKey();
        }
        
        /// <summary>
        /// 判断字符串是否为y或者n，
        /// 如果是，则返回
        /// 如果不是，则会要求重新输入
        /// </summary>
        /// <param name="str">需要判断的字符串</param>
        /// <returns>返回y或者n</returns>
        public static string GetYN(string str)
        {
            while (true)
            {
                if(str =="y" ||str == "n")
                {
                    return str;
                }
                else
                {
                    Console.WriteLine("请重新输入y或者n：");
                    str = Console.ReadLine();
                }
            }
        }

        /// <summary>
        /// 查找两个整数中的最大值
        /// </summary>
        /// <param name="i1">第一个整数</param>
        /// <param name="i2">第二个整数</param>
        /// <returns>返回最大值</returns>
        public static int Max(int i1,int i2)
        {
            return i1 > i2 ? i1 : i2;
        }

        /// <summary>
        /// 计算输入数组的和
        /// </summary>
        /// <param name="values">输入的数组</param>
        /// <returns>返回数组的和</returns>
        public static int Sum(int[] values)
        {
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }
            return sum;
        }

    }
}
