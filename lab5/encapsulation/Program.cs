using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country vietnam = new Country("HN");

            //error: inaccessible
            //due to "private" access modifier
            // vietnam.capital = "HN"; 

            vietnam.setCapital("Hanoi");
           
            vietnam.show();
        }
    }
}
