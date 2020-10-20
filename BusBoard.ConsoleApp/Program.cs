using System;

namespace BusBoard.ConsoleApp
{ 
    class Program
    {
        static void Main()
        {
            Console.Write("Stop code: ");
            var stopPoint = Console.ReadLine();
            var busEntries = ApiHelper.ApiGet<BusEntry>("https://api.tfl.gov.uk/", $"StopPoint/{stopPoint}/Arrivals");

            busEntries.Sort();
            busEntries = busEntries.GetRange(0, 5);

            foreach (var entry in busEntries)
            {
                Console.WriteLine(entry);
            }

            Console.ReadLine();
        }
    }
}