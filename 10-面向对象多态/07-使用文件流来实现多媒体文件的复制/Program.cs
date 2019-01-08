using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_使用文件流来实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //思路：就是先将要复制的多媒体文件读取出来，然后再写入到你指定的位置
            string source = @"C:\Users\liuwe\Desktop\咬人猫.flv";
            string target = @"C:\Users\liuwe\Desktop\new.flv";

            CopyFile(source, target);

            Console.WriteLine("复制成功。");
            Console.ReadKey();

        }

        public static void CopyFile(string source, string target)
        {
            //1、创建一个负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    while (true)
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);

                        if (r == 0)
                            break;

                        fsWrite.Write(buffer, 0, r);
                    }
                }
            }
        }
    }
}
