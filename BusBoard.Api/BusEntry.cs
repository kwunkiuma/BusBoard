using System;

namespace BusBoard.Api
{
    public class BusEntry
    {
        public string lineName { get; set; }
        public string destinationName { get; set; }
        public DateTime expectedArrival { get; set; }
        
        public override string ToString()
        {
            return $"{expectedArrival.ToLocalTime().ToShortTimeString()} - [{lineName}] to {destinationName}";
        }
    }
}