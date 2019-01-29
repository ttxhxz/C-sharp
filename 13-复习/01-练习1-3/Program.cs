using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_练习1_3
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 第一题
            //编写一段程序，运行时向用户提问“你考了多少分？（0-100）”，
            //接受输入后判断其等级并显示出来。为断依据如下：等级-优（90-100分）；良（80-89分）；(70-79)中（60-69分差（0 - 59分）；}

            //Console.WriteLine("你考了多少分？");
            //int score = Convert.ToInt32(Console.ReadLine());
            //string level = GetLevel(score);
            //Console.WriteLine("你成绩的等级为:{0}", level);
            #endregion

            #region 第二题
            //ChengFa();
            #endregion

            #region 第三题
            //定以长度50的数组，随机给数组赋值，并可以让用户输入一个数字n，按行n个数输出数组
            //int[] array new int[50];  Random r =new Random()； r.Next()

            //int[] nums = new int[50];
            //Random r = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = r.Next(0, 10);
            //}
            //Console.WriteLine("请输入一个数字n:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("{0}\t", nums[i]);
            //    if ((i + 1) % n == 0)
            //        Console.WriteLine();

            //}

            #endregion

            #region 第四题
            //4.编写一个函数接收一个字符串把用户输入的字符串中的第一个字母转换成小写然后返
            //回命名规范骆驼命名）name
            //s SubString（0,1）
            //s Substring（1)

            //Console.WriteLine("请输入一个英文字符串:");
            //string str = Console.ReadLine();
            //string result = GetCamel(str);
            //Console.WriteLine(result);

            #endregion

            #region 第五题
            //5.编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成大写然后返
            //回（命名规范帕斯卡）

            //Console.WriteLine("请输入一个英文字符串:");
            //string str = Console.ReadLine();
            //string result = GetPascal(str);
            //Console.WriteLine(result);
            #endregion

            #region 第六题
            //声明两个变量：int n1 = 10，n2 = 20要求将两个变量交换，最后输出n为20，n2为10
            //扩展（*）：不使用第三个变量如何交换？
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine("交换前：n1:{0}\tn2:{1}", n1, n2);
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.WriteLine("交换后：n1:{0}\tn2:{1}", n1, n2);


            #endregion

            Console.ReadKey();

        }

        public static string GetLevel(int score)
        {
            string str = "";
            if (score >= 90 && score <= 100)
            {
                str = "优";
            }
            else if (score >= 80 && score <= 89)
            {
                str = "良";
            }
            else if (score >= 70 && score <= 79)
            {
                str = "中";
            }
            else if (score >= 60 && score <= 69)
            {
                str = "差";
            }
            else if (score >= 0 && score <= 59)
            {
                str = "不及格";
            }
            else
            {
                str = "输入的成绩超出了范围";
            }
            return str;
        }

        public static void ChengFa()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();

            }
        }


        public static string GetCamel(string str)
        {
            string ch = str.Substring(0, 1);
            ch = ch.ToLower();
            return ch + str.Substring(1);
        }

        public static string GetPascal(string str)
        {
            string ch = str.Substring(0, 1);
            ch = ch.ToUpper();
            return ch + str.Substring(1);
        }
    }
}
