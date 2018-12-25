using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_静态和非静态的区别
{
    public static class Student
    {
        private static string _name;

        public static string Name
        {
            get { return Student._name; }
            set { Student._name = value; }
        }

        public static void M1()
        {
            Console.WriteLine("Hello World");
        }
        
    }
}
