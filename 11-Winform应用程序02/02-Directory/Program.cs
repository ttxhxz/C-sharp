using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //File  Path    FileStream  StreamReader    StreamWriter
            //Directory 文件夹 目录

            //创建文件夹
            //Directory.CreateDirectory(@"F:\a");
            //Console.WriteLine("创建成功");

            //删除文件夹
            //Directory.Delete(@"F:\a", true);
            //Console.WriteLine("删除成功");

            //Directory.Move(@"F:\a", @"F:\备份\new");
            //Console.WriteLine("剪切成功");

            //获得指定文件夹下所有文件的全路径
            ////string[] path = Directory.GetFiles(@"F:\Hello");
            //string[] path = Directory.GetFiles(@"F:\LoveSSJ", "*.jpg");
            //foreach (var item in path)
            //{
            //    Console.WriteLine(item);
            //}

            //获得指定文件夹下所有文件夹的全路径
            //string[] path = Directory.GetDirectories(@"F:\Hello");
            //foreach (var item in path)
            //{
            //    Console.WriteLine(item);
            //}

            if (Directory.Exists(@"f:\a\b"))
            {
                Console.WriteLine("目录存在");
            }
            else
            {
                Console.WriteLine("目录不存在");
            }


            Console.ReadKey();

        }
    }
}
