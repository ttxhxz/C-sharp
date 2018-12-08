using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法来交换两个int类型的变量
            int n1 = 10;
            int n2 = 20;
            SwapVar(ref n1, ref n2);
            Console.WriteLine("n1 = {0}", n1);
            Console.WriteLine("n2 = {0}", n2);
            Console.ReadKey();
        }

        public static void SwapVar(ref int n1,ref int n2)
        {
            //思路,n2=n1-n2+n2,n1=n1-(n1-n2)  
            //里面的n1和n2都是初始值，程序需要等价替换即可
            n1 = n1 - n2;//-10 20
            n2 = n1 + n2;//-10 10
            n1 = n2 - n1;//20  10
        }
    }
}
