using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
 
    //OOP Class (2 components: attributes & behaviours)
    //we use OOP class to model (represent) an actual object in our life
    internal class Car
    {
        //1. attributes (variables)
        public string carBrand; 
        public string carModel;
        public double carPrice;

        //2. behaviours (methods)
        //2.1 constructor
        //2.1.1 default constructor : parameterless constructor (constructor without parameter)
        //if we do not declare any constructor, C# will automatic create and use default constructor
        //default constructor can be empty or not
        public Car() {
            //carBrand = "Toyota"; //default value
        }    
        //2.1.2 custom constructor: parameterized constructor (constructor with parameter)
        //1st way: without "this" keyword: variable name and parameter name must be different
        //public Car(string brand, string model, double price)
        //{
        //    carBrand = brand;
        //    carModel = model;
        //    carPrice = price;
        //}
        //2nd way: with "this" keyword: variable name and parameter name can be similar
        public Car(string carBrand, string carModel, double carPrice)
        {
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carPrice = carPrice;
        }

        public void displayCar()
        {
            Console.WriteLine("Car brand: " + carBrand);
            Console.WriteLine("Car model: " + carModel);
            Console.WriteLine("Car price: $" + carPrice);
        }
    }
}
