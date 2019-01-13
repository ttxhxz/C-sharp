using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型：int double char decimal bool enum struct
            //引用类型：string 数组 自定义类 集合 object 接口

            //值传递和引用传递
            //int n1 = 10;
            //int n2 = n1;
            //n2 = 20;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);


            //Person p1 = new Person();
            //p1._name = "张三";
            ////Person p2 = new Person();
            //Person p2 = p1;
            //p2._name = "李四";
            //Console.WriteLine(p1._name);
            //Console.WriteLine(p2._name);

            string s1 = "张三";
            string s2 = s1;
            s2 = "李四";
            Console.WriteLine(s1);
            Console.WriteLine(s2);


            Console.ReadKey();

        }
    }

    public class Person
    {
        public string _name;
    }
}
