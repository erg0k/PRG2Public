namespace Question03;

public class PremiumMember : Customer
{
    //attributes
    public int RewardPoints { get; set; }

    //constructors
    public PremiumMember(int id, string name, double amount, int rewardPoints) : base(id, name, amount)
    {
        RewardPoints = rewardPoints;
    }

    //methods
    public override double CalculateDiscount()
    {
        return RewardPoints / 10;
    }
}