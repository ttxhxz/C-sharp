using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_break关键字的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            //要求用户输入用户名和密码 用户名只要不是admin 密码不是666666
            string userName = "";
            string userPwd = "";
            while (userName != "admin" || userPwd != "666666")
            {
                Console.WriteLine("请输入用户名:");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                userPwd = Console.ReadLine();
            }
            Console.WriteLine("登陆成功！");
            Console.ReadKey();

        }
    }
}
