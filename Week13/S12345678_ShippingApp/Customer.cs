namespace S12345678_ShippingApp;

public class Customer
{
    //attributes
    public string Name { get; set; }
    public string Tel { get; set; }
    public ShippingAddr Addr { get; set; }

    //constructors
    public Customer() {}
    public Customer(string name, string tel, ShippingAddr addr)
    {
        Name = name;
        Tel = tel;
        Addr = addr;
    }

    //methods
    public override string ToString()
    {
        return $"{Name, -10} {Tel, -10} {Addr}";
    }
}