using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    internal class GradeBookTest
    {
        static void welcome()
        {
            Console.WriteLine("welcome to VNU-IS");
        }

        static void Main(string[] args)
        {
            /* if you want to call method in an OOP class
             * you must create object first */
            GradeBook gb = new GradeBook();
            gb.displayMessage();

            /* but if you want to call an internal method
             * (inside-class method), you don't need to 
             * create object or anything similar. Just call the method itself by its name */
            welcome();

            //create new GradeBook object with both "name" and "grade"
            Console.Write("Enter student's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student's grade: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            GradeBook gb1 = new GradeBook(name, grade);
            gb1.displayGrade();
        }
    }
}
