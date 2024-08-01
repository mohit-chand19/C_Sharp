using System;
namespace EnumerationProject
{
    public enum Days
    {
        Monday=11, Tuesday=21, Wednesday=31, Thursday=41, Friday=51
    }
    class TestClass
    {
        static public Days MeetingDate{get; set;} = (Days)11;
    static void Main(string[] args)
    {
        // Console.BackgroundColor = ConsoleColor.Magenta;
        // Console.WriteLine("Hello, World!");
        // Days d1 = 0;
        // Days d2 = (Days)1;
        // Days d3 = Days.Thursday;
        // Console.WriteLine(d1);
        // Console.WriteLine(d2);
        // Console.WriteLine(d3);
        // Console.WriteLine((int)d3);
        // foreach(int i in Enum.GetValues(typeof(Days)))
        // Console.WriteLine(i+":"+(Days)i);
        // // Console.WriteLine(i);
        // foreach(string i in Enum.GetNames(typeof(Days)))
        // Console.WriteLine(i);

        Console.WriteLine(MeetingDate);
        MeetingDate = Days.Friday;
        Console.WriteLine(MeetingDate);
    }

    }
}
