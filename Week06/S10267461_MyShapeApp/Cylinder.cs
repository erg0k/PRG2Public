using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_MyShapeApp
{
    class Cylinder : Circle
    {
        //attributes
        public double Length { get; set; }

        //constructors
        public Cylinder() : base() { }
        public Cylinder(double r, double l) : base(r) { Length = l; }

        //methods
        public override double CalculateArea()
        {
            double area = (base.CalculateArea() * 2) + (2 * Math.PI * Radius * Length);
            return area;
        }

        public double CalculateVolume()
        {
            double volume = base.CalculateArea() * Length;
            return volume;
        }

        public override string ToString()
        {
            return base.ToString() + $"Length: {Length}";
        }
    }
}
