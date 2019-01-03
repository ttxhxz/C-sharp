using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_里式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //object
            //1、里式转换
            //1)、子类可以赋值给父类
            //2)、如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
            //Student s = new Student();
            //Person p = s;
            Person p = new Student();
            //2)、如果父类中装的是子类对象，那么可以将这个父类强转为子类对象
            //Student ss = (Student)p;
            //ss.StudentSayHello();

            //is的用法
            //if(p is Student)
            //{
            //    Student ss = (Student)p;
            //    ss.StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //as的用法
            Student t = p as Student;
            t.StudentSayHello();


            //string str = string.Join("|", new string[] { "1", "2", "3", "4" });
            //Console.WriteLine(str);


            Console.ReadKey();
        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是人类");
        }
    }

    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
