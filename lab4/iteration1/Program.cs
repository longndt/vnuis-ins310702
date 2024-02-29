using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //iteration (loop) structure
            //for loop

            //task 1: display all numbers from 1 to 100
            //for (int i=1; i<=1; i++)  
            //    Console.WriteLine(i);
            //Note: avoid infinite loop 

            //task 2: display all even numbers from 1 to 100
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2==0)   //number is divisible by 2 => even number
            //        Console.WriteLine(i);
            //}

            //task 2A: display all even numbers from 1 to 100 using "continue"  
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)    //check for odd number
                    continue;      //skip odd number
                Console.WriteLine(i);
            }

            // 1 equal (=) : assignment
            // 2 equal (==) : comparison (value only)
            // 3 equal (===) : comparison (both value and type)
        }
    }
}
