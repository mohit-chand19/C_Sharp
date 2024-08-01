using System;
namespace OverloadingProject
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("First method.");
        }
        // public string Test()
        // {
        //     Console.WriteLine("Hello!");     Not Valid this method becaause same parameters
        // }                                                            
        public void Test(int i)
        {
            Console.WriteLine("Second method.");
        }
        public void Test(string s)
        {
            Console.WriteLine("Third method.");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("Fourth method.");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("Fifth method.");
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.Test();
            p.Test(10);
            p.Test("Hello!");
            p.Test(427, "Try Better!");
            p.Test("Can Improve", 100);
        }
    }
}