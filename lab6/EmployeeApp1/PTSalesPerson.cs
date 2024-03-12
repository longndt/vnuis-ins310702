using System;
namespace EmployeeApp1
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID,
                             float currPay, string ssn, int numbOfSales)
          : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
        }
        // Assume other members here...
    }
}
