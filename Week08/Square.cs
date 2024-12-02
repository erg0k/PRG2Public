namespace S12345678_ShapeApp;

public class Square : Shape
{
    //attributes
    public double Length { get; set; }

    //constructors
    public Square() {}
    public Square(string color, double length) : base("Square", color)
    {
        Color = color;
        Length = length;
    }

    //methods
    public override double FindArea()
    {
        return Length * Length;
    }

    public override double FindPerimeter()
    {
        return Length * 4;
    }

    public override string ToString()
    {
        return base.ToString() + $" Length: {Length, -3}";
    }
}