using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_stringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //00:00:00.0097791
            StringBuilder sb = new StringBuilder();
            //00:00:09.4693002
            string str = null;
            //创建了一个计时器，用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                //str += i;
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();

        }
    }
}
