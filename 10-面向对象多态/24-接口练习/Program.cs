using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //麻雀会飞 鹦鹉会飞 鸵鸟不会飞 企鹅不会飞 直升机会飞
            //用多态来实现
            //虚方法，抽象类，接口

            IFlyable fly = new Plane();//new MaQue();//new YingWu();
            fly.Fly();
            Console.ReadKey();

        }
    }

    public class Bird
    {
        public double Wings
        {
            get;
            set;
        }

        public void EatAndDrink()
        {
            Console.WriteLine("我会吃喝");
        }
        //public abstract void Fly();
        //public void Fly()
        //{
        //    Console.WriteLine("会飞");
        //}
    }

    public class MaQue : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }

    public class YingWu : Bird, IFlyable,ISpeak
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }

        public void Speak()
        {
            Console.WriteLine("鹦鹉可以学习人类说话");
        }
    }

    public class TuoBird : Bird
    {

    }

    public class QQ : Bird
    {

    }
    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("直升飞机转动螺旋桨飞行");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public interface ISpeak
    {
        void Speak();
    }
}
