namespace Question02;

public class InstantDelivery : StandardDelivery
{
    //attributes
    public double BaseFee { get; set; }

    //constructors
    public InstantDelivery() {}

    public InstantDelivery(string name, string address, int distance, double fee) : base(name, address, distance)
    {
        BaseFee = fee;
    }

    //methods
    public override double CalculateCost()
    {
        const double firstFive = 1;
        const double fiveOnwards = 0.70;

        if (Distance > 5)
        {
            return BaseFee + (5 * firstFive) + ((Distance - 5) * fiveOnwards); 
        }
        return BaseFee + (Distance * firstFive);
    }

    public override string ToString()
    {
        return base.ToString() + $" Base Fee: {BaseFee}";
    }
}