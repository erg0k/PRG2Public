using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_MyShapeApp
{
    class Circle
    {
        //attributes
        public double Radius { get; set; }

        //constructors
        public Circle() { }
        public Circle(double r) { Radius = r; }

        //methods
        public virtual double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public override string ToString()
        {
            return $"Radius: {Radius}";
        }
    }
}
