using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream   操作字节
            ////1、创建FileStream对象
            //FileStream fs = new FileStream(@"C:\Users\liuwe\Desktop\520ssj.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 5];
            //int r = fs.Read(buffer, 0, buffer.Length);
            ////将字节数组中每一个元素按照指定的编码格式解码成字符串
            //string s = Encoding.UTF8.GetString(buffer, 0, r);
            ////关闭流
            //fs.Close();
            ////释放流所占用的资源
            //fs.Dispose();
            //Console.WriteLine(s);
            //Console.ReadKey();

            //使用FileStream来写入数据
            using (FileStream fsWrite = new FileStream(@"C:\Users\liuwe\Desktop\520ssj.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "看我有没有把你覆盖掉";
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.ReadKey();


            //StreamReader
        }
    }
}
