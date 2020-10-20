using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusBoard.ConsoleApp
{
    class JsonItem : IComparable<JsonItem>
    {
        [JsonProperty("expectedArrival")]
        private readonly DateTime expectedArrival;
        [JsonProperty("lineName")]
        private readonly string lineName;
        [JsonProperty("destinationName")]
        private readonly string destinationName;

        public override string ToString()
        {
            return $"{expectedArrival}, {lineName}, {destinationName}";
        }

        public int CompareTo(JsonItem item)
        {
            return this.expectedArrival.CompareTo(item.expectedArrival);
        }
    }

}