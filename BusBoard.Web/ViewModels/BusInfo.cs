using System.Collections.Generic;
using System.Linq;
using BusBoard.Api;

namespace BusBoard.Web.ViewModels
{
    public class BusInfo
    {
        public string ConfirmationMessage { get; set; }
        public List<StopInfo> StopInfos { get; }

        public BusInfo(string postcode)
        {
            StopInfos = new List<StopInfo>();

            PopulateStopInfos(postcode);
        }

        private void PopulateStopInfos(string postcode)
        {
            if (string.IsNullOrEmpty(postcode))
            {
                ConfirmationMessage = "You didn't enter a postcode!";
                return;
            }

            var postcodeEntry = ApiHelper.GetPostcodeEntry(postcode);

            if (postcodeEntry.result == null)
            {
                ConfirmationMessage = "Postcode is invalid!";
                return;
            }

            var nearestStopPoints = ApiHelper.GetNearestStopPoints(postcodeEntry).Take(2).ToList();

            if (!nearestStopPoints.Any())
            {
                ConfirmationMessage = "No stops nearby!";
                return;
            }

            ConfirmationMessage = $"You entered postcode: {postcode}";

            foreach (var stopPoint in nearestStopPoints)
            {
                StopInfos.Add(new StopInfo(stopPoint));
            }
        }
    }
}