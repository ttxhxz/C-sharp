using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_匿名函数
{
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //Test("张三", SayHiCn);

            //DelSayHi del = SayHiCn;
            //匿名函数
            //DelSayHi del = delegate (string name)
            //  {
            //      Console.WriteLine("吃了吗？" + name);
            //  };

            //lamda表达式
            DelSayHi del = (string name) => { Console.WriteLine("吃了吗？" + name); };

            del("张三");



            Console.ReadKey();

        }

        //public static void Test(string name, DelSayHi del)
        //{
        //    del(name);
        //}

        //public static void SayHiCn(string name)
        //{
        //    Console.WriteLine("吃了吗？" + name);

        //}

        //public static void SayHiEn(string name)
        //{
        //    Console.WriteLine("Nice to meet you " + name);

        //}
    }
}
