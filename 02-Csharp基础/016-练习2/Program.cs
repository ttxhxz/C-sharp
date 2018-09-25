using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习：编程实现107653秒是几天几小时几分钟几秒？
            int totalSecond = 107653;

            //修改上面的题目，让用户输入.小时（Hour）,分钟（Minute）,秒（Seconds）

            int temp = totalSecond;
            int day = temp / (24 * 60 * 60);
            temp = temp % (24 * 60 * 60);
            int hour = temp / (60 * 60);
            temp = temp % (60 * 60);
            int minute = temp / 60;
            int sencond = temp % 60;
            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", totalSecond, day, hour, minute, sencond);
            Console.ReadKey();

        }
    }
}
