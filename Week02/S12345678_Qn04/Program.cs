using System;
using System.Collections.Generic;
using System.IO;

namespace Week02
{
    class Question04
    {
        static Dictionary<string, string> busDistanceStop = new Dictionary<string, string>();
        static void DisplayBusRoute()
        {
            using (StreamReader sr = new StreamReader("bus_174.csv"))
            {
                string? s = sr.ReadLine();

                if (s != null)
                {
                    string[] heading = s.Split(",");
                    Console.WriteLine($"{heading[0],-13} {heading[1],-13} {heading[2],-19} {heading[3],-20}");
                }

                while ((s = sr.ReadLine()) != null)
                {
                    string[] busStopInfo = s.Split(",");
                    busDistanceStop.Add(busStopInfo[1], busStopInfo[0]);

                    Console.WriteLine($"{busStopInfo[0],-13} {busStopInfo[1],-13} {busStopInfo[2],-19} {busStopInfo[3],-20}");
                }
            }
        }

        static List<Array> distanceFareList = new List<Array>();
        static void ReadDistanceBasedFare()
        {   

            using (StreamReader sr = new StreamReader("distance-based-fare.csv"))
            {
                sr.ReadLine(); //this removes the header
                string? line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] fareTemp = line.Split(",");

                    distanceFareList.Add(new string[] { fareTemp[0], fareTemp[1] });
                }
            }
        }

        static double CalculateDistanceTravelled(string alightingStop, string boardingStop)
        {
            double distanceTravelled = Convert.ToDouble(busDistanceStop[alightingStop]) - Convert.ToDouble(busDistanceStop[boardingStop]);
            return distanceTravelled;
        }

        static (double farePaid, int travelTime) ProcessData(double distanceTravelled)
        {
            int travelTime = (int)Math.Ceiling(distanceTravelled * 4);
            double farePaid = 0;

            foreach (string[] i in distanceFareList)
            {
                if (distanceTravelled <= Convert.ToDouble(i[0]))
                {
                    farePaid = (Convert.ToDouble(i[1]) / 100);
                    break;
                }
            }


            return (farePaid, travelTime);
        }


        static void Main()
        {
            DisplayBusRoute();

            Console.Write("\nEnter boarding bus stop: ");
            string boardingStop = Console.ReadLine();

            Console.Write("Enter alighting bus stop: ");
            string alightingStop = Console.ReadLine();

            ReadDistanceBasedFare();

            double distanceTravelled = CalculateDistanceTravelled(alightingStop, boardingStop);
            Console.WriteLine($"Distance travelled: {distanceTravelled}km");

            (double farePaid, int travelTime) = ProcessData(distanceTravelled);
            Console.WriteLine($"Fare to pay: {farePaid:C}");
            Console.WriteLine($"Estimated duration: {travelTime}mins");

        }
    }
}