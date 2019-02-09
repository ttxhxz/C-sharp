using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_鸟_麻雀
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：鸟-麻雀 sparrow，驼鸟ostrich，
            //企鹅penguin。鹦鹉 parrot  
            //鸟能飞，鸵鸟企鹅不能飞
            
        }
    }

    public class Bird
    {
        public double Wings
        {
            get;
            set;
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀能飞");
        }
    }

    public class Ostrich : Bird
    {

    }

    public class Penguin : Bird
    {

    }

    public class Parrot : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉能飞");
        }
    }
}
