using System;
namespace Inheritance
{
    class Class1
    {
        public Class1()
        {
            Console.WriteLine("Class 1 constructor is called.");
        }
        public void Test1()
        {
            Console.WriteLine("Method One!");
        }
        public void Test2()
        {
            Console.WriteLine("Method Two!");
        }
    }
    class Class2: Class1
    {
        Class2()
        {
            Console.WriteLine("Class 2 constructor is called.");
        }
        public void Test3()
        {
            Console.WriteLine("Method Three!");
        }
        static void Main(string[] args)
        {
            Class1 p;   //p is the variable of class 1
            Class2 c=new Class2();  //c is the instance of class 2
            p = c;    //p is the reference of parent class(class1) created by using child class instance 
            p.Test1();
            p.Test2();
            c.Test3();
        }
    }
}