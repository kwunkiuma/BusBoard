using System.Collections.Generic;

namespace BusBoard.Api
{
    public class StopInfo
    {
        public string Station { get; }
        public IEnumerable<BusEntry> Arrivals { get; }

        public StopInfo(StopPoint stopPoint)
        {
            Station = stopPoint.commonName;
            Arrivals = ApiHelper.GetArrivalsList(stopPoint);
        }
    }
}