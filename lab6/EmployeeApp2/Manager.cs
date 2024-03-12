using EmployeeApp2;
using System;
namespace EmployeeApp2
{
    class Manager : Employee//A manager is also an Employee
    {
        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
       : base(fullName, age, empID, currPay, ssn) //When creating manager, need to also create an Employee
        {
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;
        }
        //This is a default constructor
        public Manager() { }
        public int StockOptions//In addition, manager has a special field
        {
            get;
            set;
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
    }
}
