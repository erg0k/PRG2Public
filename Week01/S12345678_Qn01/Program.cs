Console.Write("Enter your weight (kg): ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your height (m): ");
double height = Convert.ToDouble(Console.ReadLine());

double bmi = weight / (height * height);
String healthCategory;

if (bmi < 18.5)
{
    healthCategory = "Under weight";
}

else if (bmi < 23)
{
    healthCategory = "Normal weight";
}

else if (bmi < 27.5)
{
    healthCategory = "Over weight";
}

else
{
    healthCategory = "Obese";
}

Console.WriteLine($"Your body mass index is {bmi}");
Console.WriteLine($"You are {healthCategory}.");
