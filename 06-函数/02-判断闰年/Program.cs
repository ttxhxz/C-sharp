using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //举例：写一个方法，判断一个年份是否是闰年
            bool a =IsLeapYear(2018);
            Console.WriteLine(a);
            Console.ReadKey();

        }

        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsLeapYear(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
    }
}
