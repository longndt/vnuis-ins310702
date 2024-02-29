using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //conditional operator (ternary operator)
            //we use ternary operator to replace for "if else"
            double gpa = 6.3;
            //syntax: (conditional_expression) ? true : false
            string result = (gpa > 5.0) ? "Pass" : "Fail";
            Console.WriteLine(result);  
        }
    }
}
