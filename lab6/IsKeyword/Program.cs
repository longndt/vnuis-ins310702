using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKeyword
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Employee e1 = new Manager();
            Employee e2 = new SalesPerson();
            CheckEmployee(e1);
            CheckEmployee(e2);
        }
        static void CheckEmployee(Employee e)
        {
            if (e is SalesPerson)
            {
                Console.WriteLine("Your sale number: " + ((SalesPerson)e).SalesNumber);
            }
            if (e is Manager)
            {
                Console.WriteLine("Your stock options: " + ((Manager)e).StockOptions);
            }
        }
    }

}
