using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_lamda表达式
{
    public delegate void DelOne();
    public delegate void DelTwo(string name);
    public delegate string DelThree(string name);

    class Program
    {
        static void Main(string[] args)
        {
            DelOne del = () => { };//delegate () { };
            DelTwo del2 = (string name) => { };//delegate (string name) { };
            DelThree del3 = (string name) => { return name; };//delegate (string name) { return name; };

            List<int> list = new List<int>() { 1, 2, 3, 5, 6, 7 };
            list.RemoveAll(n => n > 4);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
