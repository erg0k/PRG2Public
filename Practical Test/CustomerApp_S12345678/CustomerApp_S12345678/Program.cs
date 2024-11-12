namespace CustomerApp_S12345678
{
    class Program
    {

        static void Main()
        {
            //I chose to use a dictionary as dictionaries will allow me to easily sort and find customers
            //by using their identifying key (user id), to get other associated value (like loan amount)
            Dictionary<string, Customer> customerDict = new Dictionary<string, Customer>();

            InitialiseCustomerCollection(customerDict);
            DisplayOutput(customerDict);

            Console.Write("Enter the ID of the customer to search: ");
            string inputID = Console.ReadLine().ToUpper();

            Customer? customer = SearchCustomer(customerDict, inputID);
            if (customer == null)
            {
                Console.WriteLine("No such customer!");
            }
            else Console.WriteLine($"Name of the customer with id {inputID.ToLower()} is {customer.Name}");

            while (true) ProcessLoan(customerDict);
        }
        static void InitialiseCustomerCollection(Dictionary<string, Customer> cDict)
        {
            using (StreamReader sr = new StreamReader("Customers.csv"))
            {
                string? s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] cInfo = s.Split(',');
                    cDict[cInfo[0]] = new Customer(cInfo[0], cInfo[1], Convert.ToDouble(cInfo[2]), 
                        Convert.ToInt32(cInfo[3]), Convert.ToInt32(cInfo[4]));
                }
            }
        }

        static void DisplayOutput(Dictionary<string, Customer> cDict)
        {
            Console.WriteLine($"{"ID", -5} {"Name", -8} {"Loan Amount", 11} {"Repayment Period", 16} " +
                $"{"Interest Rate", 13} {"Total Amount Due", 16}");
            Console.WriteLine($"{"====", -5} {"====", -8} {"===========", 11} {"================", 16} " +
                $"{"=============", 13} {"================", 16}");

            //PLEASE FIX FORMATTING LATER
            foreach (Customer customer in cDict.Values)
            {   
                double totalDue = customer.CalculateAmountDue();
                Console.WriteLine($"{customer} {totalDue.ToString("#,##0.00"), 16}");
            }
        }

        static Customer? SearchCustomer(Dictionary<string, Customer> cDict, string inputID)
        {
            Customer customer = null;
            if (cDict.ContainsKey(inputID))
            {
                customer = cDict[inputID];
            }
            return customer;
        }

        static void ProcessLoan(Dictionary<string, Customer> cDict)
        {

            Console.Write("Enter the ID of the recipient: ");
            string loanIDRec = Console.ReadLine().ToUpper();
            Customer? customerRec = SearchCustomer(cDict, loanIDRec);
            while (customerRec == null)
            {
                Console.WriteLine("Recipient ID not found.");
                Console.Write("Enter the ID of the recipient: ");
                loanIDRec = Console.ReadLine().ToUpper();
                customerRec = SearchCustomer(cDict, loanIDRec);
            }


            Console.Write("Enter the ID of the sender: ");
            string loanIDSen = Console.ReadLine().ToUpper();
            Customer? customerSen = SearchCustomer(cDict, loanIDSen);
            while (customerSen == null)
            {
                Console.WriteLine("Sender ID not found.");
                Console.Write("Enter the ID of the sender: ");
                loanIDSen = Console.ReadLine().ToUpper();
                customerSen = SearchCustomer(cDict, loanIDSen);
            }

            Console.Write("Enter the loan amount to transfer: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());



            bool canTransfer = customerSen.TransferLoanAmount(customerRec, loanAmount);
            if (canTransfer)
            {
                Console.WriteLine("Transfer successful");
                DisplayOutput(cDict);
            }
            else
            {
                if (customerSen == customerRec) Console.WriteLine("Cannot transfer to the same customer.");
                else Console.WriteLine("Insufficient amount to transfer.");
            }
        }
    }
}
