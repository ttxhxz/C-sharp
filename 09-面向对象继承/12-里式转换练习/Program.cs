using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_里式转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建1个对象通过一个循环去调用他们各自打招呼的方法
            Person[] pers = new Person[10];
            Random r = new Random();
            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch (rNumber)//1-6
                {
                    case 1:
                        pers[i] = new Student();
                        break;
                    case 2:
                        pers[i] = new Teacher();
                        break;
                    case 3:
                        pers[i] = new ShuaiGuo();
                        break;
                    case 4:
                        pers[i] = new MeiNv();
                        break;
                    case 5:
                        pers[i] = new YeShou();
                        break;
                    case 6:
                        pers[i] = new Person();
                        break;
                }
            }

            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayHi();
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHi();
                }
                else if (pers[i] is ShuaiGuo)
                {
                    ((ShuaiGuo)pers[i]).ShuaiGuoSayHi();
                }
                else if (pers[i] is MeiNv)
                {
                    ((MeiNv)pers[i]).MeiNvSayHi();
                }
                else if (pers[i] is YeShou)
                {
                    ((YeShou)pers[i]).YeShouSayHi();
                }
                else
                {
                    pers[i].PersonSayHi();
                }
            }

            Console.ReadKey();
        }
    }

    public class Person
    {
        public void PersonSayHi()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Student : Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher : Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }
    }

    public class MeiNv : Person
    {
        public void MeiNvSayHi()
        {
            Console.WriteLine("我是美女");
        }
    }

    public class ShuaiGuo : Person
    {
        public void ShuaiGuoSayHi()
        {
            Console.WriteLine("我是甩锅");
        }
    }

    public class YeShou : Person
    {
        public void YeShouSayHi()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
