using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_多态复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //虚方法、抽象类、接口
            //面向对象计算器 案例
            Console.WriteLine("请输入第一个数字：");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数字：");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入操作符：");
            string opera = Console.ReadLine();
            CalFather cal = GetCal(opera, n1, n2);
            double result = cal.Calculator();
            Console.WriteLine(result);
            Console.ReadKey();

        }

        public static CalFather GetCal(string opera, double n1, double n2)
        {
            CalFather cal = null;
            switch (opera)
            {
                case "+":
                    cal = new Plus(n1, n2);
                    break;
                case "-":
                    cal = new Minus(n1, n2);
                    break;
                case "*":
                    cal = new Multiply(n1, n2);
                    break;
                case "/":
                    cal = new Divide(n1, n2);
                    break;
            }
            return cal;
        }
    }

    public abstract class CalFather
    {
        public double NumberOne
        {
            get;
            set;
        }

        public double NumberTwo
        {
            get;
            set;
        }

        public CalFather(double n1, double n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }

        public abstract double Calculator();
    }

    public class Plus : CalFather
    {
        public Plus(double n1, double n2) : base(n1, n2)
        {

        }

        public override double Calculator()
        {
            return this.NumberOne + this.NumberTwo;
        }
    }

    public class Minus : CalFather
    {
        public Minus(double n1, double n2) : base(n1, n2)
        {

        }

        public override double Calculator()
        {
            return this.NumberOne - this.NumberTwo;
        }
    }

    public class Multiply : CalFather
    {
        public Multiply(double n1, double n2) : base(n1, n2)
        {

        }

        public override double Calculator()
        {
            return this.NumberOne * this.NumberTwo;
        }
    }

    public class Divide : CalFather
    {
        public Divide(double n1, double n2) : base(n1, n2)
        {

        }

        public override double Calculator()
        {
            return this.NumberOne / this.NumberTwo;
        }
    }
}
