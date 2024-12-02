namespace S12345678_ShapeApp
{
    class Program
    {
        //option 1
        static void ListShapes(List<Shape> sList)
        {
            for (int i = 0; i < sList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {sList[i]}");
            }
        }

        //option 2
        static void DisplayShapeArea(List<Shape> sList)
        {
            foreach (Shape shape in sList)
            {
                Console.WriteLine($"{shape} Area: {shape.FindArea():F2}");
            }
        }

        //option 3
        static void DisplayShapePerimeter(List<Shape> sList)
        {
            foreach (Shape shape in sList)
            {
                Console.WriteLine($"{shape} Perimeter: {shape.FindPerimeter():F2}");
            }
        }

        //option 4
        static void ChangeShapeSize(List<Shape> sList)
        {
            foreach (Shape shape in sList)
            {
                if (shape is Circle circle)
                {
                    circle.Radius += 5;
                }
                else if (shape is Square square)
                {
                    square.Length += 5;
                }
            }

            ListShapes(sList);
        }

        //option 5
        static void AddCircle(List<Shape> sList)
        {
            Console.Write("Circle color: ");
            string newCircleColor = Console.ReadLine();
            Console.Write("Circle radius: ");
            double newCircleRadius = Convert.ToDouble(Console.ReadLine());

            sList.Add(new Circle(newCircleColor, newCircleRadius));
            Console.WriteLine($"New {newCircleColor} circle with radius {newCircleRadius}cm added.");
        }

        //option 6
        static void DeleteCircle(List<Shape> sList)
        {
            for (int i = sList.Count() - 1; i >= 0; i--)
            {
                if (sList[i] is Circle)
                {
                    sList.RemoveAt(i);
                    break;
                }
            }

            ListShapes(sList);
        }

        //option 7
        static void DisplayShapesSortedByArea(List<Shape> sList)
        {
            List<Shape> tempSortList = new List<Shape>(sList);
            tempSortList.Sort();
            DisplayShapeArea(tempSortList);
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

        static void InitShapeList(List<Shape> sList)
        {
            Circle shape1 = new Circle("Red", 20.0);
            Square shape2 = new Square("Red", 10.0);
            Circle shape3 = new Circle("Green", 10.0);
            Square shape4 = new Square("Green", 20.0);
            Circle shape5 = new Circle("Blue", 30.0);
            Square shape6 = new Square("Blue", 30.0);
            sList.Add(shape1);
            sList.Add(shape2);
            sList.Add(shape3);
            sList.Add(shape4);
            sList.Add(shape5);
            sList.Add(shape6);
        }


        static void Main()
        {
            List<Shape> shapeList = new List<Shape>();
            InitShapeList(shapeList);
            Console.WriteLine(shapeList[0]);

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
                        ListShapes(shapeList);
                        break;

                    case "2":
                        DisplayShapeArea(shapeList);
                        break;

                    case "3":
                        DisplayShapePerimeter(shapeList);
                        break;

                    case "4":
                        ChangeShapeSize(shapeList);
                        break;

                    case "5":
                        AddCircle(shapeList);
                        break;

                    case "6":
                        DeleteCircle(shapeList);
                        break;

                    case "7":
                        DisplayShapesSortedByArea(shapeList);
                        break;
                }
            }
        }
    }
}
