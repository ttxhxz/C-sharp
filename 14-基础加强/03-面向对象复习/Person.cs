using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面向对象复习
{
    class Person
    {
        //字段、属性、构造函数、方法、接口
        string _name;
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

        public Person()
        {
            //this.Name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("{0}-------{1}---------{2}", this.Name, this.Age, this.Gender);
        }
    }
}
