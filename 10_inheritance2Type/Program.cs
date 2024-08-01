using System;
namespace Inheritance
{
    class Class1
    {
        public Class1(int i)
        {
            Console.WriteLine("class 1 constructor:  "+i);
        }
        public void Test1()
        {
            Console.WriteLine("First method in first class.");
        }
        public void Test2()
        {
            Console.WriteLine("Second method in first class.");

        }
    }
    class Class2: Class1
    {
        public Class2(int a):base(20)
        {
            Console.WriteLine("Class 2 constructor:"+a);
        }
        void Test3()
        {
            Console.WriteLine("Third method in second class.");
        }
        static void Main(string[] args)
        {
            // Object obj = new object();//this object is the base class which is at top of all classes heirarchy it is defined in system namespace that we use it has four method that can be accessed by every classes
            // Console.WriteLine(obj.GetType());
            // Class1 c = new Class1();
            // Console.WriteLine(c.GetType());
            // Console.WriteLine(p.GetType());
            Class2 p = new Class2(50);

        }
    }
}