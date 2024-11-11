using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_FareCalculatorApp
{
    class BusStop
    {
        private double distance;
        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string road;
        public string Road
        {
            get { return road; }
            set { road = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public BusStop(double di, string c, string r, string de)
        {
            Distance = di;
            Code = c;
            Road = r;
            Description = de;
        }

        public override string ToString()
        {
            return $"Distance: {Distance} Code: {Code} Road: {Road} Description: {Description}";
        }
    }
}
