using EmployeeApp1;
using System;
namespace EmployeeApp1
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
    }
}
