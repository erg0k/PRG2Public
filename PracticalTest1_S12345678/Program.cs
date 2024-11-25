namespace PhoneApp_S12345678
{
    class Program
    {
        static void DisplayOutput(List<Phone> pList)
        {
            Console.WriteLine($"{"PhoneNum", -9} {"Usage", -7} {"PlanType", -10} {"PhoneCharge($)", 14}");
            foreach (Phone phone in pList)
            {
                Console.WriteLine($"{phone.PhoneNum, -9} {phone.Usage, -7} {phone.PlanType, -10} {phone.CalculateCharge() / 100, 14:F2}");
            }
        }

        static void InitialisePhones(List<Phone> pList)
        {
            using (StreamReader sr = new StreamReader("PhoneDetails.csv"))
            {
                string? s = sr.ReadLine(); //deletes header
                while ((s = sr.ReadLine()) != null)
                {
                    string[] phoneInfo = s.Split(',');
                    pList.Add(new Phone(phoneInfo[0], Convert.ToInt32(phoneInfo[1]), phoneInfo[2]));
                }
            }
        }

        static void UpdateUsage(List<Phone> pList)
        {
            Console.WriteLine("\nUpdate Phone Usage");
            Console.WriteLine("------------------");
            Console.Write("Enter Phone no: ");
            string phoneInput = Console.ReadLine();

            bool phoneFound = false;
            foreach (Phone phone in pList)
            {
                if (phone.PhoneNum == phoneInput)
                {
                    phoneFound = true;
                    Console.WriteLine($"Current usage: {phone.Usage}");

                    Console.Write("Enter new usage: ");
                    int newUsage = Convert.ToInt32(Console.ReadLine());
                    phone.Usage = newUsage;
                    Console.WriteLine("The new usage is updated successfully");

                    break;
                }
            }

            if (!phoneFound)
            {
                Console.WriteLine("Phone not found!");
            } 
        }

        static void Main()
        {
            List<Phone> phoneList = new List<Phone>();
            InitialisePhones(phoneList);
            while (true)
            {
                DisplayOutput(phoneList);
                UpdateUsage(phoneList);
            }
        }
    }
}