﻿using System;

namespace EmployeeApp
{
    class MainClass
    {
        // Create a subclass object and access base class functionality.
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;
            Console.ReadLine();
        }
    }
}
