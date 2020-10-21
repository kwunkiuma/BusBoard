using System;
using System.Collections.Generic;

namespace BusBoard.Api
{
    public class StopPoint
    {
        public string id { get; set; }
        public string commonName { get; set; }
        public int distance { get; set; }
    }

    public class StopPointEntry
    {
        public List<StopPoint> stopPoints { get; set; }
    }
}
