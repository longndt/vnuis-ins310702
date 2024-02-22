using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input : human (user) => machine (computer)
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your country: ");
            string country = Console.ReadLine();
            Console.Write("Enter your birthyear: ");
            //convert user's input from string (default) to integer (by demand)
            //int birthYear = int.Parse(Console.ReadLine());   //1st way
            int birthYear = Convert.ToInt32(Console.ReadLine()); //2nd way
            //int age = 2024 - birthYear;   //prevent hard-coding, 2024 is fixed and not change later
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            Console.WriteLine("Hello " + name + ". You come from " + country);
            Console.WriteLine("You are " + age + " years old now !");

            //output : machine => human
            Console.Write("Programming Technology");  //Write: no new line
            Console.WriteLine("Today is Thursday");   //WriteLine: create new line
            //Console.WriteLine('VNU IS is a member of VNU'); //Error: using single quotes
            //Console.WriteLine("Hanoi is the capital of Vietnam") //Error : missing semicolon
            //double quotes => string
            //single quotes => character/letter

            //variable (syntax: data-type variable-name = variable-value)
            int a = 10;
            int b = 20;
            int c = a + b;
            //use addition symbol (+) for string concatenation (merge/combination)
            Console.WriteLine("c = " + c);    //ignore the quotes to display variable's value
            Console.WriteLine("a + b = {0} + {1} = {2}", a, b, c); 
            //{0},{1},{2} is placeholder for 3 variables: a,b,c (correspondingly in order)
        }
    }
}
