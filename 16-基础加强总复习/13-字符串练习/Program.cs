using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。“abc““cba“
            //string str = "abcdefg";
            //char[] chs = str.ToCharArray();
            //Array.Reverse(chs);
            //foreach (var item in chs)
            //{
            //    Console.Write(item);
            //}


            //练习5：123-456--789--123-2把类似的字符串中重复符号去掉
            //既得到123-456-789-123-2.sp1it（）、
            string str = "123-456--789--123-2";
            string[] strs = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            str = string.Join("-", strs);
            Console.WriteLine(str);

            Console.ReadKey();

        }
    }
}
