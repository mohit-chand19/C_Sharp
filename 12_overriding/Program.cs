using System;
namespace Overriding
{
    class LoadParent
    {
        public void Show()
        {
        Console.WriteLine("Parent class Show method is called.");
        }
        public virtual void Test()      //overridable
        {
            Console.WriteLine("Parent class Test method is called.");
        }
    }
    class LoadChild: LoadParent
    {
        //overriding parents test method in child class 
        public override void Test()         //overriding
        {
            Console.WriteLine("Child class Test method is called.");
        }
        //overloading parents show method in child class
        public void Show(int i)
        {
            Console.WriteLine("Child class Show method is called.");
        }
        static void Main(string[] args)
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Show(50);
            c.Test();
        }
    }
}