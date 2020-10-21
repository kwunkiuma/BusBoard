using System.Collections.Generic;
using System.Net;
using RestSharp;

namespace BusBoard.ConsoleApp
{
    class ApiHelper
    {
        public static IEnumerable<T> ApiGet<T>(string baseUrl, string resource)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            return new RestClient(baseUrl)
                .Execute<List<T>>(new RestRequest(resource, DataFormat.Json))
                .Data;
        }
    }
}
