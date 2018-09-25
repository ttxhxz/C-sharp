using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_两个小练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一题
            //string name = "卡卡西";
            //int age = 30;
            //string email = "kakxi@qq.com";
            //string address = "火影村";
            //decimal salary = 2000m;
            //Console.WriteLine("我叫" + name + "，我住在" + address + "，我今年" + age + "了，我的邮箱是" + email + "，我的工资是" + salary);

            //第二题
            //int age = 18;
            //age = 81;
            //Console.WriteLine("年龄：" + age1);

            //第三题
            string name = "张三";
            char gender = '男';
            int age = 30;
            string tel = "123135646546";
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的电话是{3}", name, age, gender, tel);
            Console.ReadKey();


        }
    }
}
