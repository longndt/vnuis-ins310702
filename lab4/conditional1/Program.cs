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
            //conditional structure 
            //if...else

            //task 1: return the student's result based on grade
            // 0-4.9: fail | 5-10: pass
            // Solution: If Else

            //IF : true, ELSE : false 
            //no parenthesis (condition) in ELSE => else gets remained case
            //double grade = 5.6;
            //if (grade >= 5.0 && grade <= 10)
            //    Console.WriteLine("Pass");
            //else  //grade < 5.0 && grade >= 0
            //    Console.WriteLine("Fail");

            //1 possible case => IF
            //2 possible cases => IF + ELSE
            //>= 2 possible cases => IF + ELSE IF + ELSE

            //task 2: return the student's level based on GPA
            /*
             * 9-10 : Excellent  (if)
             * 8-8.9: Very good  (else if)
             * 7-7.9: Good       (else if)
             * 5-6.9: Pass       (else if)
             * 0-4.9: Fail       (else if)
             * <0 || >10 : Invalid (else)
             */
            //Solution: If Else If Else
            double gpa = 11.5;
            if (gpa >= 9 && gpa <= 10)
                Console.WriteLine("Excellent");
            else if (gpa >= 8 && gpa < 9)
                Console.WriteLine("Very good");
            else if (gpa >= 7 && gpa < 8)
                Console.WriteLine("Good");
            else if (gpa >= 5 && gpa < 7)
                Console.WriteLine("Pass");
            else if (gpa >= 0 && gpa < 5)
                Console.WriteLine("Fail");
            else   // gpa<0 || gpa>10
                Console.WriteLine("Invalid grade");
        }
    }
}
