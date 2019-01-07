using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\liuwe\Desktop\520ssj.txt");
            //string s = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(s);

            //string[] contents = File.ReadAllLines(@"C:\Users\liuwe\Desktop\520ssj.txt", Encoding.UTF8);
            //foreach (string item in contents)
            //{
            //    Console.WriteLine(item);
            //}

            //string s = File.ReadAllText(@"C:\Users\liuwe\Desktop\520ssj.txt", Encoding.UTF8);
            //Console.WriteLine(s);

            File.WriteAllLines(@"C:\Users\liuwe\Desktop\520ssj.txt", new string[] { "dsadad", "9876543210" });

            Console.ReadKey();

        }
    }
}
