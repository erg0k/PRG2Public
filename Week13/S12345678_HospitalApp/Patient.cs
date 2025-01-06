namespace S12345678_HospitalApp;

public class Patient : Person
{
    //attributes
    public Room WardedAt { get; set; }

    //constructors
    public Patient() {}

    public Patient(string nric, string name, Room wardedAt) : base(nric, name)
    {
        WardedAt = wardedAt;
    }

    //methods
    public override string ToString()
    {
        return base.ToString() + $" {WardedAt.Location, -8}";
    }
}