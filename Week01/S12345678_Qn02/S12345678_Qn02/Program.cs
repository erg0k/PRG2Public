Console.Write("Enter amount   ($) : ");
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

Console.WriteLine($"Discount amount($) : {discount:F2}");