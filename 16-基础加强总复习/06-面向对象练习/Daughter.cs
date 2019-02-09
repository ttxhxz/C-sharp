using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_面向对象练习
{
    class Daughter : Father
    {
        public Daughter(string lastName, decimal property, string bloodType) : base(lastName, property, bloodType)
        {

        }

        public void Dance()
        {
            Console.WriteLine("女儿会跳舞");

        }
    }
}
