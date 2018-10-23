using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_结构体练习
{
    struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }

    enum Gender
    {
        男,
        女
    }
    struct Person
    {
        public string _name;
        public Gender _gender;
        public int _age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1.定义一个结构叫MyColor，有三个成员，分别定义为int类型的red，green，blue
            //声明一个MyColor类型的变量，并对其成员赋值.使MyColor可以表示成一个红色.
            //MyColor mc;
            //mc._red = 255;
            //mc._green = 0;
            //mc._blue = 0;

            //2定义一个结构类型Person，有三个成员，分别为姓名，性别，年龄性别用枚举类型
            //声明两个Person类型的变量，分别表示张三男18岁/小兰女16岁
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._gender = Gender.男;
            zsPerson._age = 18;

            Person xlPerson;
            xlPerson._name = "小兰";
            xlPerson._gender = Gender.女;
            xlPerson._age = 16;

            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", zsPerson._name, zsPerson._age, zsPerson._gender);
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", xlPerson._name, xlPerson._age, xlPerson._gender);

            Console.ReadKey();

        }
    }
}
