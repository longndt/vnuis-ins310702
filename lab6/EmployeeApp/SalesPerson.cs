using System;
namespace EmployeeApp
{
    class SalesPerson : Employee //Sale person is also an employee
    {
        // Salespeople need to know their number of sales.
        public int SalesNumber { get; set; }

    }
}
