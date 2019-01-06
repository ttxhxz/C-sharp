using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求平均值与和
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int sum = 0;
            //foreach (var i in list)
            //{
            //    sum += (int)i;
            //}
            //Console.WriteLine("平均值是：{0}\t和是：{1}", sum / list.Count, sum);
            //Console.ReadKey();


            //写一个长度为10的集合，要求在里面随机地存放10个数字（0-9），
            //但是要求所有的数字不重复
            ArrayList list = new ArrayList();
            Random r = new Random();
            int i = 0;
            while (i < 10)
            {
                int rNumber = r.Next(0, 10);
                if (!list.Contains(rNumber))
                {
                    list.Add(r.Next(0, 10));
                    i++;
                }
            }

            foreach (var j in list)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();

        }
    }
}
