using System;
using System.Collections;

class Program
{
    static void CalculateBMI()
    {
        Console.WriteLine("\nBMI Calculation");

        Console.Write("Enter your weight : ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height : ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / (height * height);
        Console.WriteLine($"Your BMI is {bmi}\n");
    }

    static void CalculateDiscount()
    {
        Console.Write("\nEnter amount   ($) : ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double discountRate;

        if (amount <= 100)
        {
            discountRate = 0;
        }

        else if (amount <= 500)
        {
            discountRate = 5;
        }

        else if (amount <= 1000)
        {
            discountRate = 10;
        }

        else
        {
            discountRate = 20;
        }

        Console.WriteLine($"Discount given (%) : {discountRate}");

        double discount = amount * (discountRate / 100);

        Console.WriteLine($"Discount amount($) : {discount:F2}\n");
    }

    static void DisplayMultiplicationTable()
    {
        Console.Write("\nEnter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine($"{i,-7} {number * i}");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("------------- MENU --------------");
            Console.WriteLine("[1] Calculate Body Mass Index");
            Console.WriteLine("[2] Calculate Discount");
            Console.WriteLine("[3] Display Multiplication Table");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your option : ");

            String option = Console.ReadLine();
            List<string> validOptions = new List<string> {"1", "2", "3", "0"};

            if (validOptions.Contains(option))
            {
                if (option == "1")
                {
                    CalculateBMI();
                }

                else if (option == "2")
                {
                    CalculateDiscount();
                }

                else if (option == "3")
                {
                    DisplayMultiplicationTable();
                }

                else
                {
                    Console.WriteLine("Bye");
                    break;
                }
            }

            else
            {
                Console.WriteLine("Invalid option! Please try again.\n");
            }
        }
    }
}