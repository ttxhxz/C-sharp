using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_集合练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 集合练习1
            //案例：把分拣奇偶数的程序用泛型实现。 int[] nums={1,2,3,4,5,6,7,8,9}奇数在左边偶数在右边
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listJi = new List<int>();
            //List<int> listOu = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(nums[i]);

            //    }
            //}
            //listJi.AddRange(listOu);
            //foreach (int num in listJi)
            //{
            //    Console.Write(num + "\t");
            //}
            #endregion

            #region 集合练习2
            //练习1：将int数组中的奇数放到一个新的int数组中返回。
            //将数组中的奇数取出来放到一个集合中，最终将集合转换成数组。
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listJi = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 != 0)
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}
            //int[] numsNew = listJi.ToArray();
            //foreach (var item in numsNew)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 集合练习3
            //练习2：从一个整数的List<int>中取出最大数（找最大值）。
            //List<int> nums = new List<int>() { 1, 5, 81, 21, 51, 2, 51, 2, 51, 2, 5, 1, 2, 1, 2, 4 };
            //int max = nums[0];
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    if (max < nums[i])
            //    {
            //        max = nums[i];
            //    }
            //}
            //Console.WriteLine("最大值为：{0}", max);

            #endregion

            #region 集合练习4
            //练习：把123转换为：一二三。 Dictionary《char，char》
            //1一2二3三4四5五6六7七8八9九
            //string str = "0零 1一 2二 3三 4四 5五 6六 7七 8八 9九";
            //Dictionary<char, char> dic = new Dictionary<char, char>();
            //string[] strs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    dic.Add(strs[i][0], strs[i][1]);
            //}
            //string input = "45461211561103!!!!!";

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (dic.ContainsKey(input[i]))
            //    {
            //        Console.Write(dic[input[i]]);
            //    }
            //    else
            //    {
            //        Console.Write(input[i]);
            //    }
            //}

            #endregion

            #region 集合练习5
            //练习：计算字符串中每种字符出现的次数（面试题）。"Welcome to
            //China world"，不区分大小写，打印"W 2""e 2""o 3"......
            //·提示： Dictionary<char，int>，char的很多静态方法。 char.IsLetter()
            //string str = "Welcome to China world";
            //Dictionary<char, int> dic = new Dictionary<char, int>();

            //for (int i = 0; i < str.Length; i++)
            //{
            //    //统一转换成小写字母
            //    char ch = char.ToLower(str[i]);
            //    if (dic.ContainsKey(ch))
            //    {
            //        dic[ch]++;
            //    }
            //    else
            //    {
            //        dic.Add(ch, 1);
            //    }

            //}

            //foreach (KeyValuePair<char, int> kv in dic)
            //{
            //    Console.WriteLine("字符{0}出现了{1}次", kv.Key, kv.Value);
            //}

            #endregion

            #region 集合练习6
            //案例：两个(ArrayList)集合{"a","b","c","d","e"}和{"d","e","f","g","h"}
            //把这两个集合去除重复项合并成一个
            ArrayList arrayOne = new ArrayList() { "a", "b", "c", "d", "e" };
            ArrayList arrayTwo = new ArrayList() { "d", "e", "f", "g", "h" };
            for (int i = 0; i < arrayOne.Count; i++)
            {
                if (!arrayTwo.Contains(arrayOne[i]))
                {
                    arrayTwo.Add(arrayOne[i]);
                }
            }

            foreach (var item in arrayTwo)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.ReadKey();


        }
    }
}
