using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //陈习，编程实现计算几天（如46天）是几周零几天.
            int num = 46;
            int week = num / 7;
            int day = num % 7;
            Console.WriteLine("{0}天是第{1}周零{2}天", num, week, day);
            Console.ReadKey();

        }
    }
}
