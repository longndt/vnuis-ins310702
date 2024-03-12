using Shapes1;
using System;
namespace Shapes1
{
    public class Hexagon : Shape, IPointy
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
        public int Points
        {
            get
            {
                return 6;
            }
        }
    }
}
