using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_面向对象练习
{
    class Father
    {
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private decimal _property;
        public decimal Property
        {
            get { return _property; }
            set { _property = value; }
        }

        private string _bloodType;
        public string BloodType
        {
            get { return _bloodType; }
            set { _bloodType = value; }
        }

        public Father(string lastName, decimal property, string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0},我有{1}元，我是{2}型血", this.LastName, this.Property, this.BloodType);
        }
    }
}
