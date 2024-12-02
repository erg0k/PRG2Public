namespace S12345678_ShapeApp;

public abstract class Shape : IComparable<Shape>
{
    //attributes
    public string Type { get; set; }
    public string Color { get; set; }

    //constructors
    public Shape() { }

    public Shape(string type, string color)
    {
        Type = type;
        Color = color;
    }

    //methods
    public abstract double FindArea();
    public abstract double FindPerimeter();

    public int CompareTo(Shape other)
    {
        return this.FindArea().CompareTo(other.FindArea());
    }

    public override string ToString()
    {
        return $"Type: {Type, -8} Color: {Color, -6}";
    }
}