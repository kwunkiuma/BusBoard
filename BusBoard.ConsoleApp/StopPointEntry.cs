using System;
using System.Collections.Generic;

namespace BusBoard.ConsoleApp
{
    public class StopPoint
    {
        public string id { get; set; }
        public string commonName { get; set; }
        public int distance { get; set; }
    }

    class StopPointEntry
    {
        public List<StopPoint> stopPoints { get; set; }
    }
}
