using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //grading scale:
            //9 - 10: excellent(if)
            //8 - 9: very good(else if)
            //7 - 8: good(else if)
            //6 - 7: fair(else if)
            //5 - 6: pass(else if)
            //0 - 5: fail(else if)
            //<0 or >10: invalid grade (else)

            double grade;
            Console.Write("Enter grade: ");
            grade = Convert.ToDouble(Console.ReadLine());

            if (grade >= 9.0 && grade <= 10)
            {
                //you must include bracket { } if there are more than 1 statement after "if"
                Console.WriteLine("Excellent");
                Console.WriteLine("Congratulation !");
            }
            else if (grade >= 8.0 && grade < 9)
                Console.WriteLine("Very good");
            else if (grade >= 7.0 && grade < 8)
                Console.WriteLine("Good");
            else if (grade >= 6.0 && grade < 7)
                Console.WriteLine("Fair");
            else if (grade >= 5.0 && grade < 6)
                Console.WriteLine("Pass");
            else if (grade >= 0 && grade < 5)
                Console.WriteLine("Fail");
            else
                Console.WriteLine("Invalid grade");
        }
    }
}
