namespace Question03
{
    class Program
    {
        static void Main()
        {
            List<MobilePlan> phoneList = new List<MobilePlan>()
            {
                new PostPaid("98787654", 15, 2.4),
                new PostPaid("91231234", 25, 4.1),
                new PostPaid("88877765", 20, 3.5)
            };
        }
    }
}
