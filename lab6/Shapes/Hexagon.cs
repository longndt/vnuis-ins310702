using System;
namespace Shapes
{
    public class Hexagon : Shape
    {
        public Hexagon()
        {
        }
        public Hexagon(string name) : base(name)
        {
        }
        //You must either override this method or mark this class as abstract
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} Hexagon", PetName);
        }
    }
}
