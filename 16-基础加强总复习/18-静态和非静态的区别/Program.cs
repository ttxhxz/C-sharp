using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_静态和非静态的区别
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class Persn
    {
        private static string _name;
        private int _age;
        public void M1()
        {

        }

        public static void M2()
        {

        }
    }

    public static class Student
    {
        //public string _name;
        public static void M1()
        {

        }

        //静态类不能有实例构造函数
        //public Student()
        //{

        //}

        //静态构造函数中不允许出现访问修饰符
        //public static Student()
        //{

        //}

        static Student()
        {

        }
    }
}
