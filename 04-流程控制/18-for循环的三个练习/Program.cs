using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_for循环的三个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：循环录入5个人的年龄并计算平均年龄，如果录入的数据出现负数或大于100的数，立即停止输入并报错. 用for
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的年龄（一共需要输入5个）：", i + 1);
            //    try
            //    {
            //        int age = int.Parse(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄不在正确范围内，程序退出！！！");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的年龄不正确，程序退出！！！");
            //        b = false;
            //        break;
            //    }
            //}

            //if (b)
            //    Console.WriteLine("5个人的平均年龄为：{0}", sum / 5.0);
            //Console.ReadKey();


            //练习2：在while中用break实现要求用户一直输入用户名和密码，只要不是admin、888888就一直提示要求重新输入，
            //如果正确则提登录成功   用while
            //string user = "";
            //string pw = "";
            //while (user != "admin" && pw != "888888")
            //{
            //    Console.WriteLine("请输入用户名：");
            //    user = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    pw = Console.ReadLine();
            //}
            //Console.WriteLine("登陆成功。"); 
            //Console.ReadKey();


            //练习3：1~100之间的整数相加，得到累加值大于20的当前数（比如：1 + 2 + 3 + 4 + 5 + 6 = 21）结果6 用for
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                if (sum > 20)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
