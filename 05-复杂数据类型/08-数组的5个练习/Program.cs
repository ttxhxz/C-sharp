using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_数组的5个练习
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 练习1
            ////练习1：从一个整数数组中取出最大的整数，最小整数，总和，平均值
            ////声明一个int类型的数组并且随意的赋初值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ////声明两个变量用来存储最大值和最小值
            //int max = nums[0];
            //int min = nums[0];
            //int sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (max < nums[i])
            //    {
            //        max = nums[i];
            //    }

            //    if (min > nums[i])
            //    {
            //        min = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", max, min, sum, sum * 1.0 / nums.Length);

            //Console.ReadKey(); 
            #endregion

            #region 练习3
            ////练习3：数组里面都是人的名字，分割成：例如：老杨|老苏|老邹.…”
            ////(老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马）
            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };
            //string nameStr = "";
            //for (int i = 0; i < names.Length; i++)
            //{
            //    nameStr += names[i];
            //    if (i < names.Length - 1)
            //    {
            //        nameStr += "|";
            //    }
            //}
            //Console.WriteLine(nameStr);
            //Console.ReadKey();

            #endregion

            #region 练习4
            //练习4：将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素的值加1，如果元素是负数则将这个位置的元素的值减1，
            //如果元素是0，则不变。
            //int[] nums = { 1, 2, 3, 4, 5, -1, -2, -3, -4, -5, 0 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i]++;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i]--;
            //    }
            //    Console.Write(nums[i]);
            //    if (i < nums.Length - 1)
            //    {
            //        Console.Write("\t");
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region 练习5
            //练习5：将一个字符串数组的元素的顺序进行反转。{ 我”，“是”，”好人”}
            //{“好人”，”是”，”我”}。第i个和第length - i - 1个进行交换。

            string[] strs = { "我", "是", "好人", "吗" };
            string temp = "";
            for (int i = 0; i < strs.Length / 2; i++)
            {
                temp = strs[i];
                strs[i] = strs[strs.Length - 1 - i];
                strs[strs.Length - 1 - i] = temp;
            }

            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(strs[i]);
                if (i < strs.Length - 1)
                {
                    Console.Write("\t");
                }
            }
            Console.ReadKey();

            #endregion

        }
    }
}
