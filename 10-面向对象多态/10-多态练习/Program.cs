using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //RealDuck rd = new RealDuck();
            //MtDuck md = new MtDuck();
            //XpDuck xd = new XpDuck();
            //RealDuck[] ducks = { rd, md, xd };
            //for (int i = 0; i < ducks.Length; i++)
            //{
            //    ducks[i].Bark();

            //}

            //经理十一点打卡员工9点打卡程序猿不打卡
            Employee emp = new Employee();
            Manager mg = new Manager();
            Programmer pm = new Programmer();
            Employee[] emps = { emp, mg, pm };
            for (int i = 0; i < emps.Length; i++)
            {
                emps[i].DaKa();
            }

            Console.ReadKey();

        }
    }

    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }

    public class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }

    public class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序员不打卡");
        }
    }


    public class RealDuck
    {
        public virtual void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }

    public class MtDuck : RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }

    public class XpDuck : RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }
}
