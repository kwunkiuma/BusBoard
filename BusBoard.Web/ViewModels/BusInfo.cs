using System.Collections.Generic;
using System.Linq;
using BusBoard.Api;

namespace BusBoard.Web.ViewModels
{
    public class BusInfo
    {
        public string PostCode { get; set; }
        public string ConfirmationMessage { get; }
        public List<StopInfo> StopInfos { get; }

        public BusInfo(string postCode)
        {
            StopInfos = new List<StopInfo>();

            PostCode = postCode;

            if (string.IsNullOrEmpty(postCode))
            {
                ConfirmationMessage = "You didn't enter a postcode!";
                return;
            }

            var postcodeEntry = ApiHelper.GetPostcodeEntry(postCode);

            if (postcodeEntry.result == null)
            {
                ConfirmationMessage = "Postcode is invalid!";
                return;
            }

            var nearestStopPoints = ApiHelper.GetNearestStopPoints(postcodeEntry).Take(2);

            if (!nearestStopPoints.Any())
            {
                ConfirmationMessage = "No stops nearby!";
                return;
            }

            ConfirmationMessage = $"You entered postcode: {postCode}";

            foreach (var stopPoint in nearestStopPoints) StopInfos.Add(new StopInfo(stopPoint));
        }
    }
}