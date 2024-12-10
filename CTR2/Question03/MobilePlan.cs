namespace Question03;

public abstract class MobilePlan : IComparable<MobilePlan>
{
    //attributes
    public string Number { get; set; }
    public int Data { get; set; }//GB
    public double RoamingData { get; set; }//GB

    //constructors
    public MobilePlan() { }

    public MobilePlan(string number)
    {
        Number = number;
    }

    public MobilePlan(string number, int data, double roamingData)
    {
        Number = number;
        Data = data;
        RoamingData = roamingData;
    }

    //methods
    public abstract double RoamingCharges();

    public int CompareTo(MobilePlan other)
    {
        return this.RoamingCharges().CompareTo(other.RoamingCharges());
    }

    public override string ToString()
    {
        return $"Number:\t{Number} Data:\t{Data}";
    }
}