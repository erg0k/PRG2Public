namespace Question02;

public class Prepaid : MobilePlan
{
    //attributes
    public double Balance { get; set; }
    public Stack<DateTime> History { get; set; } = new Stack<DateTime>();

    //constructors
    public Prepaid() {}
    public Prepaid(string number) : base(number) {}
    public Prepaid(string number, int data, double balance, Stack<DateTime> history) : base(number, data)
    {
        Balance = balance;
        History = history;
    }

    //methods
    public void BuyData(int numGB)
    {
        if (numGB == 10)      {Data += 10; Balance -= 10;}
        else if (numGB == 20) {Data += 20; Balance -= 15;}
        else                  {Data += 30; Balance -= 20;}


        History.Push(DateTime.Now);
    }

    public void TopUpBalance(double amount)
    {
        Balance += amount;
    }

    public override string ToString()
    {
        string s = "";
        foreach (DateTime date in History)
        {
            s += $"{date.ToString("dd MMM yyyy")} ";
        }

        return base.ToString() + $" Balance:\t{Balance} History:\t{s}";
    }
}