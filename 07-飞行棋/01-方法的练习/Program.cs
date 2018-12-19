using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //“马龙”，“迈克尔乔丹”，“雷吉米勒”，“蒂姆邓肯”，“科比布莱恩特”}，请输出最长的
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongest(names);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //80、用方法来实现：请计算一个整数型数组的平均值。保留两位小数
            //int[] numbers = { 1, 2, 7 };
            //double avg = GetAvg(numbers);
            ////保留两位小数
            //string s = avg.ToString("0.00");
            //avg = Convert.ToDouble(s);
            //Console.WriteLine("{0}", avg);
            //Console.ReadKey();

            //写一个方法，用来判断用户输入的数字是不是质数
            //再写一个方法 要求用户只能输入数字 输入有误就让用户一直输入
            Console.WriteLine("请输入一个数字，我们将判断你输入的数字是否是质数：");
            string str = Console.ReadLine();
            int num = GetNumber(str);
            bool b = IsPrime(num);

            Console.WriteLine(b);
            Console.ReadKey();

        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// 输入一个字符串返回对应的数字
        /// </summary>
        /// <param name="strNumber"></param>
        /// <returns></returns>
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }


        /// <summary>
        /// 求一个字符串数组中最长的元素
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > max.Length)
                {
                    max = s[i];
                }
            }
            return max;
        }
    }
}
