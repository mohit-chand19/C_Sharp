using System;
namespace First
{
//consuming members of a class from same class 
public class Program
{
    private void Test1()
    {
        Console.WriteLine("Private Method.");
    }
    internal void Test2()
    {
        Console.WriteLine("Internal Method.");
    }
    protected void Test3()
    {
        Console.WriteLine("Protected Method.");
    }
    protected internal void Test4()
    {
        Console.WriteLine("Protected Internal Method.");
    }
    public void Test5()
    {
        Console.WriteLine("Public Method.");
    }
    // static void Main(string[] args) 
    // {
    //     Program p= new Program();
    //     p.Test1();
    //     p.Test2();
    //     p.Test3();
    //     p.Test4();
    //     p.Test5(); 
    // }
}
//consuming members of a class from child class using inheritance 
class Second:Program
{
    // static void Main(string[] args)
    // {
    // Second s= new Second();
    // s.Test2();s.Test3();s.Test4();s.Test5(); //test1() cannot be accessed
    // }
}
//consuming members of a class by another class(non-child) using instance of that class 
class Third
{
    static void Main(string[] args)
    {
        Program p= new Program();
        p.Test2();p.Test4();p.Test5();  //test1() and test3() cannot be accessed
    }
}
}