using System;

namespace CS.Impl._04_Advanced
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public abstract double GetPerimeter();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.Round(Math.PI * this.radius * this.radius);            
        }

        public override double GetPerimeter()
        {
            return Math.Round(2 * Math.PI * this.radius);
        }
    }

    public class Rectangle : Shape
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
            return this.length * this.width;
        }

        public override double GetPerimeter()
        {
            return (this.width + this.length) * 2;
        }

    }

    public class Square : Shape
    {
        private double sideLength;
        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override double GetArea()
        {
            return this.sideLength * this.sideLength;
        }

        public override double GetPerimeter()
        {
            return this.sideLength * 4;
        }

    }
}