using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_复习
{
    public class Person
    {
        //字段、属性、方法、构造函数
        //字段：存储数据
        //属性：保护字段，对字段的取值和设值进行限定
        //方法：描述对象的行为
        //构造函数：初始化对象（给对象的每个属性依次的赋值）
        //类中的成员，如果不加访问修饰符，默认都是private

        string _name;
        ///<summary>
        ///属性的本质就是两个方法
        ///</summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "孙全")
                {
                    value = "孙全";
                }
                _name = value;
            }
        }

        int _age;
        public int Age
        {
            get
            {
                if (_age < 0 || _age > 100)
                {
                    _age = 0;
                }
                return _age;
            }
            set => _age = value;
        }

        char _gender;
        public char Gender { get => _gender; set => _gender = value; }

        public void SayHello()
        {
            Console.WriteLine("{0},{1},{2}", this.Name, this.Age, this.Gender);
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }

        public Person(string name, char gender) : this(name, 0, gender)
        {

        }

        public Person()
        {

        }
    }
}
