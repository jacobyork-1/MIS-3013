//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_and_Circle
{
    class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle()
        {
            Width = 1;
            Length = 1;
        }

        public double CalculateArea()
        {
            return Width * Length;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Length);
        }
    }
}
