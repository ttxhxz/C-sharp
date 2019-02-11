using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_为什么要使用委托
{
    public delegate string DelProStr(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //三个需求
            //1、将一个字符串数组中每个元素都转换成大写
            //2、将一个字符串数组中每个元素都转换成小写
            //3、将一个字符串数组中每个元素两边都加上双引号
            string[] names = { "dsadFSDdasd", "fdasbgGYUgUGG", "fdsFF" };
            //ProStr(names, ProStrSYH);
            //ProStr(names, ProStrToLower);
            //ProStr(names, ProStrToUpper);
            ProStr(names, delegate (string name)
            {
                //return name.ToLower();
                //return name.ToUpper();
                return "\"" + name + "\"";
            });

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }

        public static void ProStr(string[] name, DelProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }

        public static string ProStrToUpper(string name)
        {
            return name.ToUpper();
        }

        public static string ProStrToLower(string name)
        {
            return name.ToLower();
        }

        public static string ProStrSYH(string name)
        {
            return "\"" + name + "\"";
        }

        //public static void ProStrToUpper(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToUpper();
        //    }
        //}

        //public static void ProStrToLower(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToLower();
        //    }
        //}

        //public static void ProStrSYH(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = "\"" + name[i] + "\"";
        //    }
        //}
    }
}
