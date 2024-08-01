using System;
namespace PropertiesProject
{
        public enum Cities
        {
            Kathmandu, Pokhara, Birjung, Dharan, Dhangadhi, Mahendranagar
        }
    class Customer
    {
        int _CustID;
        bool _Status;
        string _Cname, _State;
        double _Balance;
        Cities _City;
        public Customer(int CustID, bool Status, string Cname, double Balance, Cities City, String State) //string Country)
        {
            _CustID = CustID; 
            _Status = Status; 
            _Cname = Cname; 
            _Balance = Balance; 
            _City = City;
            _State = State;
            // this.Country = Country;     //assigned value to a property instead of variable 
        }
        public int CustID
        {
            get { return _CustID;}
        }
        public bool Status
        {
            get { return _Status;}
            set { _Status = value;}
        }
        public string Cname
        {
            get { return _Cname;}
            set 
            { 
                if(_Status== true)
                _Cname = value;
            }
        }
        public double Balance
        {
            get { return _Balance;}
            set 
            {
                if(_Status == true)
                {
                    if(value >= 500)
                    _Balance = value;
                }
            }
        }
        // public string City
        // {
        //     get { return _City;}
        //     set
        //     {
        //         if(_Status == true)
        //         { 
        //             if(value == "Kathmandu" || value == "Pokhara" || value == "Birjung" || value == "Dharan" || value == "Dhangadhi" || value=="Mahendranagar")
        //             _City = value;
        //         }
        //     }
        // }
        public Cities City
        {
            get { return _City;}
            set
            {
                if(_Status == true)
                {
                    
                    _City = value;
                }
            }
        }
        public String State
        {
            get { return _State;}
            protected set
            {
                if (_Status == true)
                _State = value;
            }
        }
        public String Country   //auto-implemented or automatic property
        {
            get;
            // set;
        }= "Nepal";
    }
    class TestCustomer
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101,false,"Mohit",300000, Cities.Mahendranagar, "Sudurpashchim");//"Nepal");
            Console.WriteLine("CustomerID: "+obj.CustID);
            // obj.CustID = 102;  //not valid bcoz only set property is defined in it(read only)
            if (obj.Status == true)
            Console.WriteLine("Current status of customer: Active");
            else 
            Console.WriteLine("Cureent status of customer: In-Active");

            Console.WriteLine("Customer Name is: "+obj.Cname);
            obj.Cname += " Chand";//assignment failed so below stmt prints old name only
            Console.WriteLine("Modified Customer Name is: "+obj.Cname);

            Console.WriteLine("Customer Balance: "+obj.Balance);
            obj.Balance = 200000;//here we modified balance but the modification will not take place
            Console.WriteLine("Modified Customer Balance: "+obj.Balance);

            obj.Status = true;
            if (obj.Status == true)
            Console.WriteLine("Current status of customer: Active");
            else 
            Console.WriteLine("Cureent status of customer: In-Active");

            obj.Cname += " Chand";//assignment succeed so below stmt prints new name only
            Console.WriteLine("Modified Customer Name is: "+obj.Cname);

            obj.Balance -= 100000;//here we modified balance so the modification will  take place
            Console.WriteLine("Modified Customer Balance: "+obj.Balance);

            obj.Balance -= 200000; //this assignment fails so below stmt prints old value of balance
            Console.WriteLine("Failed Modified Customer Balance: "+obj.Balance);

            obj.Balance -= 199500; //assignment succeed
            Console.WriteLine("Successfully Modified Customer Balance: "+obj.Balance);

            Console.WriteLine("Current City: "+obj.City);
            obj.City = Cities.Pokhara;
            Console.WriteLine("Modified Current City: "+obj.City);

            Console.WriteLine("Current State: "+obj.State);
            // obj.State = "Gandaki"; bcoz current class is not a child class of customer
            Console.WriteLine("Modified Current State: "+obj.State);

            Console.WriteLine("Current Country: "+obj.Country);
            // obj.Country = "India";
            Console.WriteLine("Modified Current Country: "+obj.Country);
        }
    }
}