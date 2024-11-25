using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_AbstractShapeApp
{
    abstract class Shape
    {
        //attributes
        public string Type { get; set; }
        public string Color { get; set; }

        //constructors
        public Shape() {}

        public Shape(string type, string color)
        {
            Type = type;
            Color = color;
        }

        //methods
        public abstract double FindArea();
        public abstract double FindPerimeter();

        public override string ToString()
        {
            return $"Type: {Type, -13} Color: {Color, -8}";
        }
    }
}
