using System;
namespace Structure
{
    struct MyStruct
    {
        int i;
        //int i = 10;    invalid can't initialize directly
        public MyStruct(int i)
        {
            this.i = i;
            // Console.WriteLine("Constructor under structure.");
        }
        void Display()
        {
            Console.WriteLine("Method Display in a Structure."+i);
        }
        static void Main(string[] args)
        {
            MyStruct m1;
            m1.i = 10;
            m1.Display();

            MyStruct m2 = new MyStruct();
            m2.Display();

            MyStruct m3 = new MyStruct(30);
            m3.Display();
        }
    }
}