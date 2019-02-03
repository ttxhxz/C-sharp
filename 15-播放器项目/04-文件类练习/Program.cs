using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_文件类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //C:\Users\liuwe\Desktop
            //案例：对职工工资文件处理，所有人的工资加倍                 //然后输出到新文件
            //文件案例：
            //马大哈|3000
            //宋江|8000

            string[] strs = File.ReadAllLines(@"C:\Users\liuwe\Desktop\工资.txt", Encoding.UTF8);
            for (int i = 0; i < strs.Length; i++)
            {
                string[] strNew = strs[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                //int salary = Convert.ToInt32(strNew[1]) * 2;
                //int salary = int.Parse(strNew[1]) * 2;
                int salary;
                int.TryParse(strNew[1], out salary);
                strs[i] = strNew[0] + "|" + salary;

            }

            File.WriteAllLines(@"C:\Users\liuwe\Desktop\工资.txt", strs, Encoding.UTF8);
            Console.ReadKey();


        }
    }
}
