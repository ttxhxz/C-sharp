using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_关键字_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter rep = new Reporter("记者", 11, '男', "偷拍");
            rep.SayHello();
            rep.Text();
            Console.ReadKey();
        }
    }

    public class Person
    {
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

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void SayHello()
        {
            Console.WriteLine("大家好，我是人类");
        }

        public void Text()
        {
            Console.WriteLine("测试");
        }
    }

    public class Reporter : Person
    {
        public Reporter(string name, int age, char gender, string hobby)
            : base(name, age, gender)
        {
            this.Hobby = hobby;
        }

        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        public void ReporterSayHello()
        {
            Console.WriteLine();
        }

        public new void SayHello()
        {
            Console.WriteLine("大家好，我是记者");
        }
    }

    public class Programmer : Person
    {
        public Programmer(string name, int age, char gender, int workYear)
            : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }
        private int _workYear;
        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }

        public void ProgrammerSayHello()
        {
            Console.WriteLine("大家好，我叫{0}，我今年{1}岁了，我是{2}生，我已经工作{3}年了", this.Name, this.Age, this.Gender, this.WorkYear);
        }

        public new void SayHello()
        {
            Console.WriteLine("大家好，我是程序员");
        }
    }
}
