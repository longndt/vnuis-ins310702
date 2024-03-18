using System;

namespace BasicInheritance
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            // Make a Car object and set max speed.
            Car myCar = new Car(80);

            // Set the current speed, and print it.
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
            Console.ReadLine();

            //Create new object for MiniVan
            MiniVan mv = new MiniVan();
        }
    }
}
