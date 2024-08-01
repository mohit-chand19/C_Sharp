using System;
namespace IndexerProject
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename,Job,Dname,Location;
        public Employee(int Eno,string Ename,string Job,double Salary,string Dname,string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;
            
        }
        public object this[int index]
        {
            get
            {
                if(index == 0)
                return Eno;
                else if(index == 1)
                return Ename;
                else if(index == 2)
                return Job;
                else if(index == 3)
                return Salary;
                else if(index == 4)
                return Dname;
                else if(index == 5)
                return Location;
                return null;
            }
            set
            {
                if(index == 0)
                Eno = (int)value;
                else if(index == 1)
                Ename = (string)value;
                else if(index == 2)
                Job = (string)value;
                else if(index == 3)
                Salary = (double)value;
                else if(index == 4)
                Dname = (string)value;
                else if(index == 5)
                Location = (string)value;
                
            }
        }
        public object this[string name]
        {
            get
            {
                if(name.ToUpper() == "ENO")
                return Eno;
                else if(name.ToUpper() == "ENAME")
                return Ename;
                else if(name.ToUpper() == "JOB")
                return Job;
                else if(name.ToUpper() == "SALARY")
                return Salary;
                else if(name.ToUpper() == "DNAME")
                return Dname;
                else if(name.ToUpper() == "LOCATION")
                return Location;
                return null;
            }
        }
    }
    public class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(1001, "Mohit","Manager", 100000.00, "Sales","Mahedranagar");
            // Emp[0]; invalid bcoz Emp is Employee type i.e class cannot be indexed
            Console.WriteLine("Eno: "+Emp[0]);
            Console.WriteLine("Ename: "+Emp[1]);
            Console.WriteLine("Job: "+Emp[2]);
            Console.WriteLine("Salary: "+Emp[3]);
            Console.WriteLine("Dname: "+Emp[4]);
            Console.WriteLine("Location: "+Emp[5]);

            Emp[0]=1002;
            Emp[2]="Senior Manager";
            Emp[3]=(double)150000;
                       
            Console.WriteLine("Eno: "+Emp[0]);
            Console.WriteLine("Ename: "+Emp[1]);
            Console.WriteLine("Job: "+Emp[2]);
            Console.WriteLine("Salary: "+Emp[3]);
            Console.WriteLine("Dname: "+Emp[4]);
            Console.WriteLine("Location: "+Emp[5]);

            Console.WriteLine("Eno: "+Emp["Eno"]);
            Console.WriteLine("Ename: "+Emp["Ename"]);
            Console.WriteLine("Job: "+Emp["Job"]);
            Console.WriteLine("Salary: "+Emp["Salary"]);
            Console.WriteLine("Dname: "+Emp["dname"]);
            Console.WriteLine("Location: "+Emp["Location"]);
        }
    }
}