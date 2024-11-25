namespace Question03;

public abstract class Customer
{
    //attributes
    public int Id { get; set; }
    public string Name { get; set; }
    public double Amount { get; set; }

    //constructors
    public Customer(int id, string name, double amount)
    {
        Id = id;
        Name = name;
        Amount = amount;
    }

    //methods
    public abstract double CalculateDiscount();

    public override string ToString()
    {
        return $"ID: {Id} Name: {Name} Amount: {Amount}";
    }
}