namespace BusBoard.Api
{
    public class Result
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
    }

    public class PostcodeEntry
    {
        public Result result { get; set; }
    }
}
