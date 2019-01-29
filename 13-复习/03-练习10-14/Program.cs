using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_练习10_14
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 第10题
            //10.用方法来实现：计算1-100之间的所有整数的和。
            //int sum = GetSum();
            //Console.WriteLine("1-100之间的所有整数的和:{0}", sum);

            #endregion

            #region 第11题
            //11.用方法来实现：计算1-100之间的所有奇数的和。
            //int sum = GetJi();
            //Console.WriteLine("1-100之间的所有奇数的和:{0}", sum);

            #endregion

            #region 第12题
            //12.用方法来实现：判断一个给定的整数是否为“质数”
            //Console.WriteLine("请输入一个整数:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool isprime = IsPrime(num);
            //Console.WriteLine("是否为质数:{0}", isprime);

            //int j = 0;
            //for (int i = 0; i < 101; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        j++;
            //        Console.Write(i + "\t");
            //        if (j % 8 == 0)
            //            Console.WriteLine();
            //    }
            //}

            #endregion

            #region 第13题
            //13.用方法来实现：计算1-100之间的所有质数（素数）的和。
            int sum = 0;
            for (int i = 2; i < 101; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine("1-100之间所有质数(素数)的和为:{0}", sum);

            #endregion

            Console.ReadKey();

        }

        public static int GetSum()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static int GetJi()
        {
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 != 0)
                    sum += i;
            }
            return sum;
        }

        /// <summary>
        /// 是否质数
        /// </summary>
        /// <param name="num">需要判断的数字</param>
        /// <returns></returns>
        public static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
