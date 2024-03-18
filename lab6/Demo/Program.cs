using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Tuan", 30);
            person.displayInfo();

            Student student = new Student("Hung", 20, "hung@vnu.edu.vn");
            student.displayInfo();  
        }
    }
}
