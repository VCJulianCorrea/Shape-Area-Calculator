using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator
{
    class Circle : Shape, Interface
    {
        public double Radius { get; set; }
        public Circle(double radius, string name) : base(name)
        {
            Radius = radius;
        }
        double area = ICalculateRadius();
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Radius: {0} \nArea: {1}", Radius, area);
        }
    }
}
