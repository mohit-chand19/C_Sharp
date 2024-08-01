using System;
namespace Project
{
    class First
    {
        int x=100;
        public static void Main()
        {
            First f1;    //variable of a class it does not have any memory
            f1=new First(); // initialized using new keyword now f1 is instance of a class
            //Console.WriteLine(f1.x);
            First f2=new First(); // another instance of a class
            //Console.WriteLine(f2.x);
            f1.x=200;
            //Console.WriteLine(f1.x+" "+f2.x);
            f2.x=399;
            //Console.WriteLine(f1.x+" "+f2.x);
            First f3=f2; //f3 is the reference of the class it shares the memory of f2 instance it can work same as instance of class f3 is just a pointer to the instance f2
            Console.WriteLine(f2.x+" "+f3.x);
            f2.x=499;
            Console.WriteLine(f2.x+" "+f3.x);
            f3.x=500;
            Console.WriteLine(f2.x+" "+f3.x);
        }
    }
}