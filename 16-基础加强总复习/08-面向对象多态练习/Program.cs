using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_面向对象多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 作业：动物Animal都有吃Eat和叫Bark的方法，狗Dog和猫Cat叫的方法不一样
            //父类中没有实现所以考虑用抽象方法
        }
    }

    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Bark();
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗在汪汪叫");
        }

        public override void Eat()
        {
            Console.WriteLine("狗在吃东西");

        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫在喵喵叫");
        }

        public override void Eat()
        {
            Console.WriteLine("猫在吃东西");

        }
    }
}
