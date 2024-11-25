using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12345678_MyBankApp
{
    class BankAccount
    {
        //attributes
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public double Balance { get; set; }

        //constructors
        public BankAccount() { }
        public BankAccount(string ao, string aa, double b)
        {
            AccNo = ao;
            AccName = aa;
            Balance = b;
        }

        //methods
        public void Deposit(double depositAmount)
        {
            Balance += depositAmount;
        }

        public bool Withdraw(double withdrawAmount)
        {
            if (withdrawAmount < Balance)
            {
                Balance -= withdrawAmount;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Acc No:{AccNo} Acc Name:{AccName} Balance:{Balance}";
        }
    }
}
