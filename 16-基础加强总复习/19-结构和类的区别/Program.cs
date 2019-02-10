using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_结构和类的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型
            //结构：值类型
            //类：引用类型

            //声明的语法：class struct
            PersonClass pc = new PersonClass();

            //结构可以New？
            //在栈开辟空间    结构new   调用结构的构造函数
            PersonStruct ps = new PersonStruct();
            PersonStruct.M1();
            ps.M2();
            Console.ReadKey();


        }
    }

    public class PersonClass
    {
        //字段、属性、方法、构造函数
    }

    public struct PersonStruct
    {
        //字段、属性
        private string _name;
        public string Name
        {
            get { return _name; }
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

        public static void M1()
        {
            Console.WriteLine("我是结构中的静态方法");
        }

        public void M2()
        {
            Console.WriteLine("我是结构中的非静态方法");
        }
    }
}
