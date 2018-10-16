using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1-100直接所有的整数和    偶数和    奇数和
            //int sum = 0;
            //int ji = 0;
            //int ou = 0;
            //for (int i = 1; i <=100 ; i++)
            //{
            //    sum += i;
            //    if (i % 2 == 0)
            //    {
            //        ou += i;
            //    }
            //    else
            //    {
            //        ji += i;
            //    }
            //}
            //Console.WriteLine("总和：{0}\t偶数和：{1}\t奇数和：{2}", sum, ou, ji);

            //找出100-999的水仙花数？
            //这个百位数的百位的立方+十位的立方+个位的立方==当前这个百位数字
            //1*1*1+5*5*5+3*3*3=153
            //百位：153/100
            //十位：153%100/10
            //个位：153%10
            for (int i = 100; i <= 999; i++)
            {
                int hundred = i / 100;
                int ten = i % 100 / 10;
                int digit = i % 10;
                int sum = hundred * hundred * hundred + ten * ten * ten + digit * digit * digit;
                if (sum == i)
                {
                    Console.WriteLine("水仙花数有:{0}", i);
                }
            }

            Console.ReadKey();

        }
    }
}
