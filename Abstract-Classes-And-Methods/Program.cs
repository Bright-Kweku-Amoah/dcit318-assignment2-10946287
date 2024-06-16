// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace Abstract_Classes_And_Methods
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(12);
            Console.WriteLine("Area of circle: " + circle.GetArea());

            Rectangle rectangle = new Rectangle(15, 3);
            Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
        }
    }
}