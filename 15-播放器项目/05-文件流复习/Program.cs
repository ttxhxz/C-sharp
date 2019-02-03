using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_文件流复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Filestream StreamReader StreamWriter
            //using (StreamReader sr = new StreamReader())
            using (FileStream fsRead = new FileStream(@"C:\Users\liuwe\Desktop\520ssj.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fsRead))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
