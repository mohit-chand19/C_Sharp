using System;
namespace First
{
    class StaticConst
    {
        static  StaticConst()
        {
            Console.WriteLine("Static constructor is executed");  //First always this line will be displayed
        }
      
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Main method is executed");
        }
    }
}

