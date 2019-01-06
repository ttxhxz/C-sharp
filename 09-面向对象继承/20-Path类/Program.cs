using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"E:\Work\EmbeddedWindow\ReadMe.txt";
            Console.WriteLine(Path.GetFileName(str));
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            Console.WriteLine(Path.GetExtension(str));
            Console.WriteLine(Path.GetDirectoryName(str));
            Console.WriteLine(Path.GetFullPath(str));
            Console.WriteLine(Path.Combine(@"c:\a\", "b.txt"));

            //int index = str.LastIndexOf("\\");
            //str = str.Substring(index + 1);
            //Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
