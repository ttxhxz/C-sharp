using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输年份，再输入月份，输出该月的天数.（结合之前如何判断闰年来做）
            bool isLeapYear = false;
            int year = 0;
            int month = 0;
            int day = 0;
            try
            {
                Console.WriteLine("请输入年份：");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份：");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                        {
                            isLeapYear = true;
                        }

                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                day = 31;
                                break;
                            case 2:
                                if (isLeapYear)
                                    day = 29;
                                else
                                    day = 28;
                                break;
                            default:
                                day = 30;
                                break;
                        }
                        Console.WriteLine("{0}年的{1}月有{2}天。", year, month, day);
                    }
                    else
                    {
                        Console.WriteLine("您输入的月份不符合要求，程序结束。");
                    }
                }
                catch
                {
                    Console.WriteLine("您输入的月份有误，程序结束。");
                }
            }
            catch
            {
                Console.WriteLine("您输入的年份有误，程序结束。");
            }
            Console.ReadKey();
        }
    }
}
