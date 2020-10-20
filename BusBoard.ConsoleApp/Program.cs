using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace BusBoard.ConsoleApp
{ 
    class Program
    {
        static void Main()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var client = new RestClient("https://api.tfl.gov.uk/");

            Console.Write("Stop code: ");
            var stopCode = Console.ReadLine();

            var request = new RestRequest($"StopPoint/{stopCode}/Arrivals", DataFormat.Json);
            var response = client.Execute<List<BusEntry>>(request);
            var busEntries = response.Data;

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