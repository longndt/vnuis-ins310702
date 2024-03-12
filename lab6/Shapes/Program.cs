using System;

namespace Shapes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");

            // Make an array of Shape-compatible objects.
            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),
                                new Circle("Beth"), new Hexagon("Linda")};

            // Loop over each item and interact with the
            // polymorphic interface.
            foreach (Shape s in myShapes)
            {
                s.Draw();
            }

            /*
            //This calls the Draw() method of the ThreeDCircle.
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            //This calls the Draw() method of the Circle
            Shape s1 = new Circle();
            s1.Draw();
            //This calls the Draw() method of the Circle class
            Shape s2 = new ThreeDCircle();
            s2.Draw();
            */

            Console.ReadLine();
        }
    }
}
