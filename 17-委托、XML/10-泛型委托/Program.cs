using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_泛型委托
{
    public delegate int DelCompare<T>(T t1, T t2);
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 35, 8, 753, 753, 3753, 53 };
            int max = GetMax<int>(nums, Compare);
            Console.WriteLine(max);

            string[] strs = new string[] { "dsaad", "sdsfsdfrg", "gfshs" };
            string str = GetMax<string>(strs, (string s1, string s2) =>
              {
                  return s1.Length - s2.Length;
              });
            Console.WriteLine(str);

            Console.ReadKey();

        }

        public static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static int Compare(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
