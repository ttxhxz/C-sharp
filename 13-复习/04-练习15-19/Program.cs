using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_练习15_19
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 15
            //15.用方法来实现：有一个字符串数组：{“马龙”“迈克尔乔丹”，“嚅雷吉米勒“，蒂姆邓肯“，
            //科比布莱恩特”）请输出最长的字符串。
            //string str = GetMaxString(new string[] { "马龙", "耐克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩" });
            //Console.WriteLine("最长的字符串是：{0}", str);

            #endregion

            #region 16
            //用方法来实现：请计算出一个整型数组的平均值。{1，3，5，7，93，33，4，4，6，8，10}。要
            //求：计算结果如果有小数，则显示小数点后两位（四舍五入）。
            //int[] nums = new int[] { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            //double avg = GetAvg(nums);
            ////将它自身转换成保留两位小数
            //avg = Convert.ToDouble(avg.ToString("0.00"));
            ////Console.WriteLine("这个整型数组的平均值为：{0:0.00}", avg);
            //Console.WriteLine("这个整型数组的平均值为：{0}", avg);

            #endregion

            #region 17
            //请通过冒泡排序法对整数数组{1，3，5，7，90，2，4，6，8，10}实现升序排序。
            //int[] nums = new int[] { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Console.WriteLine("排序前：");
            //foreach (int item in nums)
            //{
            //    Console.Write(item + "\t");
            //}
            //SortArray(nums);
            //Console.WriteLine("\n排序后：");
            //foreach (int item in nums)
            //{
            //    Console.Write(item + "\t");
            //}
            //SortArray(nums);

            #endregion

            #region 18
            //为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，并给各个数组
            //元素指定一个1 - 100的随机值，然后计算平均成绩。


            //int[] scores = new int[30];
            //Random r = new Random();
            //int sum = 0;
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    scores[i] = r.Next(1, 101);
            //    sum += scores[i];
            //}

            //Console.WriteLine("30个学生的成绩为：");
            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.Write("{0}\t", scores[i]);
            //    if ((i + 1) % 10 == 0)
            //        Console.WriteLine();
            //}
            //Console.WriteLine("总成绩为：{0},\t平均成绩为：{1:0.00}", sum, sum * 1.0 / scores.Length);

            #endregion

            #region 19
            //有如下字符串：
            //【患者：“大夫，我咳嗽得很重。”
            //大夫：“你多大年记？”
            //患者：“七十五岁”
            //大夫：“二十岁咳嗽吗”
            //患者：“不咳嗽”
            //大夫：“四十岁时咳嗽吗？”
            //患者：“也不咳嗽。”
            //大夫：“那现在不咳嗽，还要等到什么时咳嗽？”】
            //需求：请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现
            //的索引位置。

            string str = "患者：“大夫，我咳嗽得很重。”大夫：“你多大年记？”患者：“七十五岁”大夫：“二十岁咳嗽吗”患者：“不咳嗽”大夫：“四十岁时咳嗽吗？”患者：“也不咳嗽。”大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";

            //第一种
            //List<int> index = new List<int>();
            //for (int i = 0; i < str.Length - 1; i++)
            //{
            //    if (str[i] == '咳' && str[i + 1] == '嗽')
            //    {
            //        index.Add(i);
            //    }
            //}
            //Console.WriteLine("“咳嗽”二字一共出现{0}次。索引分别为：", index.Count);
            //foreach (int item in index)
            //{
            //    Console.Write(item + "\t");
            //}

            //第二种
            //int index = str.IndexOf("咳嗽");
            //int i = 1;
            //Console.WriteLine("第1次出现咳嗽的位置是{0}", index);
            //while (index != -1)
            //{
            //    i++;
            //    index = str.IndexOf("咳嗽", index + 1);
            //    if (index == -1)
            //        break;
            //    Console.WriteLine("第{0}次出现咳嗽的位置是{1}", i, index);
            //}

            #endregion

            Console.ReadKey();

        }

        public static string GetMaxString(string[] strs)
        {
            string str = "";
            foreach (var item in strs)
            {
                if (item.Length > str.Length)
                {
                    str = item;
                }
            }
            return str;
        }

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            double avg = 0;
            foreach (int item in nums)
            {
                sum += item;
            }
            avg = sum / nums.Length;
            return avg;
        }

        /// <summary>
        /// 冒泡排序
        /// </summary>
        /// <param name="nums"></param>
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
    }
}
