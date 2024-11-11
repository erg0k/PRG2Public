namespace S12345678_MyBankApp
{
    class Program
    {
        static void DisplayAll(Dictionary<string, SavingsAccount> sCollection)
        {
            Console.WriteLine();
            foreach (SavingsAccount account in sCollection.Values)
            {
                Console.WriteLine(account);
            }
            Console.WriteLine();
        }

        static void DisplayDetails(Dictionary<string, SavingsAccount> sCollection)
        {
            Console.WriteLine($"\n{"Acc No", -10} {"Acc Name", -13} {"Balance", -13} {"Rate", -6} {"Interest", 8}");
            foreach (SavingsAccount account in sCollection.Values)
            {
                double interest = account.CalculateInterest();
                Console.WriteLine($"{account.AccNo, -10} {account.AccName, -13} {account.Balance, -13:F2} {account.Rate, -6:F2} {interest, 8:F2}");
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("[1] Display all accounts");
            Console.WriteLine("[2] Deposit");
            Console.WriteLine("[3] Withdraw");
            Console.WriteLine("[4] Display details");
            Console.WriteLine("[0] Exit");
            Console.Write("Enter option: ");
        }

        static string GetAccountNumber()
        {
            Console.Write("\nEnter the Account Number: ");
            return Console.ReadLine();
        }

        static void ReadSavingsAccount(Dictionary<string, SavingsAccount> sCollection)
        {
            using (StreamReader sr = new StreamReader("savings_account.csv"))
            {
                string? s = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    string[] accountInfo = s.Split(',');
                    sCollection[accountInfo[0]] = new SavingsAccount(accountInfo[0], accountInfo[1], Convert.ToDouble(accountInfo[2]), Convert.ToDouble(accountInfo[3]));
                }
            }
        }

        static SavingsAccount? Search(Dictionary<string, SavingsAccount> sCollection, string accNo)
        {
            foreach (KeyValuePair<string, SavingsAccount> kvp in sCollection)
            {
                if (accNo ==  kvp.Key)
                {
                    return kvp.Value;
                }
            }
            return null;
        }

        static void Main()
        {
            Dictionary<string, SavingsAccount> savingsAccCollection = new Dictionary<string, SavingsAccount> ();
            ReadSavingsAccount(savingsAccCollection);

            while (true)
            {
                DisplayMenu();
                string menuOption = Console.ReadLine();

                if (menuOption == "0")
                {
                    Console.WriteLine("\n---------\nGoodbye!\n---------");
                    break;
                }
                
                switch (menuOption)
                {
                    case "1":
                        DisplayAll(savingsAccCollection);
                        break;

                    case "2":
                        string depositInput = GetAccountNumber();

                        SavingsAccount? depositAccount = Search(savingsAccCollection, depositInput);
                        if (depositAccount == null)
                        {
                            Console.WriteLine("Unable to find account number. Please try again.\n");
                        }
                        else
                        {
                            Console.Write("Amount to deposit: ");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());

                            depositAccount.Deposit(depositAmount);
                            Console.WriteLine($"${depositAmount} deposited successfully");
                            Console.WriteLine(depositAccount + "\n");
                        }

                        break;

                    case "3":
                        string withdrawInput = GetAccountNumber();

                        SavingsAccount? withdrawAccount = Search(savingsAccCollection, withdrawInput);
                        if (withdrawAccount == null)
                        {
                            Console.WriteLine("Unable to find account number. Please try again.\n");
                        }
                        else
                        {
                            Console.Write("Amount to withdraw: ");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                            bool canWithdraw = withdrawAccount.Withdraw(withdrawAmount);
                            if (canWithdraw)
                            {
                                Console.WriteLine($"${withdrawAmount} withdrawn successfully");
                                Console.WriteLine(withdrawAccount + "\n");
                            }
                            else Console.WriteLine("Insufficient funds.\n");
                        }

                        break;

                    case "4":
                        DisplayDetails(savingsAccCollection);
                        break;
                }
            }
        }
    }
}