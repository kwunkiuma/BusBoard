using System;
using System.Linq;
using System.Web.UI.HtmlControls;

namespace BusBoard.ConsoleApp
{ 
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Stop code: ");
                var stopPoint = Console.ReadLine();
                if (string.IsNullOrEmpty(stopPoint))
                {
                    break;
                }

                var busEntries = ApiHelper
                    .ApiGet<BusEntry>("https://api.tfl.gov.uk/", $"StopPoint/{stopPoint}/Arrivals")
                    .OrderBy(busEntry => busEntry.expectedArrival)
                    .Take(5);

                Console.WriteLine(string.Join("\n", busEntries));
            }
        }
    }
}