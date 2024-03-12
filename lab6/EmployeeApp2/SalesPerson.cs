using EmployeeApp2;
using System;
namespace EmployeeApp2
{
    class SalesPerson : Employee //Sale person is also an employee
    {
        // Salespeople need to know their number of sales.
        public int SalesNumber { get; set; }
        // As a general rule, all subclasses should explicitly call an appropriate
        // base class constructor.
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales)
          : base(fullName, age, empID, currPay, ssn)
        {
            // This belongs with us!
            SalesNumber = numbOfSales;
        }
        // Add back the default constructor
        public SalesPerson()
        {

        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Sales: {0}", SalesNumber);
        }
        public override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}
