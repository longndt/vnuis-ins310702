using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch...case => used for "equal" comparison
            //task: set fan's speed based on user selection
            /* 1 => speed is 1
               2 => speed is 2
               3 => speed is 3
               0 => fan stops
               other => invalid speed
            */
            int speed;
            Console.Write("Enter the fan's speed: ");
            speed = int.Parse(Console.ReadLine());
            switch (speed)
            {
                case 0:  //if
                    Console.WriteLine("Fan is stopped");
                    break;  //stop 
                case 1:  //else if
                    Console.WriteLine("Speed is 1");
                    break;  //stop 
                case 2:  //else if
                    Console.WriteLine("Speed is 2");
                    break;  //stop 
                case 3:  //else if
                    Console.WriteLine("Speed is 3");
                    break;  //stop 
                default: //else
                    Console.WriteLine("Invalid speed");
                    break;  //stop 
                //never forget to include "break" when using "switch...case"
            }
        }
    }
}
