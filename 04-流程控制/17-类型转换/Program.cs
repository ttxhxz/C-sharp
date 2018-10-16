using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //int numberOne = Convert.ToInt32("123abc");

            //int number = int.Parse("123abc");
            //Console.WriteLine(number);

            int number = 100;
            bool b = int.TryParse("123s", out number);
            Console.WriteLine(b);
            Console.WriteLine(number);

            Console.ReadKey();

        }
    }
}
