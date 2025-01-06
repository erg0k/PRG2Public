namespace S12345678_ExceptionHandling
{
    class Program
    {
        static void CalculateBMI()
        {
            Console.WriteLine("\nBMI Calculation");

            double userWeight = 0;
            double userHeight = 0;
            
            while (userWeight <= 0)
            {
                try
                {
                    Console.Write("Enter your weight : ");
                    userWeight = Convert.ToDouble(Console.ReadLine());

                    if (userWeight <= 0) { Console.WriteLine("Weight must be greater than 0!"); }
                }
                catch (FormatException) { Console.WriteLine("Please enter a number!"); }
                catch (Exception ex) { Console.WriteLine("Please enter a valid input!"); }
            }

            while (userHeight <= 0)
            {
                try
                {
                    Console.Write("Enter your height : ");
                    userHeight = Convert.ToDouble(Console.ReadLine());

                    if (userHeight <= 0) { Console.WriteLine("Height must be greater than 0!"); }
                }
                catch (FormatException) { Console.WriteLine("Please enter a number!"); }
                catch (Exception ex) { Console.WriteLine("Please enter a valid input!"); }
            }

            try
            {
                Console.WriteLine($"Your BMI is {userWeight / (userHeight * userHeight)}");
            }
            catch (OverflowException overflowEx) { Console.WriteLine("Weight or Height too large!"); }
            catch (Exception ex) { Console.WriteLine("Error!"); } //something has gone very wrong if this executes
        }

        static void CalculateDiscount()
        {
            double amountSpent = 0;

            while (amountSpent <= 0)
            {
                try
                {
                    Console.Write("Enter amount   ($) : ");
                    amountSpent = Convert.ToDouble(Console.ReadLine());

                    if (amountSpent <= 0) { Console.WriteLine("Amount must be greater than 0!"); }
                }
                catch (FormatException) { Console.WriteLine("Please enter a number!"); }
                catch (Exception ex) { Console.WriteLine("Please enter a valid input"); }
            }

            double discountRate = 0;

            if (amountSpent <= 100)         { discountRate = 0; }
            else if (amountSpent <= 500)    { discountRate = 5; }
            else if (amountSpent <= 1000)   { discountRate = 10; }
            else                            { discountRate = 20; }

            Console.WriteLine($"Discount given (%) : {discountRate}");
            Console.WriteLine($"Discount amount($) : {amountSpent - (amountSpent * (1 - (discountRate / 100) /*this shouldn't throw an error*/)):F2}");
        }

        static void DisplayMultiplicationTable()
        {
            int userNumber = 0;

            while (userNumber <= 0)
            {
                try
                {
                    Console.Write("Enter a number : ");
                    userNumber = Convert.ToInt32(Console.ReadLine());

                    if (userNumber <= 0) { Console.WriteLine("Number must be greater than 0!"); }
                }
                catch (FormatException) { Console.WriteLine("Please enter a number!"); }
                catch (Exception ex) { Console.WriteLine("Please enter a valid input!"); }
            }

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{i, -7} {userNumber * i}");
            }
        }

        static string DisplayMenu()
        {
            Console.WriteLine("------------- MENU --------------\r\n" +
                              "[1] Calculate Body Mass Index\r\n" +
                              "[2] Calculate Discount\r\n" +
                              "[3] Display Multiplication Table\r\n" +
                              "[0] Exit\r\n---------------------------------\r\n");
            Console.Write("Enter your option : ");
            string userMenuOption = Console.ReadLine();
            return userMenuOption;
        }

        static void Main()
        {
            while (true)
            {
                string userMenuOption = DisplayMenu();

                if (userMenuOption == "0")
                {
                    Console.WriteLine("Bye");
                    break;
                }

                switch (userMenuOption)
                {
                    case "1":
                        CalculateBMI();
                        break;

                    case "2":
                        CalculateDiscount();
                        break;

                    case "3":
                        DisplayMultiplicationTable();
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }
            }
        }
    }
}
