using System;

namespace S12345678_FareCalculatorApp
{
    class Program
    {
        static void ReadBusRoute(Dictionary<string, BusStop> bSDict)
        {
            using (StreamReader sr = new StreamReader("bus_174.csv"))
            {
                string? s = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    string[] busInfo = s.Split(',');
                    bSDict[busInfo[1]] = new BusStop(Convert.ToDouble(busInfo[0]), busInfo[1], busInfo[2], busInfo[3]);
                }
            }
        }

        static void DisplayBusRoute(Dictionary<string, BusStop> bSDict)
        {
            Console.WriteLine($"{"Distance {km)", -13} {"Bus Stop Code", -14} {"Road", -19} Bus Stop Code");
            foreach (BusStop bS in bSDict.Values)
            {
                Console.WriteLine($"{bS.Distance, -13} {bS.Code, -14} {bS.Road, -19} {bS.Description}");
            }
        }

        static void ReadDistanceBasedFare(List<Fare> fList)
        {
            using (StreamReader sr = new StreamReader("distance-based-fare.csv"))
            {
                string? s = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                    string[] fareInfo = s.Split(",");
                    fList.Add(new Fare(Convert.ToDouble(fareInfo[0]), Convert.ToInt32(fareInfo[1]))); //fareInfo[1] IS IN CENTS PLEASE CONVERT LATER
                }
            }
        }

        static double GetTravelDistance(Dictionary<string, BusStop> bSDict, string bStop, string aStop)
        {
            //we assume the input stops are always valid (validation not needed)
            //this code ain't good but since validation isn't needed it'll do
            double boardDistance = bSDict[bStop].Distance;
            double alightDistance = bSDict[aStop].Distance;
            double travelDistance = alightDistance - boardDistance;
            return travelDistance;
        }

        static double GetTravelFare(List<Fare> fList, double tDistance) 
        {
            double fareAmount = 0;
            foreach (Fare f in fList)
            {
                if (tDistance <= f.UpToDistance)
                {
                    fareAmount = f.Amount;
                    break;
                }
            }
            return fareAmount / 100;
        }

        static void Main()
        {
            Dictionary<string, BusStop> busStopDictionary = new Dictionary<string, BusStop>();
            List<BusStop> busStopList = new List<BusStop>();
            List<Fare> fareList = new List<Fare>();

            ReadBusRoute(busStopDictionary);
            DisplayBusRoute(busStopDictionary);
            ReadDistanceBasedFare(fareList);

            Console.Write("\nEnter Boarding bus stop: ");
            string boardingStop = Console.ReadLine();

            Console.Write("Enter alighting stop: ");
            string alightingStop = Console.ReadLine();

            double travelDistance = GetTravelDistance(busStopDictionary, boardingStop, alightingStop);
            double fareAmount = GetTravelFare(fareList, travelDistance);

            Console.WriteLine($"Distance travelled: {travelDistance:F1} km");
            Console.WriteLine($"Fare to pay: {fareAmount:C}");
        }
    }
}