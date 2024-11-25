using S12345678_SalesEmployeeApp;
using System;
using System.Collections.Generic;

namespace Week03
{
    class Practical
    {
        static void DisplayEmployeeInfo(Dictionary<int, SalesEmployee> eDict)
        {
            Console.WriteLine($"{"ID", -4} {"Name", -7} {"Basic Salary", -12} {"Sales", -5}");
            foreach (KeyValuePair<int, SalesEmployee> kvp in eDict)
            {
                Console.WriteLine($"{kvp.Key, -4} {kvp.Value.Name, -7} {kvp.Value.BasicSalary, -12} {kvp.Value.Sales, -5}");
            }
        }

        static void Main()
        {
            SalesEmployee employee1 = new SalesEmployee(101, "Angie", 1200, 15000);
            SalesEmployee employee2 = new SalesEmployee(105, "Cindy", 1000, 12000);
            SalesEmployee employee3 = new SalesEmployee(108, "David", 1500, 20000);
            SalesEmployee employee4 = new SalesEmployee(112, "Jason", 3000, 30000);
            SalesEmployee employee5 = new SalesEmployee(127, "Vivian", 2000, 25000);

            Dictionary<int, SalesEmployee> employeeDict = new Dictionary<int, SalesEmployee>
            {
                {employee1.Id, employee1 },
                {employee2.Id, employee2 },
                {employee3.Id, employee3 },
                {employee4.Id, employee4 },
                {employee5.Id, employee5 },
            };

            DisplayEmployeeInfo(employeeDict);
        }
    }
}