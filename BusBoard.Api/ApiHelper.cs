using System.Collections.Generic;
using System.Linq;
using System.Net;
using RestSharp;

namespace BusBoard.Api
{
    public class ApiHelper
    {
        public static IEnumerable<T> ApiGet<T>(string baseUrl, string resource)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            return new RestClient(baseUrl)
                .Execute<List<T>>(new RestRequest(resource, DataFormat.Json))
                .Data;
        }

        public static PostcodeEntry GetPostcodeEntry(string postcode)
        {
            return ApiGet<PostcodeEntry>("https://api.postcodes.io/", $"postcodes/{postcode}").First();
        }

        public static IEnumerable<StopPoint> GetNearestStopPoints(PostcodeEntry postcodeEntry)
        {
            var resource = $@"StopPoint
                ?stopTypes=NaptanPublicBusCoachTram
                &radius=400
                &useStopPointHierarchy=false
                &modes=bus&categories=none
                &returnLines=false
                &lat={postcodeEntry.result.latitude}
                &lon={postcodeEntry.result.longitude}";

            return ApiGet<StopPointEntry>("https://api.tfl.gov.uk/", resource)
                .First()
                .stopPoints;
        }

        public static string GetArrivalsString(StopPoint stopPoint)
        {
            return string.Join("\n", GetArrivalsList(stopPoint));
        }

        public static IEnumerable<BusEntry> GetArrivalsList(StopPoint stopPoint)
        {
            return ApiGet<BusEntry>("https://api.tfl.gov.uk/", $"StopPoint/{stopPoint.id}/Arrivals")
                .OrderBy(busEntry => busEntry.expectedArrival)
                .Take(5);
        }
    }
}
