namespace S12345678_AbstractShapeApp
{
    class Program
    {
        //option 1
        static void ListCircles(List<Circle> cList)
        {
            for (int i = 0; i < cList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {cList[i]}");
            }
        }
        
        //option 2
        static void DisplayCircleArea(List<Circle> cList)
        {
            foreach (Circle circle in cList)
            {
                Console.WriteLine($"Type: {circle.Type, -9} Color: {circle.Color, -8} Radius: {circle.Radius} Area: {circle.FindArea():F2}");
            }
        }

        //option 3
        static void DisplayCirclePerimeter(List<Circle> cList)
        {
            foreach (Circle circle in cList)
            {
                Console.WriteLine($"Type: {circle.Type, -9} {circle.Color, -8} Radius: {circle.Radius} Area: {circle.FindPerimeter():F2}");
            }
        }

        //option 4
        static void ChangeCircleSize(List<Circle> cList)
        {
            ListCircles(cList);
            Console.Write("Enter circle number: ");
            int circleNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter new radius: ");
            double newRadius = Convert.ToDouble(Console.ReadLine());

            cList[circleNumber - 1].Radius = newRadius;
            Console.WriteLine("Radius successfully changed.");
        }

        //option 5
        static void AddCircle(List<Circle> cList)
        {
            Console.Write("Circle color: ");
            string newCircleColor = Console.ReadLine();
            Console.Write("Circle radius: ");
            double  newCircleRadius = Convert.ToDouble(Console.ReadLine());

            cList.Add(new Circle(newCircleColor, newCircleRadius));
            Console.WriteLine($"New {newCircleColor} circle with radius {newCircleRadius}cm added.");
        }

        //option 6
        static void DeleteCircle(List<Circle> cList)
        {
            ListCircles(cList);
            Console.Write("Enter circle number: ");
            int circleNumber = Convert.ToInt32(Console.ReadLine());
            cList.RemoveAt(circleNumber - 1);
            Console.WriteLine("Circle removed.");
        }

        //option 7
        static void DisplayCirclesSortedByArea(List<Circle> cList)
        {
            List<Circle> tempSortList = new List<Circle>(cList);
            tempSortList.Sort();
            DisplayCircleArea(tempSortList);
        }

        static string DisplayMenu()
        {
            Console.WriteLine("---------------- M E N U --------------------");
            Console.WriteLine("[1] List all the circles");
            Console.WriteLine("[2] Display the areas of the circles");
            Console.WriteLine("[3] Display the perimeters of the circles");
            Console.WriteLine("[4] Change the size of a circle");
            Console.WriteLine("[5] Add a new circle");
            Console.WriteLine("[6] Delete a circle");
            Console.WriteLine("[7] Display circles sorted by area");
            Console.WriteLine("[0] Exit");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Enter your option: ");
            return Console.ReadLine();
        }

        static void InitCircleList(List<Circle> cList)
        {
            Circle circle1 = new Circle("Red", 20.0);
            Circle circle2 = new Circle("Green", 10.0);
            Circle circle3 = new Circle("Blue", 30.0);
            cList.Add(circle1);
            cList.Add(circle2);
            cList.Add(circle3);
        }


        static void Main()
        {
            List<Circle> circleList = new List<Circle>();
            InitCircleList(circleList);

            while (true)
            {
                string menuInput = DisplayMenu();

                if (menuInput == "0")
                {
                    break;
                }

                switch (menuInput)
                {
                    case "1":
                        ListCircles(circleList);
                        break;

                    case "2":
                        DisplayCircleArea(circleList);
                        break;

                    case "3":
                        DisplayCirclePerimeter(circleList);
                        break;

                    case "4":
                        ChangeCircleSize(circleList);
                        break;

                    case "5":
                        AddCircle(circleList);
                        break;

                    case "6":
                        DeleteCircle(circleList);
                        break;

                    case "7":
                        DisplayCirclesSortedByArea(circleList);
                        break;
                }
            }
        }
    }
}
