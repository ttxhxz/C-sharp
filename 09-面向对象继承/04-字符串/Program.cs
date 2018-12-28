using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串的不可变性
            //string name = "张三";
            //name = "孙全";
            //Console.WriteLine(name);

            //int a = 10;
            //int v = 10;
            //string s1 = "张三";
            //string s2 = "张三";

            string s = "addad";
            Console.WriteLine("{0}", s[0]);
            char[] sArray = s.ToCharArray();
            sArray[0] = 's';
            s = new string(sArray);
            Console.WriteLine("{0}", s[0]);

            Console.ReadKey();

        }
    }
}
