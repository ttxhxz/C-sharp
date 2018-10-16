using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_for循环 
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("欢迎来到LoveSSJ:{0}", i);
            }
            Console.ReadKey();
        }
    }
}
