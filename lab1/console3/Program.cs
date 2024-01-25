using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable and initialize at once
            int a = 3;

            //declare variable first
            int b;
            //set value later
            b = 7;

            //display variable's value
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a + b = " + a + " + " + b + " = " + (a + b));

            //floating-point number
            double gpa = 7.8;  //recommended
            float grade = (float)8.5;

            //logical value (true, false)
            bool pass = false;

            //character 
            char gender = 'm';   //male

            //string (array of characters)
            string vnu = "Vietnam National University";
            Console.WriteLine(vnu);
        }
    }
}
