using System;
namespace InterfaceProject
{
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceTest : Interface1 , Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interfaces Method Test is implemented in child class.");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Declared in Interface1 and implemented in class.");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Declared in Interface2 and implemented in class.");
        }
        static void Main()
        {
            MultipleInheritanceTest obj = new MultipleInheritanceTest();
            obj.Test();
            Interface1 i1 = obj;
            Interface2 i2 = obj;
            i1.Show();
            i2.Show();
            Console.ReadLine();
        }
    }
}
