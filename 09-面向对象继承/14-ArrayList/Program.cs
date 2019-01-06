using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个集和对象
            ArrayList list = new ArrayList();
            //集和：很多数据的一个集和
            //数组：长度不可变、类型单一
            //集和的好处：长度可以任意改变 类型不固定
            list.Add(1);
            list.Add(3.14);
            list.Add(true);
            list.Add("张三");
            list.Add('男');
            list.Add(5000m);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();


        }
    }
}
