using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using RestSharp;

namespace BusBoard.ConsoleApp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var client = new RestClient("https://api.tfl.gov.uk/");

            Console.Write("Stop code: ");
            var stopCode = Console.ReadLine();

            var request = new RestRequest($"StopPoint/{stopCode}/Arrivals", DataFormat.Json);
            var response = client.Get(request);
            var jsonItems = JsonConvert.DeserializeObject<List<JsonItem>>(response.Content);

            jsonItems.Sort();
            jsonItems = jsonItems.GetRange(0, 5);

            foreach (var item in jsonItems)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}