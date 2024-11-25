namespace S12345678_EmployeeApp
{
    class Program
    {
        static void InitEmployeeSortedList(SortedList<int, Employee> eSList)
        {
            FullTimeEmployee employee1 = new FullTimeEmployee(103, "John", 1500, 100);
            PartTimeEmployee employee2 = new PartTimeEmployee(101, "Mary", 50, 10);
            PartTimeEmployee employee3 = new PartTimeEmployee(102, "Bob", 55, 20);
            eSList[employee1.Id] = employee1;
            eSList[employee2.Id] = employee2;
            eSList[employee3.Id] = employee3;
        }

        static void DisplayEmployees(SortedList<int, Employee> eSList)
        {
            foreach (Employee employee in eSList.Values)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        static void InitEmployeeList(SortedList<int, Employee> eSList, List<Employee> eList)
        {
            foreach (Employee employee in eSList.Values)
            {
                eList.Add(employee);
            }
        }

        static void DisplaySortedEmployees(List<Employee> eList)
        {
            foreach (Employee employee in eList)
            {
                Console.WriteLine(employee);
            }
        }

        static void Main()
        {
            SortedList<int, Employee> employeeSortedList = new SortedList<int, Employee>();
            InitEmployeeSortedList(employeeSortedList);
            DisplayEmployees(employeeSortedList);

            List<Employee> employeeList = new List<Employee>();
            InitEmployeeList(employeeSortedList, employeeList);

            employeeList.Sort();
            Console.WriteLine();
            DisplaySortedEmployees(employeeList);

            //(b) sorts and displays the employee by id as sortedlist sorts by key
            //(e) sorts and displays the employee by name as the .Sort() function is called
            //on employeeList which uses the IComparable interface to sort by name (as defined)
            //in the Employee Class
        }
    }
}
