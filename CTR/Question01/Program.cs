namespace Question01
{
    class Program
    {
        static Line GetLineValues(string message)
        {
            Console.Write($"Enter the values of a,b,c of line {message} equation ax+by=c: ");
            string[] lineValues = Console.ReadLine().Split(",");
            return new Line(Convert.ToInt32(lineValues[0]), Convert.ToInt32(lineValues[1]),
                Convert.ToInt32(lineValues[2]));
        }

        static void Main()
        {
            Line line1 = GetLineValues("1");
            Line line2 = GetLineValues("2");

            Console.WriteLine($"The intersection point (x, y): ({line1.FindIntersectionX(line2)}, {line1.FindIntersectionY(line2)})");
        }
    }
}
