using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 作业：定义父亲类 Father（姓 lastName，财产 property，血型 bloodType），
            //儿子son类（玩游戏PlayGame方法），女儿 Daughter类（跳舞Dance方法）
            //调用父类构造函数（：base（）)给子类字段赋值

            //Son son = new Son("张三", 10m, "AB");
            //son.PlayGame();
            //son.SayHello();

            //Daughter d = new Daughter("韩梅梅", 100m, "o");
            //d.Dance();
            //d.SayHello();


            //作业：定义汽车类 Vehicle属性（ brand（品牌）， color（颜色））方
            //子类卡车（ Truck）属性 weight载重方法拉货，轿车（Can）属性 passeger载客数量方法载客

            Truck truck = new Truck("解放牌卡车", "绿色", 30000);
            Car car = new Car("奔驰", "黑色", 5);
            truck.LaHuo();
            car.LaKe();


            Console.ReadKey();


        }
    }

    /// <summary>
    /// 汽车父类
    /// </summary>
    public class Vehicle
    {
        public string Brand
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public void Run()
        {
            Console.WriteLine("我是汽车我会跑");
        }

        public Vehicle(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }
    }

    public class Truck : Vehicle
    {
        public double Weight
        {
            get;
            set;
        }

        public Truck(string brand, string color, double weight)
            : base(brand, color)
        {
            this.Weight = weight;
        }

        public void LaHuo()
        {
            Console.WriteLine("我最多可以拉{0}KG货物", this.Weight);
        }
    }

    public class Car : Vehicle
    {
        public int Passenger
        {
            get;
            set;
        }

        public Car(string brand, string color, int passenger)
            : base(brand, color)
        {
            this.Passenger = passenger;
        }

        public void LaKe()
        {
            Console.WriteLine("我最多可以拉{0}个人", this.Passenger);
        }
    }
}
