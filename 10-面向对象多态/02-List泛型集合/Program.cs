using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.AddRange(new int[] { 1, 2, 3, 4, 5 });
            list.AddRange(list);

            //list泛型集合可以转换为数组
            int[] nums = list.ToArray();
            List<int> listTwo = nums.ToList();


            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();

        }
    }
}
