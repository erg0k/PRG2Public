namespace S12345678_PosApp;

public class CartItem : Product
{
    //attributes
    public int Qty { get; set; }

    //constructors
    public CartItem() {}

    public CartItem(string code, string name, double price, int qty) : base(code, name, price)
    {
        Qty = qty;
    }

    //methods
    public override string ToString()
    {
        return base.ToString() + $" {Qty, -8}";
    }
}