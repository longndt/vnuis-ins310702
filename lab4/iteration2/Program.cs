using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while loop
            //task: display all numbers divisible by both 3 & 4 from 1 to 1000

            int i = 1;
            while (i<=1000)
            {
                //if (i%3==0 && i%4==0)
                if (i%12==0)
                {
                    Console.WriteLine(i); 
                }
                i++;
            }
        }
    }
}
