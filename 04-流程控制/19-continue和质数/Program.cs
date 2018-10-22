using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_continue和质数
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出100内所有的素数
            //素数/质数         只能被1和它本身整除的数字
            for (int i = 2; i <= 100; i++)
            {
                bool isPrimeNum = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % 2 == 0)
                    {
                        isPrimeNum = false;
                        break;
                    }
                }
                if (isPrimeNum)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.ReadKey();

        }
    }
}
