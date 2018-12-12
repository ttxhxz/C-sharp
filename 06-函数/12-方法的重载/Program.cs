using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //M()
            Console.WriteLine(1);
            Console.WriteLine(1.4);
            Console.WriteLine(true);
            Console.WriteLine('c');
            Console.WriteLine("123");
            Console.WriteLine(5000m);
            Console.ReadKey();


        }

        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }

        public static double M(double d1, double d2)
        {
            return d1 + d2;
        }

        public static void M(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }

        public static string M(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
