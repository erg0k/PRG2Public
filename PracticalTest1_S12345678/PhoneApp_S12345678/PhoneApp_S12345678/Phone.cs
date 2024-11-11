using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneApp_S12345678
{
    class Phone
    {
        public string PhoneNum { get; set; }
        public int Usage {  get; set; }
        public string PlanType { get; set; }

        public Phone(string p, int u, string pt)
        {
            PhoneNum = p;
            Usage = u;
            PlanType = pt;
        }

        public double CalculateCharge()
        {
            double charge = 0;
            if (PlanType == "A")
            {
                charge = 0.5 * Usage;
            }
            else if (PlanType == "B")
            {
                if (Usage >= 1000)
                {
                    charge = 0.2 * (Usage - 1000);
                }
                else
                {
                    charge = 0;
                }
            }
            else if (PlanType == "C")
            {
                if (Usage >= 5000)
                {
                    charge = 0.1 * (Usage - 5000);
                }
                else
                {
                    charge = 0;
                }
            }

            return charge;
        }

        public override string ToString()
        {
            return $"Phone Number: {PhoneNum} Usage: {Usage} Plan Type: {PlanType}";
        }
    }
}
