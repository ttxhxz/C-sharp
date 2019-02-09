using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "张三";//GC
            //s1 = "李四";

            string s = "abcd";
            Console.WriteLine(s[0]);
            string s1 = "c#";
            string s2 = "C#";
            if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("相同");
            }
            else
            {
                Console.WriteLine("不相同");

            }

            Console.ReadKey();

        }
    }
}
