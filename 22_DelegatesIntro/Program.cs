using System;
namespace DelegatesProject
{
    //step 1: Defining delegates
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Program
    {
        public void AddNum(int a, int b)
        {
            Console.WriteLine(a+b);   
        } 
        public static string SayHello(string name)
        {
            return "Hello "+name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AddNum(100, 200);

            string str = Program.SayHello("Mohit");
            Console.WriteLine(str);
           
            //instantiating the delegate.
            AddDelegate ad = new AddDelegate(p.AddNum);
            ad(100,150);
            ad.Invoke(20,10); //another way of calling
            SayDelegate sd = new SayDelegate(Program.SayHello);
            string s1 = sd("Programmer");
            string s2 = sd.Invoke("CSIT"); //another way of calling
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}