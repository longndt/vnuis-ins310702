using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //display text "Hello world" to console (screen)
            //Console.Write: display text but not move to new line
            Console.Write("Hello world");
            //Console.WriteLine: display text then move to new line
            Console.WriteLine("Hello world");
            Console.WriteLine("Programming Technology - ASP.NET with SQL Server");
            //Single quotes '' could not be used to display to console
            //Only double quotes "" could be used
            //Console.WriteLine('Vietnam National University');
            //Pause terminal (console screen) to view result (output)
            Console.ReadKey();

            //1st way: Press CTRL + F5 (start without debugging) to run program
            //2nd way: Insert the statement "Console.ReadKey()" at the end of program
            //to pause console screen then press F5 (start with debugging)
        }

        //Note: comment in C# is similar to comment in C++
        //single line comment
        /*
         * multiple line comment
        */
    }
}
