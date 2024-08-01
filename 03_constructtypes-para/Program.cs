using System;
namespace First
{
    class ParamaterizedConst
    {
        int x;
        public ParamaterizedConst(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called:"+i);
        }
        public void Display()
        {
            Console.WriteLine("The value of x is: "+ x);
        }
        public static void Main(string[] args)
        {
                ParamaterizedConst obj1 = new ParamaterizedConst(20);
                ParamaterizedConst obj2 = new ParamaterizedConst(50);
                // ParamaterizedConst obj3 = new ParamaterizedConst(150);
                obj1.Display();
                obj2.Display();
        }
    }
}

