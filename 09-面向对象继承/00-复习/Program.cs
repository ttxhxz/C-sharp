using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("张三", -18, '中');
            zsPerson.SayHello();
            Console.ReadKey();
            //new：1、在内存中开辟一块空间2、在开辟的创建对象3、调用对象的构造函数
        }
    }
}
