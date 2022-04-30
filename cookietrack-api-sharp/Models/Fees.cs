namespace CookieTrackApiSharp.Models
{
    public class Fees
    {
        public string status { get; set; }
        public List<FeesItem> data { get; set; }
        public string request { get; set; }
    }
}