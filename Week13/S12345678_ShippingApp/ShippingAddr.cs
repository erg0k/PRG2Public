namespace S12345678_ShippingApp;

public class ShippingAddr
{
    //attributes
    public string Country { get; set; }
    public string Street { get; set; }

    //constructors
    public ShippingAddr() {}
    public ShippingAddr(string country, string street)
    {
        Country = country;
        Street = street;
    }

    //methods
    public override string ToString()
    {
        return $"{Country, -12} {Street}";
    }
}