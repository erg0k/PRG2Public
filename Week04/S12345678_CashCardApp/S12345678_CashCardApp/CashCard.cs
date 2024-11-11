using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_CashCardApp
{
    class CashCard
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //default constructor
        public CashCard()
        {
            Id = "";
            Balance = 0;
        }

        public CashCard(string i, double b)
        {
            Id = i;
            Balance = b;
        }

        public void TopUp(double additionAmount)
        {
            Balance += additionAmount;
        }

        public bool Deduct(double deductionAmount)
        {
            if (Balance >= deductionAmount)
            {
                Balance -= deductionAmount;
                return true;
            }

            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"ID: {Id} Balance: {Balance}";
        }
    }
}
