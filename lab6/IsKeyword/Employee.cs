using System;
using System.Xml.Linq;
namespace IsKeyword
{
    class Employee
    {
        // Field data.
        private string empName;
        // Properties!
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }
        public int ID { get; set; }
        public float Pay { get; set; }
        public int Age { get; set; }
        public string SSN { get; }
        //constructors.
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay, "") { }
        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            SSN = ssn;
        }
        // Methods.
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", SSN);
        }
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
    }
}
