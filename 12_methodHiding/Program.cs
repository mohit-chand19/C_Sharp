using System;
namespace MHiding
{
    class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class.");
        }
        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class.");
        }
    }
    class ChildClass: ParentClass
    {
        public override void Test1()        //Method overriding
        {
            Console.WriteLine("Method Test1 from Child class.");
        }
        public new void Test2()             //Mehod Hiding or shadowing
        {
            Console.WriteLine("Method Test2 from Child class.");
        }
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main(string[] args)
        {
        // ParentClass p = new ParentClass();
        // p.Test1();
        // p.Test2();
        ChildClass c=new ChildClass();  //child class instance
        ParentClass p=c;              //reference of parentclass created by using child class instance
        // c.ParentTest1();
        // c.ParentTest2();
        // c.Test1();    
        // c.Test2();
        p.Test1();      //calls child class Test1();    overridden
        p.Test2();      //calls parent class Test2();   hiden
        }
    }
}