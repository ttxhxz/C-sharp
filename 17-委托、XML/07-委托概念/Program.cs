using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_委托概念
{
    public delegate void DelSayHi(string name);

    class Program
    {
        static void Main(string[] args)
        {

            Test("张三", SayHiCn);
            Test("Ori", SayHiEn);

            Console.ReadKey();


        }

        public static void Test(string name, DelSayHi del)
        {
            del(name);
        }

        public static void SayHiCn(string name)
        {
            Console.WriteLine("吃了吗？" + name);

        }

        public static void SayHiEn(string name)
        {
            Console.WriteLine("Nice to meet you " + name);

        }
    }
}
