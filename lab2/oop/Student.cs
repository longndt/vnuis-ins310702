using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //OOP : Object Oriented Programming

    //Student.cs : OOP class
    internal class Student
    {
        //attributes (variables)
        //always set access modifier for all attributes to private
        // => information hiding (security)
        private int Id;
        private string Name;
        private string Email;

        //behaviours (methods)
        //set access modifier to public for the methods you want to share for other classes
        //constructor
        public Student () { }  //empty constructor
        //public Student(int Id, string Name, string Email)
        //{
        //    //left-side : variables
        //    //right-side: parameters
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Email = Email;
        //}
        public Student(int id, string name, string email)
        {
            //variable's name and parameter's name are similar => use "this" keyword
            //variable's name and parameter's name are different => no need to use "this" keyword
            //C# is case-sensitive language (upper case != lower case)
            Id = id;
            Name = name;
            Email = email;
        }

        //getter (observer)
        public int getId()
        {
            return this.Id;
        }

        public string getName()
        {
            return this.Name;
        }

        public string getEmail()
        {
            return this.Email;
        }

        //setter (mutator)
        public void setId(int Id) {
            this.Id = Id;
        }
        public void setName(string Name) { 
            this.Name = Name;
        }
        public void setEmail(string Email) { 
            this.Email = Email;
        }

        //extra methods
        public void showStudentInfo()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Email: " + this.Email);
        }  
    }
}
