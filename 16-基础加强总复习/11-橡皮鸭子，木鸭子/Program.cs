using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_橡皮鸭子_木鸭子
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业 橡皮 rubber鸭子、木wood鸭子、真实的鸭子 realduck。三个鸭子都会游泳，
            //而橡皮鸭子和真实的鸭子都会叫只是叫声不一样，
            //橡皮鸭子"唧唧“叫，真实地鸭子“嘎嘎"叫 木鸭子不会叫
        }
    }

    public class Duck
    {
        public virtual void Swim()
        {
            Console.WriteLine("鸭子会游泳");
        }
    }

    public interface IBarkable
    {
        void Bark();
    }

    public class RubberDuck : Duck,IBarkable
    {
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");

        }

        public override void Swim()
        {
            Console.WriteLine("橡皮鸭子会游泳");
        }
    }

    public class WoodDuck : Duck
    {
        public override void Swim()
        {
            Console.WriteLine("木鸭子会游泳");
        }
    }

    public class RealDuck : Duck,IBarkable
    {
        public void Bark()
        {
            Console.WriteLine("真实的鸭子嘎嘎叫");

        }

        public override void Swim()
        {
            Console.WriteLine("真实的鸭子会游泳");
        }
    }
}
