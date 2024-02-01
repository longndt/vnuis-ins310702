using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //ask user to input 2 numbers
            //display result for greater number

            //int a, b;
            //Console.Write("Enter a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Enter b: ");
            //b = int.Parse(Console.ReadLine());

            //if (a > b)
            //    Console.WriteLine("a is greater than b");
            //else if (a < b)
            //    Console.WriteLine("b is greater than a");
            //else
            //    Console.WriteLine("a is equal to b");

            //Task 2
            //input 3 integers and display max number
            int a, b, c;
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            c = int.Parse(Console.ReadLine());

            //1st case: a is max
            if (a >= b && a >= c)
                Console.WriteLine(a + " is max");
            //2nd case: b is max
            else if (b >= a && b >= c)
                Console.WriteLine(b + " is max");
            //3rd case: c is max
            else  // c >= a && c >= b 
                Console.WriteLine(c + " is max");
        }
    }
}
