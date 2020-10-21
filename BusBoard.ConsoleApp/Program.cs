using System;
using System.Collections.Generic;
using System.Linq;
using static BusBoard.Api.ApiHelper;

namespace BusBoard.ConsoleApp
{ 
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Postcode: ");
                var postcode = Console.ReadLine();
                if (string.IsNullOrEmpty(postcode))
                {
                    break;
                }

                var postcodeEntry = GetPostcodeEntry(postcode);

                var nearestStopPoints = GetNearestStopPoints(postcodeEntry).Take(2);

                foreach (var stopPoint in nearestStopPoints)
                {
                    Console.WriteLine($"{stopPoint.commonName} ({stopPoint.distance}m away):");

                    Console.WriteLine(GetArrivingBuses(stopPoint));
                }
            }
        }
    }
}