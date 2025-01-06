namespace S12345678_PosApp;

public class Product
{
    //attributes
    public string Code { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    //constructors
    public Product() {}

    public Product(string code, string name, double price)
    {
        Code = code;
        Name = name;
        Price = price;
    }

    //methods
    public override string ToString()
    {
        return $"{Code, -4} {Name, -15} {Price, -7:F2}";
    }
}