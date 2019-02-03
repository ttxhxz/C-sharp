using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"C:\Users\liuwe\Desktop\新建文件夹");
            //Directory.CreateDirectory(@"C:\Users\liuwe\Desktop\新建文件夹\新建文件夹");

            //Directory.Delete(@"C:\Users\liuwe\Desktop\新建文件夹");
            Directory.Delete(@"C:\Users\liuwe\Desktop\新建文件夹", true);

            Console.ReadKey();

        }
    }
}
