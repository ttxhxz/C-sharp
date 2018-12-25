using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = 10;
            p.Name = "dsddsf";
            p.Gender = '男';
            p.SayHello();

            Person p2 = new Person();
            p2.Name = "利息";
            p2.Age = 88;
            p2.Gender = '女';
            p2.SayHello();

        }
    }
}
