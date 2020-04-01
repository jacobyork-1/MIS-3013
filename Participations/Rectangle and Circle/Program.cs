//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_and_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, l, r = 1;

            Rectangle rect1 = new Rectangle
            {
                Width = 10,
                Length = 20
            };


            Circle circ1 = new Circle
            {
                Radius = 30
            };


            Console.WriteLine($"The rectangle has an area of {rect1.CalculateArea()} and a perimeter of {rect1.CalculatePerimeter()}.");

            Console.WriteLine($"The circle has an area of {circ1.CalculateArea()} and a perimeter of {circ1.CalculatePerimeter()}.");

            Console.ReadKey();
        }
    }
}
