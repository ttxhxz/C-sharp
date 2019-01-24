using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_线程和进程复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process[] p = Process.GetProcesses();
            //foreach (var item in p)
            //{
            //    Console.WriteLine(item);
            //}

            //Process p = new Process();
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\liuwe\Desktop\咬人猫.flv");
            //p.StartInfo = psi;
            //p.Start();

            Process.Start("calc");

            Console.ReadKey();

        }
    }
}
