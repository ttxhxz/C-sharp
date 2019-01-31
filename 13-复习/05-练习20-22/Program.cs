using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_练习20_22
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 20
            //将字符串“     hello      world,你    好 世界    ！   ”两端空格去掉，并且将其中的所有
            //其他空格都營换成一个空格，输岀结果为：“hello world，你 好 世界！”。
            //string str = "     hello      world,你    好 世界    ！   ";
            //str = str.Trim();
            //string[] sNew = str.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries); ;
            //str = string.Join(" ", sNew);
            //Console.WriteLine(str);

            #endregion

            #region 21
            //制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，当用户输入quit
            //（不区分大小写）时，程序停止接受用户的输入，并且显示出用户输入的学生的个数，
            //以及每个学生的姓名。效果如图
            //List<string> names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("请输入学员姓名,输入quit退出");
            //    string name = Console.ReadLine();

            //    if (name.ToLower() == "quit")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        names.Add(name);
            //    }
            //}
            //Console.WriteLine("您一共录入了：{0}个学生，姓名分别为:", names.Count);
            //foreach (string item in names)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 22
            //题目内容同上题，再增加一个显示姓“王”的同学的个数，此处不考虑复姓问题。

            List<string> names = new List<string>();
            int count = 0;
            while (true)
            {
                Console.WriteLine("请输入学员姓名,输入quit退出");
                string name = Console.ReadLine();

                if (name.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    names.Add(name);
                    if (name[0] == '王')
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("您一共录入了：{0}个学生，姓名分别为:", names.Count);
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("姓王的同学的个数为：{0}", count);

            #endregion

            #region 23
            //请将字符串数组{中国“，美国，巴西”澳大利亚”，咖拿大”}中的内容反转。然后输
            //出反转后的数组。不能用数组的 Reverse方法。
            //string[] countrys = new string[] { "中国", "美国", "巴西", "澳大利亚", "加拿大" ,"加一个"};
            //for (int i = 0; i < countrys.Length/2; i++)
            //{
            //    string temp = countrys[i];
            //    countrys[i] = countrys[countrys.Length-1-i];
            //    countrys[countrys.Length - 1 - i] = temp;
            //}

            //foreach (string item in countrys)
            //{
            //    Console.Write(item + "\t");
            //}

            #endregion

            #region 24
            //创建一个 Person类，属性：姓名、性别、年龄；方法： SayHi。再创建一个 Employee
            //类继承 Person类，扩展属性 salary重写SayHi方法。
            #endregion

            Console.ReadKey();

        }
    }

    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public virtual void SayHi()
        {
            Console.WriteLine("我是Person类");
        }
    }

    public class Employee : Person
    {
        public string Salary
        {
            get;
            set;
        }

        public override void SayHi()
        {
            Console.WriteLine("我是Employee类");
        }
    }
}
