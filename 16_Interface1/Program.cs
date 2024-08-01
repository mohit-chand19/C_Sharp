using System;
namespace InterfaceProject
{
    interface Itestinterface1
    {
        void Sum(int a, int b);
    }
    interface Itestinterface2 : Itestinterface1
    {
        void Sub(int a, int b);
    }
    class Implementaion : Itestinterface2
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        static void Main(string[] args)
        {
            Implementaion c = new Implementaion();
            Itestinterface2 i = c;
            // c.Sum(356,754);
            // c.Sub(200,156);
            i.Sub(1,2);
            i.Sum(2,3);
        }
    }

}