using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;
            Console.WriteLine(a);   //7
            Console.WriteLine(b);   //5+7*2+6+6=31
            Console.ReadKey();
        }
    }
}
