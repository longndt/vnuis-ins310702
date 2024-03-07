using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //OOP Test Class
    internal class Program
    {
        static void Main(string[] args)
        {
            //objects: class instances
            //1 class may have 1 more many objects
            //create Car objects using Car class
            //we use constructor to create objects
            Car car1 = new Car();
            Car car2 = new Car("BMW", 1000, 999999);

            car1.displayCar();
            car2.displayCar();
        }
    }
}
