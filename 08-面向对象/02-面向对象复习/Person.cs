using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_面向对象复习
{
    public class Person
    {
        //字段、属性、方法
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0},{1}m{2}", this.Name, this.Age, this.Gender);
        }

    }
}
