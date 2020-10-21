using System;
using System.Collections.Generic;
using System.Linq;

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

                var postcodeEntry = ApiHelper.GetPostcodeEntry(postcode);

                var nearestStopPoints = ApiHelper.GetNearestStopPoints(postcodeEntry).Take(2);

                foreach (var stopPoint in nearestStopPoints)
                {
                    Console.WriteLine($"{stopPoint.commonName} ({stopPoint.distance}m away):");

                    Console.WriteLine(ApiHelper.GetArrivingBusses(stopPoint));
                }
            }
        }
    }
}