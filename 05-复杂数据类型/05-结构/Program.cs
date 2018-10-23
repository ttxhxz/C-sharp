using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_结构
{
    struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }

    enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            //xx大学管理系统
            //姓名，性别，年龄，系别，年级
            Person person;
            person._name = "LoveSSJ";
            person._age = 21;
            person._gender = Gender.男;
        }
    }
}
