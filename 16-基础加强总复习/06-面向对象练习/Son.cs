using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_面向对象练习
{
    class Son : Father
    {
        public Son(string lastName, decimal property, string bloodType) : base(lastName, property, bloodType)
        {

        }

        public void PlayGame()
        {
            Console.WriteLine("儿子会打游戏");

        }
    }
}
