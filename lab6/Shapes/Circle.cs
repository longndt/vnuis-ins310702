using System;
namespace Shapes
{
    public class Circle : Shape
    {
        public Circle()
        {
        }
        public Circle(string name) : base(name)
        {
        }
        //You must either override this method or mark this class as abstract
        public override void Draw()
        {
            Console.WriteLine("Drawing the {0} Circle", PetName);
        }
    }
}
