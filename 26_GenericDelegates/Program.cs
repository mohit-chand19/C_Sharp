using System;
namespace DelegateProject
{
    // public delegate double Delegate1(int x, float y, double z);
    // public delegate void Delegate2(int x, float y, double z);
    // public delegate bool Delegate3(string str);

    class GenericDElegates
    {
        public static double AddNums1(int x, float y, double z)
        {
            return (x + y + z);
        }
        public static void AddNums2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if(str.Length > 5)
            return true;
            else return false;
        }
        public static void Main(string[] args)
        {
            Func<int, float, double, double> obj1= AddNums1;
            double result1=obj1.Invoke(100,35.32f,483.6789);
            Console.WriteLine(result1);

            Action<int, float, double> obj2= AddNums2;
            obj2.Invoke(100,35.32f,483.6789);

            Predicate<string> obj3 = CheckLength;
            bool status = obj3.Invoke("Hello World");
            Console.WriteLine(status);
        }
    }
}

