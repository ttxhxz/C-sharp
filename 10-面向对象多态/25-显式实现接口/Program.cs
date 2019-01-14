using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_显式实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //显式实现接口就是为了解决方法的重名问题
            IFlyable fly = new Bird();
            fly.Fly();
            Bird bird = new Bird();
            bird.Fly();
            Console.ReadKey();

        }
    }

    public class Bird : IFlyable
    {
        /// <summary>
        /// 显式实现接口
        /// </summary>
        void IFlyable.Fly()
        {
            Console.WriteLine("我是接口的飞");
        }

        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
    }

    public interface IFlyable
    {
        void Fly();
    }
}
