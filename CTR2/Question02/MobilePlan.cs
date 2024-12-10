namespace Question02;

public class MobilePlan
{
    //attributes
    public string Number { get; set; }
    public int Data { get; set; }//GB

    //constructors
    public MobilePlan() {}

    public MobilePlan(string number)
    {
        Number = number;
    }

    public MobilePlan(string number, int data)
    {
        Number = number;
        Data = data;
    }

    //methods
    public override string ToString()
    {
        return $"Number:\t{Number} Data:\t{Data}";
    }
}