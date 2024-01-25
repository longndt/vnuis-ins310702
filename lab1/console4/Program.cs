using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name;
            int age;
            Console.Write("Enter your name: ");
            //get keyboard's input and save to variable
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            //convert string input to integer
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " ! ");
            Console.WriteLine("You are " + age + " years old now !");
            Console.WriteLine("You were born in " + (2024 - age));
        }
    }
}
