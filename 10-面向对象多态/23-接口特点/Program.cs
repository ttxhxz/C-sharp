using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new Person();
            IFlyable fly = new Bird();
            fly.Fly();
            Console.ReadKey();

        }
    }

    public class Person : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }

    public class Student : Person, IFlyable
    {

    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }

    public interface IFlyable
    {
        //不允许有访问修饰符  默认为public
        //方法·、自动属性（因为自动属性的getset没有方法体）、本质上都是方法
        void Fly();
    }

    public interface M1
    {
        void Test1();
    }

    public interface M2
    {
        void Test2();
    }

    public interface M3
    {
        void Test3();
    }

    public interface SuperInterface : M1, M2, M3
    {

    }

    public class car : SuperInterface
    {
        public void Test1()
        {
            
        }

        public void Test2()
        {
            
        }

        public void Test3()
        {
            
        }
    }
}
