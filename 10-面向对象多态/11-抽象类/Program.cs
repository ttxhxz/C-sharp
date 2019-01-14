using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal b = new Dog(20);
            b.Bark();

            Animal c = new Cat(10);
            c.Bark();

            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }


        public Animal(int age)
        {
            this.Age = age;
        }

        public abstract void Bark();

        public abstract string Name
        {
            get;
            set;
        }
    }

    public class Dog : Animal
    {
        public Dog(int age) : base(age)
        {
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }
    }

    public class Cat : Animal
    {
        public Cat(int age) : base(age)
        {
        }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }
    }

}
