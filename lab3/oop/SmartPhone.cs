using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    //OOP class
    internal class SmartPhone
    {
        //1. declare attributes (variables)
        //remember to set access modifier as "private"
        //for information hiding => security reason
        private string brand;
        private string model;
        private double price;

        //private string color; 
        //auto-implemented properties 
        //auto getter & setter
        public string Color { get; set; }
        public string Origin { get; set; }
        public DateTime manufacturedDate { get; set; }

        //2. declare behaviours (methods)
        //1 class may have 0 or 1 or many constructors
        //constructor : to create new object (class instance)
        //access modifider as "public" : other classes can access the methods
        public SmartPhone() { }  //empty/default constructor (parameterless constructor)
        public SmartPhone(string brand, string model, double price)
        {
            //use "this" keyword to clarify which one is attribute or parameter
            //"this" represent for "SmartPhone" (class name) in this situation
            this.brand = brand;   //left side: attribute - right side: parameter
            this.model = model;
            this.price = price;
        }   
        //when we can ignore "this" keyword ?
        //answer: when attribute and parameter name are different
        public SmartPhone (string b, string m)
        {
            brand = b;
            model = m;
        }

        //getter (observer)   => show data
        public String getBrand()
        {
            return brand;
        }
        public String getModel()
        {
            return model;
        }

        //setter (mutator)    => change data
        public void setPrice(double newPrice)
        {
            price = newPrice;
        }

        //custom methods (user-defined methods)
        public void showPhoneDetail()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Color: " + Color);
        }
    }
}
