using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StaticDataAndMembers
{
    // A simple savings account class.
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;

        // A static point of data.
        public static double currInterestRate = 0.04;

        // Notice that our constructor is setting
        // the static currInterestRate value.
        public SavingsAccount(double balance)
        {
            currInterestRate = 0.04; // This is static data!
            currBalance = balance;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        { 
            currInterestRate = newRate; 
        }

        public static double GetInterestRate()
        { 
            return currInterestRate; 
        }

        public void sayHello()
        {
            Console.WriteLine("Hello");
        }

        public static void sayHi()
        {
            Console.WriteLine("Hi");
        }
    }
}
