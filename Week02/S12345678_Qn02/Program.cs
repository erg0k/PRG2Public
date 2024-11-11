using System;
using System.Collections.Generic;
using System.IO;

namespace Week02
{
    class Question02
    {
        static void Main()
        {
            //A
            List<string> telList = new List<string>();

            while (true)
            {
                Console.Write("Enter name: ");
                string inputName = Console.ReadLine();

                if (inputName == "Exit")
                {
                    break;
                }

                else
                {
                    Console.Write("Enter number: ");
                    string inputNumber = Console.ReadLine();

                    telList.Add($"{inputName},{inputNumber}");
                }
            }

            using (StreamWriter sw = new StreamWriter("PhoneDirectory.csv", true))
            {
                foreach (string info in telList)
                {
                    sw.WriteLine(info);
                }
            }

            Console.WriteLine($"{telList.Count()} records have been appended");

            //B
            Dictionary<string, string> telDictionary = new Dictionary<string, string>();

            using (StreamReader sr = new StreamReader("PhoneDirectory.csv"))
            {
                string? s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] telInfo = s.Split(',');
                    telDictionary[telInfo[0]] = telInfo[1];
                }
            }

            foreach(KeyValuePair<string, string> kvp in telDictionary)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }

            //C
            Dictionary<string, string> telSortedList = new Dictionary<string, string>();

            using (StreamReader sr = new StreamReader("PhoneDirectory.csv"))
            {
                string? s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] telInfo = s.Split(',');
                    telSortedList[telInfo[0]] = telInfo[1];
                }
            }

            foreach (KeyValuePair<string, string> kvp in telSortedList)
            {
                Console.WriteLine($"{kvp.Key}\t{kvp.Value}");
            }
        }
    }
}