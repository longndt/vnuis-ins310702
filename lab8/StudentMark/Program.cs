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
                    new Student { Name = "Alice", Mark = 90 },
                    new Student { Name = "Bob", Mark = 80 },
                    new Student { Name = "Charlie", Mark = 85 },
                    new Student { Name = "David", Mark = 92 }
                };

            var highScorer = from student in students
                             where student.Mark > 85
                             select student;

            foreach (var student in highScorer)
            {
                Console.WriteLine(student.Name + " scored " + student.Mark);
            }
        }
    }
}
