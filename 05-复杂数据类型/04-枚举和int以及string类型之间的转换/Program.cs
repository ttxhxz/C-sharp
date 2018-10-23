using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_枚举和int以及string类型之间的转换
{
    enum QQState
    {
        OnLine = 1,
        offLine,
        Leave,
        Busy,
        QMe
    }

    class Program
    {
        static void Main(string[] args)
        {
            //QQState state = QQState.OnLine;
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine(state.ToString());

            //int n1 = 2;
            //QQState state = (QQState)n1;
            //Console.WriteLine(state);
            //string s = "0";
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state);

            //枚举练习
            //提示用户选择一个在线状态，我们接收，并将用户的输入转换成枚举类型
            //再次打印到控制太中
            Console.WriteLine("请选择您的qq在线状态 1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s1);
                    break;
                case "2":
                    QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s2);
                    break;
                case "3":
                    QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s3);
                    break;
                case "4":
                    QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
                case "5":
                    QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s5);
                    break;
            }

            Console.ReadKey();
        }
    }
}
