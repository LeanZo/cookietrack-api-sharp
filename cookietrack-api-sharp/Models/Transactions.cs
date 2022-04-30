namespace CookieTrackApiSharp.Models
{
    public class Transactions
    {
        public string status { get; set; }
        public List<TX> data { get; set; }
        public string request { get; set; }
    }
}