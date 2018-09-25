using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            //李四的年终工作评定，如果定为A级，则工资涨500元，如果定为B级，
            //则工资涨200元，如果定为C级，工资不变，如果定为D级工资降200元，
            //如果定为E级工资降500元.
            //设李四的原工资为5000，请用户输入李四的评级，然后显示李四来年的工资

            bool b = true;
            double salary = 5000;
            Console.WriteLine("请输入对李四的年终评定");//a b c d e
            string level = Console.ReadLine();
            switch (level)
            {
                case "A":
                    salary += 500;
                    break;

                case "B":
                    salary += 200;
                    break;
                case "C":
                    break;
                case "D":
                    salary -= 200;
                    break;
                case "E":
                    salary -= 500;
                    break;
                default:
                    Console.WriteLine("输入有误，程序退出。");
                    b = false;
                    break;
            }
            if (b)
                Console.WriteLine("李四的明年工资是:" + salary);

            Console.ReadKey();


            //0 0.5 1 1.5 2


        }
    }
}
