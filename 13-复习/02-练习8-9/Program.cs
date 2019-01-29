using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_练习8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习8
            //8.请用户输入一个字符串，计算字符串中的字符个数，并输出。
            //Console.WriteLine("请输入一串字符串：");
            //string str = Console.ReadLine();
            //Console.WriteLine("字符个数为：{0}", str.Length);

            #endregion

            #region 练习9
            //9.用方法来实现：计算两个数的最大值。思考：方法的参数？返回值？扩展（*）：计算任
            //意多个数间的最大值（提示： params）


            //double max = GetMax(1, 2);
            double max = GetMax(1, 2, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("最大值为：{0:0.00}", max);

            #endregion

            Console.ReadKey();

        }

        public static double GetMax(double n, params double[] nums)
        {
            double max = n;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
    }
}
