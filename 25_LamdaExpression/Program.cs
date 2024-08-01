using System;
namespace DelegatesProject
{
    public delegate string GreetingDelegates(string s);
    class LambdaExpression
    {
        // public static string Greetings(string name)
        // {
            // return "Hello "+name+" a very good morning.";
        // }
        static void Main()
        {
            GreetingDelegates obj = (name)=> // => this is called a lambda expression which is used to define a anonymous method 
            {
                return "Hello "+name+" a very good morning.";
            };
            string str = obj.Invoke("Mohit");
            Console.WriteLine(str);
        } 
    }
}