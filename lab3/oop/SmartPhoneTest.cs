using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    internal class SmartPhoneTest
    {
        static void Main(string[] args)
        {
            //create new object by calling constructor
            SmartPhone sm1 = new SmartPhone();
            SmartPhone iPhone = new SmartPhone("Apple", "iPhone 15 Pro Max", 1500);

            //display result to console
            Console.WriteLine(iPhone.getBrand() + " " + iPhone.getModel());
            iPhone.setPrice(1200);  //change phone's price
            iPhone.showPhoneDetail();  //display phone's info
            
            //iPhone.setColor("Black"); => traditional way
            iPhone.Color = "Black";   //new way
            iPhone.showPhoneDetail();
        }
    }
}
