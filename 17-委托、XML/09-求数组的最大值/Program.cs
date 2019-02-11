using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_求数组的最大值
{
    public delegate int DelCompare(object o1, object o2);

    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 1, 2, 3, 45, 54, 3, 456 };
            //int max = GetMax(nums);
            //Console.WriteLine(max);

            //string[] strs = new string[] { "dsadsad", "dsaa", "abfhshhgfhf" };
            //string maxStr = GetMax(strs);
            //Console.WriteLine(maxStr);

            //object[] nums = new object[] { 1, 2, 3, 45, 54, 3, 456 };
            object[] nums = new object[] { "dsadsad", "dsaa", "abfhshhgfhf" };
            object o = GetMax(nums, Compare);
            Console.WriteLine(o);


            Console.ReadKey();

        }

        public static object GetMax(object[] nums, DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int Compare(object o1, object o2)
        {
            //int n1 = (int)o1;
            //int n2 = (int)o2;
            //return n1 - n2;

            string s1 = (string)o1;
            string s2 = (string)o2;
            return s1.Length - s2.Length;
        }

        //public static int GetMax(int[] nums)
        //{
        //    int max = nums[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (max < nums[i])
        //        {
        //            max = nums[i];
        //        }
        //    }
        //    return max;
        //}

        //public static string GetMax(string[] names)
        //{
        //    string str = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (str.Length < names[i].Length)
        //        {
        //            str = names[i];
        //        }
        //    }
        //    return str;
        //}
    }


}
