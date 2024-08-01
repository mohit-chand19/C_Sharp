using System;
namespace AbstractClassImplementation
{
    abstract class Figure
    {
        public double width, height,radius;
        public const float pi=3.14f;
        public abstract double GetArea();
    }
    class Rectangle : Figure
    {
       public Rectangle(double width, double height)
       {
        this.width = width;
        this.height = height;
       }
       public override double GetArea()
       {
        return width*height;
       }
    }
    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return pi*radius*radius;
        }
    }
    class Cone : Figure
    {
        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double GetArea()
        {
            return pi*radius*(radius+Math.Sqrt(height*height+radius*radius));
        }
    }
    class TestFigure
    {
        public static void Main()
        {
            Rectangle r = new Rectangle(12.5, 60.4);
            Circle c1 = new Circle(r.width);
            Cone c2 = new Cone(r.width,r.height);

            Console.WriteLine("The area of rectangle:"+r.GetArea());
            Console.WriteLine("The area of Circle:"+c1.GetArea());
            Console.WriteLine("The area of Cone:"+c2.GetArea());
        }
    }
}
