using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_while循环的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第一个练习
            //Console.WriteLine("请输入班级人数：");
            //int stuNum = Convert.ToInt32(Console.ReadLine());
            //int i = 0;
            //int scoreSum = 0;
            //while (i < stuNum)
            //{
            //    Console.WriteLine("请输入第{0}个学生的成绩:", i + 1);
            //    int temp = Convert.ToInt32(Console.ReadLine());
            //    scoreSum += temp;
            //    i++;
            //}
            //Console.WriteLine("班级学员的人数是{0}\t平均成绩是:{1}\t总成绩是:{2}。", stuNum, (scoreSum * 1.0) / stuNum, scoreSum);
            //Console.ReadKey();
            #endregion

            #region 第二个练习
            //char isCan = 'n';
            //int i = 0;
            //while (isCan == 'n' && i < 10)
            //{
            //    Console.WriteLine("这是我第{0}遍和你讲，这道题你会做了吗？会了(y),不会(n)",i+1);
            //    isCan = Convert.ToChar(Console.ReadLine());
            //    if (isCan == 'n')
            //        i++;
            //}
            //Console.WriteLine("放学啦！");
            //Console.ReadKey();
            #endregion

            #region 第三个练习
            int year = 2006;
            double stuNum = 80000;
            while (stuNum < 200000)
            {
                stuNum *= 1.25;
                year++;
            }
            Console.WriteLine("第{0}年，培训学员人数将到达20万人。", year);
            Console.ReadKey();
            #endregion
        }
    }
}
