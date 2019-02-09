using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_面向对象多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：员工类、部门经理类程序猿类
            //（部门经理也是员工，所以要继承自员工类。员工有上班打卡的方法。用类来模拟
            Employee emp = new Employee();
            emp.Daka();

            Manager ma = new Manager();
            ma.Daka();
            Console.ReadKey();


        }
    }

    public class Employee
    {
        public virtual void Daka()
        {
            Console.WriteLine("员工八点上班打卡");
        }
    }

    public class Manager: Employee
    {
        public override void Daka()
        {
            Console.WriteLine("经理十点上班打卡");
        }
    }
}
