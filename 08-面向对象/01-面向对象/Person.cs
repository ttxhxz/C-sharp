using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_面向对象
{
    public class Person
    {
        private string _name;
        public string Name
        {
            //当你获取属性的值的时候 会执行get方法
            get { return _name; }
            //当你给属性赋值的时候 首先会执行set方法
            set { _name = value; }
        }
        
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", this._name, this._age, this._gender);
        }
    }
}
