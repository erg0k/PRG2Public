namespace CustomerApp_S12345678
{
    class Customer
    {
        //attributes
        public string Id {  get; set; }
        public string Name { get; set; }
        public double LoanAmount { get; set; }
        public int RepaymentPeriod { get; set; } //years
        public int InterestRate { get; set; } //percent

        //constructors
        public Customer() { }
        public Customer(string id, string name, double loan, int period, int interest)
        {
            Id = id;
            Name = name;
            LoanAmount = loan;
            RepaymentPeriod = period;
            InterestRate = interest;
        }

        //methods
        public double CalculateAmountDue()
        {
            double interest = LoanAmount * ((double)InterestRate / 100) * (double)RepaymentPeriod;
            double totalDue = interest + LoanAmount;
            return totalDue;
        }

        public bool TransferLoanAmount(Customer receipient, double amount)
        {
            if (receipient == this)
            {
                return false;
            }
            else if (amount > this.LoanAmount)
            {
                return false;
            }
            else
            {
                this.LoanAmount -= amount;
                receipient.LoanAmount += amount;
                return true;
            }

        }

        public override string ToString()
        {
            return $"{Id, -5} {Name, -8} {LoanAmount.ToString("#,##0.00"), 11} {RepaymentPeriod, 16} {InterestRate, 13}";
        }
    }
}
