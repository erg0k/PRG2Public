namespace Question01
{
    class Program
    {
        static SquarePyramid InitSquarePyramid()
        {
            Console.Write("Enter the length (a) Square Pyramid in metre: ");
            double aInitialiser = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the height (h) of Square Pyramid in metre: ");
            double hInitialiser = Convert.ToDouble(Console.ReadLine());

            return new SquarePyramid(aInitialiser, hInitialiser);
;        }

        static void Main()
        {
            SquarePyramid myPyramid = InitSquarePyramid();
            Console.WriteLine($"Volume of Square Pyramid : {myPyramid.GetVolume():F2} cubic metre.");
            Console.WriteLine($"Surface Area of Square Pyramid : {myPyramid.GetSurfaceArea():F2} square metre.");
        }
    }
}
