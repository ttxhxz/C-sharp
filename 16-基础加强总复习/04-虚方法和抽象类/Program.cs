using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_虚方法和抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            p.SayHello();
            Console.ReadKey();

        }
    }

    public abstract class Person
    {
        private string _name;


        public virtual void SayHello()
        {
            Console.WriteLine("我是Person");
        }

        public abstract double Test(string name);
    }

    public class Student : Person
    {
        public override double Test(string name)
        {
            return 1;
        }

        public void SayHello()
        {
            Console.WriteLine("我是Student");
        }
    }
}
