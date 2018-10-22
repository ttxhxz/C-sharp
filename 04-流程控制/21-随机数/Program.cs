using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生随机数
            //1.创建能够产生随机数的对象
            Random r = new Random();
            //2.让产生随机数的这个对象调用方法来产生随机数
            int num = r.Next(1, 10);
            Console.WriteLine(num);

            Console.ReadKey();

        }
    }
}
