using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Remember to select default (startup) project 
//in case there are more than 1 project in a solution
namespace console2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hanoi is the capital of Vietnam");
            Console.WriteLine("Bangkok is the capital of Thailand");

            //we can use "\n" to move to new line
            // Set the Foreground (text) color  
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hanoi is the capital of Vietnam \nBangkok is the capital of Thailand");

            //text formatting
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} - {1} - {2}", "Hanoi", "Danang", "HCM City");
        }
    }
}
