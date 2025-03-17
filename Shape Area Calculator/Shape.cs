using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Area_Calculator
{
    abstract class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Shape: {0}", Name);
        }
    }
}
