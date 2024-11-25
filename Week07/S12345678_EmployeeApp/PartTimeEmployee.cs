namespace S12345678_EmployeeApp;

public class PartTimeEmployee : Employee
{
    //attributes
    public double DailyRate { get; set; }
    public int DaysWorked { get; set; }

    //constructors
    public PartTimeEmployee() { }

    public PartTimeEmployee(int id, string name, double dailyRate, int daysWorked) : base(id, name)
    {
        DailyRate = dailyRate;
        DaysWorked = daysWorked;
    }

    //methods
    public override double CalculatePay()
    {
        return DaysWorked * DailyRate;
    }

    public override string ToString()
    {
        return base.ToString() + $"  Daily Rate: {DailyRate} Days Worked: {DaysWorked}";
    }
}