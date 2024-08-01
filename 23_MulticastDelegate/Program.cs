using System;
namespace DelegateProject
{
    public delegate void RectDelegate(double x, double y);
    class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of rectangle: "+width*height);    
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of rectangle: "+2*(width+height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            // rect.GetArea(12.34,56.78);
            // rect.GetPerimeter(12.34,56.78);
            // RectDelegate obj = new RectDelegate(rect.GetArea);
            // obj.Invoke(12.34,56.78);
            //or
            RectDelegate obj2 = rect.GetArea;
            // obj2.Invoke(12.34,56.78);
            obj2+=rect.GetPerimeter;
            obj2.Invoke(12.34,56.78); //both methods gets invoked by single delegate
            Console.WriteLine();
            obj2.Invoke(47.87,34.89);
        }
    }
}