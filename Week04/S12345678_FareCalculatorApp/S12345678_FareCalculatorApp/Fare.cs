using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_FareCalculatorApp
{
    class Fare
    {
        private double upToDistance;
        public double UpToDistance
        {
            get { return upToDistance; }
            set { upToDistance = value; }
        }

        private int amount;
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public Fare(double u, int a)
        {
            UpToDistance = u;
            Amount = a;
        }

        public override string ToString()
        {
            return $"Up to distance: {UpToDistance} Amount: {Amount}";
        }
    }
}
