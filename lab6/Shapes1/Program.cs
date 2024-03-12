using Shapes1;
using System;

namespace Shapes1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IPointy iPointy;
            //Reference of inerface can point to object of its subtype
            iPointy = new Hexagon();
            Console.WriteLine("Hexagon points: {0}", iPointy.Points);
            Console.ReadLine();
        }
    }
}
