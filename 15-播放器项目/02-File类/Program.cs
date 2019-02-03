using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //操作文件的
            //剪切 复制 创建 移除

            //File.Create(@"C:\Users\liuwe\Desktop\小熊猫.txt");
            //Console.WriteLine("创建成功");


            //File.Delete(@"C:\Users\liuwe\Desktop\小熊猫.txt");
            //Console.WriteLine("删除成功");

            //byte[] buffer = File.ReadAllBytes(@"C:\Users\liuwe\Desktop\1.txt");
            //string str = Encoding.UTF8.GetString(buffer,0,buffer.Length);
            //Console.WriteLine(str);
            //Console.WriteLine(str.Length);

            //File.WriteAllLines(@"C:\Users\liuwe\Desktop\2.txt",new string[] { "张三","李四","王五"}); ;

            File.AppendAllText(@"C:\Users\liuwe\Desktop\2.txt", "没有覆盖哦");

            Console.ReadKey();

        }
    }
}
