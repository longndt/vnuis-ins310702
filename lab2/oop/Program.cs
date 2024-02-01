using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop
{
    //Program.cs : Program class (to run program)
    internal class Program
    {
        static void Main(string[] args)
        {
            //object: class instance
            //declare new Student objects with constructor
            Student student1 = new Student(12345, "Tuan Hung", "tuanhung.vnu@gmail.com");
            Student student2 = new Student(12346, "Hung Lam", "hunglam.vnu@gmail.com");
            Student student3 = new Student(12347, "Manh Hai", "manhhai.vnu@gmail.com");

            //display student 1 information
            Console.WriteLine("Name of student 1: " + student1.getName());
            Console.WriteLine("Current email of student 1: " + student1.getEmail());
            //change email address of student 1
            student1.setEmail("tuanhung_vnuis@gmail.com");
            //display new email address of student 1
            Console.WriteLine("New email of student 1: " + student1.getEmail());

            //display student 2 & 3 information
            Console.WriteLine("Student 2 Info: ");
            student2.showStudentInfo();
            Console.WriteLine("Student 3 Info: ");
            student3.showStudentInfo();
        }
    }
}
