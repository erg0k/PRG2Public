namespace S12345678_HospitalApp;

public class Doctor : Person
{
    //attributes
    public string Department { get; set; }
    public Dictionary<string, Patient> PatientDict { get; set; } = new Dictionary<string, Patient>();

    //constructors
    public Doctor() {}

    public Doctor(string nric, string name, string department) : base(nric, name)
    {
        Department = department;
    }

    //methods
    public void AddPatient(Patient patient)
    {
        PatientDict.Add(patient.Nric, patient);
    }

    public void RemovePatient(Patient patient)
    {
        PatientDict.Remove(patient.Nric);
    }

    public override string ToString()
    {
        return base.ToString() + $" {Department, -11}";
    }
}