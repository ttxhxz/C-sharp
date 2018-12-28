using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习4：文本文件中存储了多个文章标题、作者，
            //标题和作者之间用若干空格（数量不定）隔开，海微个，
            //标题有的长有的短，输出到控制台的时候最多标题长度10，
            //如果超过10，则截取长度8的子串并且最后添加“…”，加一个竖线后输出作者的名字。

            //string path = @"C:\Users\liuwe\Desktop\2.txt";
            //string[] contents = File.ReadAllLines(path);
            //foreach (string str in contents)
            //{
            //    StringBuilder strb = new StringBuilder();
            //    strb.Clear();
            //    string[] temps = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    if (temps[0].Length > 10)
            //    {
            //        strb.Append(temps[0].Substring(0, 8));
            //        strb.Append("......|" + temps[1]);
            //    }
            //    else
            //    {
            //        strb.Append(temps[0] + "|" + temps[1]);
            //    }
            //    Console.WriteLine(strb.ToString());
            //}

            //课上练习1，接收用户输入的字符串，将其中的字符以输入相反的顺序输出。"abc"→"cba”
            //1.倒序循环
            //string str = "LoveSSJ";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.WriteLine();

            //将字符串本身相反再输出
            //string str = "LoveSSJ";
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - i - 1];
            //    chs[chs.Length - i - 1] = temp;
            //}
            //str = new string(chs);
            //Console.WriteLine(str);



            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"-→"sharp c hello"
            //string str = "hello c sharp";
            //string[] strs = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strs.Length / 2; i++)
            //{
            //    string temp = strs[i];
            //    strs[i] = strs[strs.Length - i - 1];
            //    strs[strs.Length - i - 1] = temp;
            //}
            //1.用循环输出
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.Write(strs[i]);
            //    if (i != strs.Length - 1)
            //    {
            //        Console.Write(" ");
            //    }
            //}
            //2.用Join输出
            //str = string.Join(" ", strs);
            //Console.WriteLine(str);


            //课上练习3：Email中提取出用户名和域名：abc@163.com
            //string str = "abc@163.com";
            //string[] strs = str.Split('@');
            //Console.WriteLine("这个Email的用户名是：{0}\t域名是：{1}", strs[0], strs[1]);

            //让用户输入一句话，找出所有e的位置
            string str = "abcdeefgfefdfefdfefdfe";
            int index = -1;
            int i = 1;
            do
            {
                index = str.IndexOf('e', index + 1);
                if (index != -1)
                    Console.WriteLine("第{0}次出现e的位置是{1}", i, index+1);
                i++;
            } while (index != -1);
            Console.ReadKey();





        }
    }
}
