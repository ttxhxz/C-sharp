using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_接口复习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 接口是什么？什么时候使用接口？使用接口的目的是什么？

        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Bird
    {
        //public void Fly()
        //{
        //    Console.WriteLine("大多数鸟都会飞");
        //}
    }

    public class Maque : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }

        //显式实现
        void IFlyable.Fly()
        {
            throw new NotImplementedException();
        }
    }
}
