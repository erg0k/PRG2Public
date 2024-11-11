Console.Write("Enter a number : ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{i, -7} {number * i}");
}