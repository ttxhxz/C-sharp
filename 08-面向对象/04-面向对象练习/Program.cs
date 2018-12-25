using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("张三", 100, 100, 100);

            //Student s = new Student("张三", 18, '男', 100, 100, 100);
            ////s.Name = "张三";
            ////s.Age = 18;
            ////s.Gender = '中';
            ////s.Chinese = 100;
            ////s.Math = 100;
            ////s.English = 100;
            //s.SayHello();
            //s.ShowScore();

            //Student xlStudent = new Student("小兰", 16, '女', 50, 50, 50);
            ////xlStudent.Name = "小兰";
            ////xlStudent.Age = 16;
            ////xlStudent.Gender = '女';
            ////xlStudent.Chinese = 50;
            ////xlStudent.Math = 50;
            ////xlStudent.English = 50;
            //xlStudent.SayHello();
            //xlStudent.ShowScore();

            Console.ReadKey();
        }
    }
}
