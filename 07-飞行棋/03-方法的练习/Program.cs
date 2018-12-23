using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //100、计算任意多个数间的最大值(提示：params)
            //int[] nums = new int[] { 10, 11, 12, 13 };
            //int max = GetMax(nums);
            //int max = GetMax(5,1,4516,321,58,45,1,5,65,45);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //101、请通过冒泡排序法对证书数组{1,3,5,7,90,2,4,6,8,10}实现升序排序
            //int[] nums = new int[] { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //SortArray(nums);
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.ReadKey();

            //102、将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] strs = new string[] { "梅西", "卡卡", "郑大世","XXX" };
            string str = GetString(strs);
            Console.WriteLine(str);
            Console.ReadKey();




            //用方法来实现：请计算出一个整型数组的平均值。{1,3,5,7,93,33,4,4,6,8,10}
            //要求：计算结果如果有小数，则显示小数点后两位（四舍五入）
        }

        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static void SortArray(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }

        public static string GetString(string[] strs)
        {
            string str = "";
            for (int i = 0; i < strs.Length-1; i++)
            {
                str += strs[i] + "|";
            }
            str += strs[strs.Length - 1];
            return str;
        }
    }
}
