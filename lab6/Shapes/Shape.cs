using System;
namespace Shapes
{
    // The abstract base class of the hierarchy.
    public abstract class Shape
    {
        public string PetName { get; set; }
        public Shape(string name = "NoName")
        { PetName = name; }

        // A single abstract method.
        public abstract void Draw();
    }
}
