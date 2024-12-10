namespace Question01;

public class SquarePyramid
{
    //attributes
    public double A { get; set; }
    public double H { get; set; }

    //constructors
    public SquarePyramid() {}
    public SquarePyramid(double a, double h)
    {
        A = a;
        H = h;
    }

    //methods
    public double GetVolume()
    {
        return (A * A * H) / 3;
    }

    public double GetSurfaceArea()
    {
        return A * (A + Math.Sqrt((A * A) + (4 * H * H)));
    }

    public override string ToString()
    {
        return $"A:\t{A} H:\t{H}";
    }
}