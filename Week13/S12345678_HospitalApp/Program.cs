namespace S12345678_HospitalApp
{
   class Program
    {
        static void InitData(Dictionary<string, Room> roomDict, Dictionary<string, Doctor> doctorDict)
        {
            roomDict["#01-01"] = new Room("#01-01", "C");
            roomDict["#02-02"] = new Room("#02-02", "B");
            roomDict["#03-03"] = new Room("#03-03", "A");
            roomDict["#04-04"] = new Room("#04-04", "A");

            doctorDict["S1234567A"] = new Doctor("S1234567A", "Tom", "Pediatrics");
            doctorDict["S2345678A"] = new Doctor("S2345678A", "Champ", "Oncology");
            doctorDict["S3456789B"] = new Doctor("S3456789B", "Terry", "Cardiology");
        }

        static void DisplayRoomsAndDoctor /*idk what to call this*/(Dictionary<string, Room> roomDict,
            Dictionary<string, Doctor> doctorDict)
        {
            Console.WriteLine($"{"Location", -8} Ward Class");
            foreach (Room room in roomDict.Values)
            {
                Console.WriteLine(room);
            }

            Console.WriteLine($"\n{"NRIC", -10} {"Name", -14} {"Department", -11}");
            foreach (Doctor doctor in doctorDict.Values)
            {
                Console.WriteLine(doctor);
            }
        }

        static void CreatePatients(Dictionary<string, Patient> patientDict, Dictionary<string, Room> roomDict)
        {
            using (StreamReader sr = new StreamReader("Patients.csv"))
            {
                string? s = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    string[] patientInfo = s.Split(",");
                    patientDict[patientInfo[0]] = new Patient(patientInfo[0], patientInfo[1], roomDict[patientInfo[2]]);
                }
            }
        }

        static void DisplayPatients(Dictionary<string, Patient> patientDict)
        {
            Console.WriteLine($"\n{"NRIC", -10} {"Name", -14} {"Location", -8}");
            foreach (Patient patient in patientDict.Values)
            {
                Console.WriteLine(patient);
            }
        }

        static void AssignPatientsToDoctors(Dictionary<string, Patient> patientDict,
            Dictionary<string, Doctor> doctorDict)
        {
            using (StreamReader sr = new StreamReader("PatientsToDoctor.csv"))
            {
                string? s = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    string[] assignInfo = s.Split(",");
                    doctorDict[assignInfo[1]].AddPatient(patientDict[assignInfo[0]]);
                }
            }
        }

        static void DisplayPatientAssignment(Dictionary<string, Doctor> doctorDict)
        {
            Console.WriteLine($"\n{"Doctor", -15} {"Patient", -15}");
            foreach (Doctor doctor in doctorDict.Values)
            {
                foreach (Patient patient in doctor.PatientDict.Values)
                {
                    Console.WriteLine($"{doctor.Name, -15} {patient.Name, -15}");
                }
            }
        }

        static void RemovePatientFromDoctor(Dictionary<string, Doctor> doctorDict)
        {
            Console.Write("Enter patient NRIC: ");
            string userPatientNric = Console.ReadLine();

            bool patientFound = false;
            foreach (Doctor doctor in doctorDict.Values)
            {
                foreach (String nric in doctor.PatientDict.Keys)
                {
                    if (userPatientNric == nric)
                    {
                        doctor.PatientDict.Remove(userPatientNric);
                        patientFound = true;
                        break;
                    }
                }
                if (patientFound) break;
            }

            DisplayPatientAssignment(doctorDict);
        }

        static void AddNewPatient(Dictionary<string, Patient> patientDict, Dictionary<string, Room> roomDict)
        {
            Console.Write("Enter NRIC: ");
            string newNric = Console.ReadLine();

            Console.Write("Enter name: ");
            string newName = Console.ReadLine();

            Console.Write("Enter new room location: ");
            string newLocation = Console.ReadLine();

            patientDict[newNric] = new Patient(newNric, newName, roomDict[newLocation]);
            List<string> patientList = new List<string>();

            foreach (Patient patient in patientDict.Values)
            {
                patientList.Add($"{patient.Nric},{patient.Name}.{patient.WardedAt.Location}");
            }

            using (StreamWriter sw = new StreamWriter("Patients.csv", false))
            {
                foreach (string patient in patientList)
                {
                    sw.WriteLine(patient);
                }
            }
        }

        static void Main()
        {
            Dictionary<string, Room> roomDict = new Dictionary<string, Room>();
            Dictionary<string, Patient> patientDict = new Dictionary<string, Patient>();
            Dictionary<string, Doctor> doctorDict = new Dictionary<string, Doctor>();

            InitData(/*DO NOT TOUCH THIS*/roomDict, doctorDict);
            DisplayRoomsAndDoctor(roomDict, doctorDict);
            CreatePatients(/*DO NOT TOUCH THIS*/patientDict, roomDict);
            DisplayPatients(patientDict);
            AssignPatientsToDoctors(/*DO NOT TOUCH THIS*/patientDict, doctorDict);

            DisplayPatientAssignment(doctorDict);
            RemovePatientFromDoctor(doctorDict);
            AddNewPatient(patientDict, roomDict);
        }
    }
}
