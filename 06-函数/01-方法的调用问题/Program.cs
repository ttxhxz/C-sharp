using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_方法的调用问题
{
    class Program
    {
        //字段 属于类的字段
        public static int _number = 10;


        static void Main(string[] args)
        {
            int a = 3;
            Test(a);
        }

        public static int Test(int a)
        {
            return a = a + 5;
        }
    }
}
