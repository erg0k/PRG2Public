namespace S12345678_EmployeeApp;

public class FullTimeEmployee : Employee
{
    //attributes
    public double BasicPay { get; set; }
    public double Allowance { get; set; }

    //constructors
    public FullTimeEmployee() { }

    public FullTimeEmployee(int id, string name, double basicPay, double allowance) : base(id, name)
    {
        BasicPay = basicPay;
        Allowance = allowance;
    }

    //methods
    public override double CalculatePay()
    {
        return BasicPay + Allowance;
    }

    public override string ToString()
    {
        return base.ToString() + $" Basic Pay: {BasicPay} Allowance: {Allowance}";
    }
}