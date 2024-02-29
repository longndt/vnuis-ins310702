using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do while loop
            //usage: to validate user's input

            //task: validate student's grade (0-10)
            double grade;
            do
            {
                Console.Write("Enter grade (0-10): ");
                grade = Double.Parse(Console.ReadLine());
            } while (grade < 0 || grade > 10);
            //logical expression inside "while" : outside the valid range
            Console.WriteLine("Grade: " + grade);
        }
    }
}
