namespace Question03;

public class PostPaid : MobilePlan
{
    //constructors
    public PostPaid() {}
    public PostPaid(string number) : base(number) {}
    public PostPaid(string number, int data, double roamingData) : base(number, data, roamingData) {}

    //methods
    public override double RoamingCharges()
    {
        return ((RoamingData > 1) ? (Math.Ceiling(RoamingData - 1) * 8) : 0);
    }

    public override string ToString()
    {
        return base.ToString() + $" ";
    }
}