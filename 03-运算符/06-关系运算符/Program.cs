using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_关系运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //大象的重量(1500)>老鼠的重量(1)
            bool a = 1500 > 1;
            //兔子的寿命（3）>乌龟的寿命(1000)
            bool b = 3 > 1000;
            //我的年龄（20）==你的年龄（20）
            bool c = 20 == 20;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
