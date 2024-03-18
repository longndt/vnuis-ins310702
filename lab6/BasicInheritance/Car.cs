using System;
namespace BasicInheritance
{
    // A simple base class.
    class Car
    {
        //fields => variables
        public readonly int maxSpeed;
        private int currSpeed;

        //behaviours => methods

        //constructor
        public Car(int max) //parameterized
        {
            maxSpeed = max;
        }
        public Car()  //parameterless
        {
            maxSpeed = 55;
        }

        //attribute => method
        //no need to include validation => short-hand syntax
        //public int Speed { get; set; }

        //we must include validation => write complete method
        public int Speed
        {
            //getter
            get { return currSpeed; }
            //setter
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }
}
