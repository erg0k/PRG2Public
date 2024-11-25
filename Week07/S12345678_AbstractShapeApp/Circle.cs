using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_AbstractShapeApp
{
    class Circle : Shape, IComparable<Circle>
    {
        //attributes
        public double Radius { get; set; }

        //constructors  
        public Circle() { }
        public Circle(string color, double radius) : base("Circle", color)
        {
            Radius = radius;
        }

        //methods
        public override double FindArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double FindPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public int CompareTo(Circle other)
        {
            return this.FindArea().CompareTo(other.FindArea());
        }

        public override string ToString()
        {
            return base.ToString() + $" Radius: {Radius}";
        }
    }
}
