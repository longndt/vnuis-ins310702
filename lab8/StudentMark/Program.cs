using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
                {
                    new Student { Name = "Alice", Mark = 90, Age = 20 },
                    new Student { Name = "Bob", Mark = 80, Age = 21},
                    new Student { Name = "Charlie", Mark = 85, Age = 22 },
                    new Student { Name = "David", Mark = 92, Age = 19 }
                };

            // LINQ (Language Integrated Query)
            var result = from student in students
                         where student.Mark >= 80 && student.Age >= 20
                         orderby student.Name ascending
                         select student;

            foreach (var student in result)
            {
                Console.WriteLine(student.Name + " scored " + student.Mark);
            }
        }
    }
}
