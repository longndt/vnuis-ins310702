using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    internal class GradeBook
    {
        //in an OOP class without any constructor
        //C# will automatic create and use default constructor implicitly (hidden)
        public GradeBook() { }

        private string name;
        private double grade;

        public GradeBook(string name, double grade)
        {
            this.name = name;
            this.grade = grade;
        }

        public void displayMessage()
        {
            Console.WriteLine("Welcome to GradeBook app");
        }

        public void displayGrade()
        {
            Console.WriteLine("Student's name: " + name);
            Console.WriteLine("Student's grade: " + grade);
        }
    }
}
