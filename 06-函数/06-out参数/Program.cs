using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 求一个数组中的最大值、最小值、总和、平均值
        }

        /// <summary>
        /// 计算一个整数数组的最大值、最小值、平均值、总和
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="sum"></param>
        /// <param name="avg"></param>
        public static void Test(int[] nums, out int min, out int max, out int sum, out int avg)
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[1];
            sum = nums[2];
            avg = nums[3];
        }
    }
}
