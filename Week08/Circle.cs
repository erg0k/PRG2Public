namespace S12345678_ShapeApp;

public class Circle : Shape
{
    //attributes
    public double Radius { get; set; }

    //constructors  
    public Circle() { }
    public Circle(string color, double radius) : base("Circle", color)
    {
        Radius = radius;
    }

    //methods
    public override double FindArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override double FindPerimeter()
    {
        return 2 * Math.PI * Radius;
    }

    public override string ToString()
    {
        return base.ToString() + $" Radius: {Radius, -3}";
    }
}