using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_键值对集合对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, '女');
            ht.Add(520, "SSJ");
            
            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abc", "cba");
            }
            else
            {
                Console.WriteLine("已经包含abc这个键");
            }

            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键是-----{0}========值是{1}", item, ht[item]);
            }
            Console.ReadKey();

        }
    }
}
