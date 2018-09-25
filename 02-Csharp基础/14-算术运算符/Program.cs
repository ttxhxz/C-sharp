using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n1 = 10;
            //int n2 = 3;
            //int result = n1 / n2;
            //Console.WriteLine(result);
            //Console.ReadKey();

            //演示：某学生三门课成绩为，语文：90数学：80英语：67，编程求总分和平均分。
            //int chinese = 91;
            //int math = 80;
            //int english = 67;
            //int sum = chinese + math + english;
            //float avg = sum / 3f;
            //Console.WriteLine("总成绩是：{0},平均成绩是：{1}", sum, avg);
            //Console.ReadKey();

            //练习2:计算半径为5的圆的面积和周长并打印出来.(pi为3.14)面积pi*r*r;Perimeter
            //int r = 5;
            //double area = 3.14 * r * r;
            //double perimeter = 2 * 3.14 * r;
            //Console.WriteLine("圆的面积是：{0}，周长是{1}。", area, perimeter);

            //练习3：某商店T恤（T-shirt）的价格为35元/件，裤子（trousers）的价格为120元/条.
            //小明在该店买了3件T恤和2条裤子，请计算并显示小明应该付多少钱？
            //打8.8折后呢？
            //int t_shirt = 35;
            //int trousers = 120;
            //int totalMoney = 3 * t_shirt + 2 * trousers;
            //Console.WriteLine(totalMoney);
            //double realMoney = totalMoney * 0.88;
            //Console.WriteLine("realMoney" + realMoney);

            int number = 10;
            double d = number/3.0;//自动类型转换，隐式类型转换
            Console.WriteLine("{0:0.0000}", d);

            Console.ReadKey();
        }
    }
}
