using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int a, b, addition, multiplication, remainder;

            //prompt user to enter a & b
            //get user's input and save to variables
            //note: must convert text (string) to number (integer) first
            Console.Write("Enter a: ");
            a = Convert.ToInt32(Console.ReadLine());  //Int16 or 64 are ok
            Console.Write("Enter b: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            //calculate the result
            addition = a + b;
            multiplication = a * b;
            remainder = a % b;  //modulus: get remainder or a division

            //display the result
            Console.WriteLine(a + " + " + b + " = " + addition);
            Console.WriteLine(a + " * " + b + " = " + multiplication);
            Console.WriteLine(a + " % " + b + " = " + remainder);
        }
    }
}
