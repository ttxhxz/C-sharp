using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader和StreamWriter操作字符
            //使用StreamReader来读取文本文件
            //using(StreamReader sr=new StreamReader(@"C:\Users\liuwe\Desktop\520ssj.txt", Encoding.UTF8))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}

            using (StreamWriter sw = new StreamWriter(@"C:\Users\liuwe\Desktop\new.txt", true))
            {
                //sw.Write("dsadadadsadas");
                sw.Write("阿达撒打算打打死不覆盖");
            }

            Console.ReadKey();
        }
    }
}
