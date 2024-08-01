using System;
namespace CSIT
{
     class Program
    {
        int x;  //non-static variables
        static int y=200;   //static variables
        const float pi=3.14f;
        readonly bool flag;
        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            //int z;      //static variables
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Program p1=new Program(150,true);
            Program p2=new Program(250,false);
            Console.WriteLine(p1.x+" "+p2.x);
            Console.WriteLine(p1.flag+" "+p2.flag);
            p1.x=350;             //allowed with non-static variables
            //p1.flag=false;        not allowed with readonly variables
            Console.ReadLine();
        }
    }
}
