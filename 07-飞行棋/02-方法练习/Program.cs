using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //95、接受输入后判断其等级并显示出来。判断依据如下:等级={(90-100)优;(80-89)良;(70-79)中;(60-69)差;(0-59)不及格;}
            //Console.WriteLine("请输入学生的分数:");
            //int score = Convert.ToInt32(Console.ReadLine());
            //string level = GetLevel(score);
            //Console.WriteLine("你的成绩是：{0}", level);
            //Console.ReadKey();

            //97、请将字符串数组（中国，美国，巴西，“澳大利亚"，“加拿大”）中的内容反转
            //string[] names = new string[] { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //ReverArray(names);
            //foreach (string str in names)
            //{
            //    Console.WriteLine("{0}", str);
            //}
            //Console.ReadKey();

            //98、写一个方法计算圆的面积和周长面积是pI*R*R    周长是2*Pi*r
            double r = 10;
            double area;
            double perimter;
            GetAreaPerimeter(r, out area, out perimter);
            Console.WriteLine("半径为{0}的圆\t面积是：{1:0.00}\t周长是：{2:0.00}", r, area, perimter);
            Console.ReadKey();
        }

        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9:
                    level = "优";
                    break;
                case 8:
                    level = "良";
                    break;
                case 7:
                    level = "中";
                    break;
                case 6:
                    level = "差";
                    break;
                case 5:
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    level = "不及格";
                    break;
                default:
                    level = "输入的成绩有误";
                    break;
            }
            return level;
        }

        public static void ReverArray(string[] strArray)
        {
            string temp = "";
            for (int i = 0; i < strArray.Length / 2; i++)
            {
                temp = strArray[i];
                strArray[i] = strArray[strArray.Length - i - 1];
                strArray[strArray.Length - i - 1] = temp;
            }
        }

        public static void GetAreaPerimeter(double r, out double area, out double perimter)
        {
            area = Math.PI * r * r;
            perimter = 2 * Math.PI * r;
        }
    }
}
