using System;
namespace AbstractClass
{
    abstract class AbsParent
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        public void Difference(int x, int y)
        {
            Console.WriteLine(x-y);
        }
        public abstract void Mul(int x, int y);
        public abstract void Div(int x, int y);
    }
    class AbsChild: AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x/y);
        }
        static void Main(string[] args)
        {
        AbsChild c=new AbsChild();
        // c.Sum(30,20); c.Difference(30,20);
        // c.Mul(30,20); c.Div(60,20);
        //  AbsParent p=new AbsParent();  Cannot create an abstract class instance but we can create its reference
        AbsParent p= c;
        p.Mul(30,20); p.Div(60,20); p.Sum(30,20); p.Difference(30,20);
        }
    }
}

    