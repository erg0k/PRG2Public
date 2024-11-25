namespace Question01;

public class Line
{
    //attributes
    public int A { get; set; }
    public int B { get; set; }
    public int C { get; set; }

    //constructors
    public Line() {}

    public Line(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    //methods
    public double FindIntersectionX(Line other)
    {
        double intersectionX = (double)(this.B * other.C - other.B * this.C) / (double)(this.A * other.B - other.A * this.B);
        return intersectionX;
    }

    public double FindIntersectionY(Line other)
    {
        double intersectionY = (double)(this.C * other.A - other.C * this.A) / (double)(this.A * other.B - other.A * this.B);
        return intersectionY;
    }

    public override string ToString()
    {
        return $"A: {A} B: {B} C: {C}";
    }
}