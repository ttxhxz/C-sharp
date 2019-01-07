using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_泛型集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边  偶数显示在右边。

            //int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> jishu = new List<int>();
            //List<int> oushu = new List<int>();
            //List<int> sum = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        oushu.Add(nums[i]);
            //    }
            //    else
            //    {
            //        jishu.Add(nums[i]);
            //    }
            //}
            //sum.AddRange(jishu);
            //sum.AddRange(oushu);
            //foreach (int item in sum)
            //{
            //    Console.Write("{0}\t", item);
            //}

            //Console.ReadKey();


            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            //Console.WriteLine("请输入一个字符串：");
            //string str = Console.ReadLine();
            //char[] chs = new char[str.Length];
            //int i = 0;
            //foreach (var item in str)
            //{
            //    chs[i] = item;
            //    i++;
            //}

            //Console.ReadKey();
            //统计 Welcome to China中每个字符出现的次数  不考虑大小写
            string s = "Welcome to China";
            string str = s.ToLower();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    continue;
                if (count.ContainsKey(str[i]))
                {
                    count[str[i]]++;
                }
                else
                {
                    count.Add(str[i], 1);
                }
            }


            Console.WriteLine("请输入你想查询的字符，请只输入一个：");
            string input = Console.ReadLine();
            input = input.ToLower();
            char c = input[0];
            if (count.ContainsKey(c))
            {
                int cNum = count[c];
                Console.WriteLine("{0}在字符串中共出现{1}次", c, cNum);
            }
            else
            {
                Console.WriteLine("{0}在字符串中共出现0次", c);
            }

            Console.ReadKey();
        }
    }
}
