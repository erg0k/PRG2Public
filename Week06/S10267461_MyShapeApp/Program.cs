namespace S12345678_MyShapeApp
{
    class Program
    {
        static void Main()
        {
            Circle circle1 = new Circle(5.0);
            Cylinder cylinder1 = new Cylinder(5.0, 10.0);

            while (true)
            {
                DisplayMenu();
                string menuInput = Console.ReadLine();
                
                if (menuInput == "0")
                {
                    break;
                }

                switch (menuInput)
                {
                    case "1":
                        ChangeCircleRadius(circle1);
                        break;

                    case "2":
                        ChangeCylinderRadius(cylinder1);
                        break;

                    case "3":
                        ChangeCylinderLength(cylinder1);
                        break;

                    case "4":
                        Console.WriteLine($"Area of circle: {circle1.CalculateArea()}");
                        break;

                    case "5":
                        Console.WriteLine($"Surface Area of cylinder: {cylinder1.CalculateArea()}");
                        break;

                    case "6":
                        Console.WriteLine($"Volume of cylinder: {cylinder1.CalculateVolume()}");
                        break;
                }
            }
        }
        static void DisplayMenu()
        {
            Console.WriteLine("---------------- M E N U -----------------");
            Console.WriteLine("[1] Change the radius of circle");
            Console.WriteLine("[2] Change the radius of cylinder");
            Console.WriteLine("[3] Change the length of cylinder");
            Console.WriteLine("[4] Display the area of circle");
            Console.WriteLine("[5] Display the surface area of cylinder");
            Console.WriteLine("[6] Display the volume of cylinder");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter your option: ");
        }
        static void ChangeCircleRadius(Circle circle)
        {
            Console.WriteLine($"Current {circle.ToString().ToLower()}");
            Console.Write("Enter new circle radius: ");
            double newRadius = Convert.ToDouble(Console.ReadLine());
            circle.Radius = newRadius;
        }
        static void ChangeCylinderRadius(Cylinder cylinder)
        {
            Console.WriteLine($"Current radius: {cylinder.Radius}");
            Console.Write("Enter new cylinder radius: ");
            double newRadius = Convert.ToDouble(Console.ReadLine());
            cylinder.Radius = newRadius;
        }

        static void ChangeCylinderLength(Cylinder cylinder)
        {
            Console.WriteLine($"Current length: {cylinder.Length}");
            Console.Write("Enter new cylinder length: ");
            double newLength = Convert.ToDouble(Console.ReadLine());
            cylinder.Length = newLength;
        }
    }
}
