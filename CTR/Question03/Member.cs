namespace Question03;

public class Member : Customer
{
    //attributes
    public double DiscountRate { get; set; }

    //constructors
    public Member(int id, string name, double amount, double discountRate) : base(id, name, amount)
    {
        DiscountRate = discountRate;
    }

    //methods
    public override double CalculateDiscount()
    {
        return Amount * (DiscountRate / 100);
    }

    public override string ToString()
    {
        return base.ToString() + $" Discount Rate: {DiscountRate}";
    }
}