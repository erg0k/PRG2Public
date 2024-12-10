namespace Question02
{
    class Program
    {
        static Prepaid InitPhoneNumber()
        {
            Console.Write("Enter the prepaid mobile number: ");
            string newNumber = Console.ReadLine();
            Prepaid newPrepaid = new Prepaid(newNumber);
            Console.WriteLine($"Prepaid card {newNumber} with $0 and 0 GB has been created.\n");
            return newPrepaid;
        }

        static void TopUpPlan(Prepaid pNumber)
        {
            Console.Write($"Enter the amount to top-up balance for {pNumber.Number}: $");
            pNumber.TopUpBalance(Convert.ToDouble(Console.ReadLine()));
            Console.Write($"Enter the amount of data to buy for {pNumber.Number}: ");
            pNumber.BuyData(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"{pNumber.Number} has ${pNumber.Balance} and {pNumber.Data} GB, top-up on {DateTime.Now.ToString("dd MMM yyyy")}.");
        }

        static void Main()
        {
            Prepaid newPrepaid = InitPhoneNumber();
            TopUpPlan(newPrepaid);
        }
    }
}
