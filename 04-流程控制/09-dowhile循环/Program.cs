using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_dowhile循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //不断要求用户输入学生姓名，输入q结束
            string name = "";
            do
            {
                Console.WriteLine("请输入学生姓名，输入q结束：");
                name = Console.ReadLine();
            } while (name != "q");
            Console.ReadKey();

        }
    }
}
