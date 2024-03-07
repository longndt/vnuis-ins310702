using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount sa1 = new SavingsAccount(999.99);
            //Error: this method is static
            // sa1.SetInterestRate(1999.99);

            //Solution: use class name instead of object name
            //SavingsAccount.SetInterestRate(1999.99);

            sa1.sayHello();
            SavingsAccount.sayHi();
        }
    }
}
