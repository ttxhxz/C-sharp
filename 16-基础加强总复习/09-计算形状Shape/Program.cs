using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_计算形状Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：计算形状 Shape（圆Circle，矩形 Square，正方形 Rectangle）的area面积、perimeter周长
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Circle : Shape
    {
        public double R
        {
            get;
            set;
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
        public double Length
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public Square(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Length * this.Width;
        }
        public override double GetPerimeter()
        {
            return 2 * (this.Length + this.Width);
        }

    }

    public class Rectangle : Shape
    {
        public double Side
        {
            get;
            set;
        }

        public Rectangle(double side)
        {
            this.Side = side;
        }

        public override double GetArea()
        {
            return this.Side * this.Side;
        }
        public override double GetPerimeter()
        {
            return 2 * (this.Side + this.Side);
        }

    }
}
