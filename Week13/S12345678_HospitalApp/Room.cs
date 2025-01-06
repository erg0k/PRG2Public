namespace S12345678_HospitalApp;

public class Room
{
    //attributes
    public string Location { get; set; }
    public string WardClass { get; set; }

    //constructors
    public Room() {}

    public Room(string location, string wardClass)
    {
        Location = location;
        WardClass = wardClass;
    }

    //methods
    public override string ToString()
    {
        return $"{Location, -8} {WardClass}";
    }
}