using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象
            Person suQuan = new Person();
            suQuan.Name = "孙全";
            suQuan.Age = 23;
            suQuan.Gender = '男';
            suQuan.CHLSS();
            Console.ReadKey();
        }
    }
}
