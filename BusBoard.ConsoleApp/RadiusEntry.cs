using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
    class RadiusEntry
    {
        public class PassengerFlow
        {
            public string timeSlice { get; set; }
            public int value { get; set; }
        }

        public class TrainLoading
        {
            public string line { get; set; }
            public string lineDirection { get; set; }
            public string platformDirection { get; set; }
            public string direction { get; set; }
            public string naptanTo { get; set; }
            public string timeSlice { get; set; }
            public int value { get; set; }
        }

        public class Crowding
        {
            public List<PassengerFlow> passengerFlows { get; set; }
            public List<TrainLoading> trainLoadings { get; set; }
        }

        public class Line
        {
            public string id { get; set; }
            public string name { get; set; }
            public string uri { get; set; }
            public string fullName { get; set; }
            public string type { get; set; }
            public Crowding crowding { get; set; }
            public string routeType { get; set; }
            public string status { get; set; }
        }

        public class LineGroup
        {
            public string naptanIdReference { get; set; }
            public string stationAtcoCode { get; set; }
            public List<string> lineIdentifier { get; set; }
        }

        public class LineModeGroup
        {
            public string modeName { get; set; }
            public List<string> lineIdentifier { get; set; }
        }

        public class AdditionalProperty
        {
            public string category { get; set; }
            public string key { get; set; }
            public string sourceSystemKey { get; set; }
            public string value { get; set; }
            public DateTime modified { get; set; }
        }

        public class AdditionalProperty2
        {
            public string category { get; set; }
            public string key { get; set; }
            public string sourceSystemKey { get; set; }
            public string value { get; set; }
            public DateTime modified { get; set; }
        }

        public class Child2
        {
        }

        public class Child
        {
            public string id { get; set; }
            public string url { get; set; }
            public string commonName { get; set; }
            public int distance { get; set; }
            public string placeType { get; set; }
            public List<AdditionalProperty2> additionalProperties { get; set; }
            public List<Child2> children { get; set; }
            public List<string> childrenUrls { get; set; }
            public int lat { get; set; }
            public int lon { get; set; }
        }

        public class StopPoint
        {
            public string naptanId { get; set; }
            public string platformName { get; set; }
            public string indicator { get; set; }
            public string stopLetter { get; set; }
            public List<string> modes { get; set; }
            public string icsCode { get; set; }
            public string smsCode { get; set; }
            public string stopType { get; set; }
            public string stationNaptan { get; set; }
            public string accessibilitySummary { get; set; }
            public string hubNaptanCode { get; set; }
            public List<Line> lines { get; set; }
            public List<LineGroup> lineGroup { get; set; }
            public List<LineModeGroup> lineModeGroups { get; set; }
            public string fullName { get; set; }
            public string naptanMode { get; set; }
            public bool status { get; set; }
            public string id { get; set; }
            public string url { get; set; }
            public string commonName { get; set; }
            public int distance { get; set; }
            public string placeType { get; set; }
            public List<AdditionalProperty> additionalProperties { get; set; }
            public List<Child> children { get; set; }
            public List<string> childrenUrls { get; set; }
            public int lat { get; set; }
            public int lon { get; set; }
        }

        public List<int> centrePoint { get; set; }
        public List<StopPoint> stopPoints { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
        public int page { get; set; }

    }
}
