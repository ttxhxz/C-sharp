using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象类类型
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用多态求矩形的面积和周长以及圆形的面积和周长
            Shape shape = new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个形状的面积是{0:0.00},周长的{1:0.00}", area, perimeter);
            Console.ReadKey();

        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

    }

    public class Circle : Shape
    {
        private double _r;
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }

    public class Square : Shape
    {
        private double _height;
        public double Height { get => _height; set => _height = value; }

        private double width;
        public double Width { get => width; set => width = value; }

        public Square(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }




        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return 2 * (this.Height + this.Width);
        }
    }
}
