namespace Question02
{
    class Program
    {
        static void CreateDelivery()
        {
            Console.Write("Enter name: ");
            string deliveryName = Console.ReadLine();
            Console.Write("Enter address: ");
            string deliveryAddress = Console.ReadLine();
            Console.Write("Enter distance (to nearest km): ");
            int deliveryDistance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter base fee: ");
            double deliveryBaseFee = Convert.ToDouble(Console.ReadLine());
            InstantDelivery createDelivery = new InstantDelivery(deliveryName, deliveryAddress, deliveryDistance, deliveryBaseFee);
            Console.WriteLine($"The cost is {createDelivery.CalculateCost():C}");
        }

        static void Main()
        {
            //(2a)The StandardDeliver() constructor method is overloaded as it has two definitions (parameterised and default)
            //(2b)CalculateCost() is overloaded as it is redefined in the InstantDelivery subclass which inherits from StandardDelivery
            CreateDelivery();
        }
    }
}
