using System;
namespace EmployeeApp
{
    class Manager : Employee//A manager is also an Employee
    {
        //In addition, manager has a special field
        public int StockOptions { get; set; }
    }
}
