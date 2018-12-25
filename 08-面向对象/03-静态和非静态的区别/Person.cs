using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_静态和非静态的区别
{
    public class Person
    {
        private static string _name;
        private char _gender;

        public static string Name { get => _name; set => _name = value; }

        public void M1()
        {
            Console.WriteLine("我是非静态的方法");
        }

        public static void M2()
        {
            Console.WriteLine("我是静态的方法");
        }
    }
}
