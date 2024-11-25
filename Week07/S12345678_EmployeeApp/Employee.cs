namespace S12345678_EmployeeApp;

public abstract class Employee : IComparable<Employee>
{
    //attributes
    public int Id { get; set; }
    public string Name { get; set; }

    //constructors
    public Employee() {}
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    //methods
    public abstract double CalculatePay();

    public int CompareTo(Employee other)
    {
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}