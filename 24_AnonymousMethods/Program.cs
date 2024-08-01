using System;
namespace DelegateProject
{
    public delegate string GreetingsDelegate(string s);
    class AnonymousMethods
    {
        // public static string Greetings(string name)
        // {
        //     return "Hello " + name + " a very Good Morning!";
        // }
        static void Main(string[] args)
        {
            // GreetingsDelegate obj = new GreetingsDelegate(Greetings);
            // string str = obj.Invoke("Mohit");
            // Console.WriteLine(str);
            GreetingsDelegate obj = delegate (string name) 
            { 
                return "Hello " + name + " a very Good Morning!";
            };
            string str = obj.Invoke("Mohit");
            Console.WriteLine(str);
        }
    }
}
