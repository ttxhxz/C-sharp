using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_继承
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class People
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

        public People(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        //public People()
        //{
        //}

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }

    public class Student : People
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            this.Id = id;
        }

        public void Study()
        {
            Console.WriteLine("学习");
        }
    }

    public class Teacher : People
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public Teacher(string name, int age, char gender, double salary) : base(name, age, gender)
        {
            this.Salary = salary;
        }

        public void Teach()
        {
            Console.WriteLine("讲课");
        }
    }

    public class Driver
    {
        private int _driverTime;
        public int DriverTime
        {
            get { return _driverTime; }
            set { _driverTime = value; }
        }

        public void Drive()
        {
            Console.WriteLine("开车");
        }
    }
}
