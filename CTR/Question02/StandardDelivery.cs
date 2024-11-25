namespace Question02;

public class StandardDelivery
{
    //attributes
    public string Name {get; set; }
    public string Address { get; set; }
    public int Distance { get; set; }

    //constructors
    public StandardDelivery() {}
    public StandardDelivery(string name, string address, int distance)
    {
        Name = name;
        Address = address;
        Distance = distance;
    }

    //methods
    public virtual double CalculateCost()
    {
        const double firstTenKm = 7.0;
        const double tenKmOnwards = 13.0;

        if (Distance <= 10)
        {
            return firstTenKm;
        }

        return tenKmOnwards;
    }

    public override string ToString()
    {
        return $"Name: {Name} Address: {Address} Distance: {Distance}";
    }
}