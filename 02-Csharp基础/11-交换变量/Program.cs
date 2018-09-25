using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            Console.WriteLine("交换前n1：{0}，n2：{1}", n1, n2);
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            //Console.WriteLine("交换后n1：{0}，n2：{1}", n1, n2);

            //交换两个int类型的变量，要求：不使用第三方变量
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
            Console.WriteLine("交换后n1：{0}，n2：{1}", n1, n2);
            Console.ReadKey();

        }
    }
}
