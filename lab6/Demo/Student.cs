using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //derived (child)
    class Student : Person
    {
        private string email;

        public Student (string name, int age,
            string email) : base (name, age)
        {
            this.email = email;
        }

        public override void displayInfo()
        {
            base.displayInfo();
            Console.WriteLine("Email: " + email);
        }
    }
}
