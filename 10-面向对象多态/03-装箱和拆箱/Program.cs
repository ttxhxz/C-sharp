using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //object o = n;//装箱
            //int nn = (int)o;//拆箱


            //ArrayList list = new ArrayList();

            //List<int> list = new List<int>();
            //Stopwatch sw = new Stopwatch();
            ////00:00:00.6434104——ArrayList

            ////00:00:00.0565938——List<T>
            //sw.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //这个地方没有发生任何类型的装箱或者拆箱
            //string str = "123";
            //int n = Convert.ToInt32(str);

            int n = 10;
            IComparable i = n;//装箱

            Console.ReadKey();
        }
    }
}
