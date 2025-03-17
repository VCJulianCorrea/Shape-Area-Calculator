using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator
{
    class Rectangle : Shape, Interface
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width, string name) : base(name)
        {
            Length = length;
            Width = width;
        }
    }
}
