using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_MyBankApp
{
    class SavingsAccount : BankAccount
    {
        //attributes
        public double Rate { get; set; }

        //constructors
        public SavingsAccount() : base() { }
        public SavingsAccount(string ao, string aa, double b, double r) : base(ao, aa, b)
        {
            Rate = r;
        }

        //methods
        public double CalculateInterest()
        {
            double interest = Balance * Rate / 100;
            return interest;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Rate:{Rate}";
        }
    }
}
