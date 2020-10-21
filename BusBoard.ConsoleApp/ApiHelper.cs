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
            var client = new RestClient(baseUrl);
            var response = client.Execute<List<T>>(new RestRequest(resource, DataFormat.Json));
            return response.Data;
        }
    }
}
