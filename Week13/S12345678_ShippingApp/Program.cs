namespace S12345678_ShippingApp
{
    class Program
    {
        static void InitCustomerList(List<Customer> cList)
        {
            cList.Add(new Customer("John Tan", "98501111", new ShippingAddr("Singapore", "Clementi Rd")));
            cList.Add(new Customer("Amy Lim", "99991111", new ShippingAddr("Hong Kong", "Mong Kok Rd")));
            cList.Add(new Customer("Tony Tay", "91112222", new ShippingAddr("Malaysia", "Malacca Rd")));
        }

        static void ListCustomers(List<Customer> cList)
        {
            Console.WriteLine($"{"Name", -10} {"Tel", -10} {"Country", -12} Street");
            foreach (Customer customer in cList)
            {
                Console.WriteLine(customer);
            }
        }

        static void Main()
        {
            List<Customer> customerList = new List<Customer>();
            InitCustomerList(customerList);
            ListCustomers(customerList);
        }
    }
}
