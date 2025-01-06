namespace S12345678_HospitalApp;

public abstract class Person
{
    //attributes
    public string Nric { get; set; }
    public string Name { get; set; }

    //constructors
    public Person() {}

    public Person(string nric, string name)
    {
        Nric = nric;
        Name = name;
    }

    //methods
    public override string ToString()
    {
        return $"{Nric, -10} {Name, -14}";
    }
}