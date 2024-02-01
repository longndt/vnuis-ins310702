using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Requirement:
            //prompt user to enter their name and their birth year
            //display their name, birth year and age (self-calculation)

            //1st step: declare variables
            int birthYear, currentYear, age;
            string name;

            //2nd step: get user's input
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter birth year: ");
           //birthYear = int.Parse(Console.ReadLine());
            birthYear = Convert.ToInt16(Console.ReadLine());

            //3rd step: calculate age based on birth year and current year
            currentYear = DateTime.Now.Year;
            age = currentYear - birthYear;

            //4th step: display the result to console
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Birth year: " + birthYear);
            Console.WriteLine("Age: " + age);
        }
    }
}
