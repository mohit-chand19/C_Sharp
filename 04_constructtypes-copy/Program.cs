using System;
namespace First
{
    class CopyConst
    {
        int x;
        public CopyConst(int i)     //Parameterized constructor
        {
            x = i;
        }
        public CopyConst(CopyConst obj)     //Copy constructor
        {
            x=obj.x;
        }
        public void Display()
        {
            Console.WriteLine("The value of x is: "+ x);
        }
        public static void Main(string[] args)
        {
                CopyConst obj1 = new CopyConst(20);
                obj1.Display();
                CopyConst obj2 = new CopyConst(obj1);
                obj2.Display();
        }
    }
}

