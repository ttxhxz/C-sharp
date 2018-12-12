using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字计算这两个数字之间所有整数的和
            //1、用户只能输入数字
            //2、计算两个数字之间和
            //3、要求第一个数字必须比第二个数字小就重新输入
            Console.WriteLine("请输入第一个数字");
            string strNumberOne = Console.ReadLine();
            int numberOne = GetNumber(strNumberOne);
            Console.WriteLine("请输入第二个数字");
            string strNumberTwo = Console.ReadLine();
            int numberTwo = GetNumber(strNumberTwo);

            JudgeNumber(ref numberOne, ref numberTwo);
            //求和
            int sum = GetSum(numberOne, numberTwo);
            Console.WriteLine(sum);
            Console.ReadKey();


        }

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
                    Console.WriteLine("输入有误！！！请重新输入");
                    s = Console.ReadLine();

                }
            }
        }

        public static void JudgeNumber(ref int n1, ref int n2)
        {
            while (true)
            {
                if (n1 < n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数字不能大于或等于第二个数字，请重新输入第一个数字：");
                    n1 = GetNumber(Console.ReadLine());
                    Console.WriteLine("请重新输入第二个数字：");
                    n2 = GetNumber(Console.ReadLine());
                }
            }
        }

        public static int GetSum(int n1, int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
