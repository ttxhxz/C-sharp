using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_if结构的三个联系
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入年龄，如果输入的年龄大于23（含，则给用户显示你到了结婚的年龄了.
            Console.WriteLine("请输入你的年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 32)
            {
                Console.WriteLine("你可以结婚啦");
            }
            Console.ReadKey();
        }
    }
}
