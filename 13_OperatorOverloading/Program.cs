using System;
namespace OperatorOverloading
{
    class Operator
    {
        // public static void Main(string[] args)
        // {
        //     string s1="Hello ";
        //     string s2="World!";
        //     string s3=s1+s2;
        //     // string s4=s1-s2;  not valid
        //     Console.WriteLine(s3);
        // }
    }
    class Matrix
    {
        public int a,b,c,d;
        public Matrix (int a, int b, int c, int d)
        {
            this.a = a; this.b = b; this.c = c; this.d = d;
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m=new Matrix (m1.a+m2.a, m1.b+m2.b,m1.c+m2.c,m1.d+m2.d);
            return m;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix m=new Matrix (m1.a-m2.a, m1.b-m2.b,m1.c-m2.c,m1.d-m2.d);
            return m;
        }
        public override  String ToString()
        {
            // return "Hello World!";
            return a+" "+b+"\n"+c+" "+d+"\n";
        }
    }
    class TestMatrix
    {
        public static void Main(string[] args) 
        {
            Matrix m1=new Matrix(25,30,35,40);
            Matrix m2=new Matrix(5,10,15,20);
           // Matrix m3= new Matrix(m1.a+m2.a, m1.b+m2.b,m1.c+m2.c,m1.d+m2.d);   //this is lengthy method if we have more matrices having size greater we cant write like this mannualy 
           // Console.WriteLine(m3.a+" "+m3.b+" "+m3.c+" "+m3.d);
           Matrix m3=m1+m2;
           Matrix m4=m1-m2;
           Console.WriteLine(m1);
           Console.WriteLine(m2);
           Console.WriteLine(m3);
           Console.WriteLine(m4);
        }
    }
}
