namespace CookieTrackApiSharp.Models
{
    public class Token
    {
        public string type { get; set; }
        public string chain { get; set; }
        public string location { get; set; }
        public string owner { get; set; }
        public string symbol { get; set; }
        public string address { get; set; }
        public double balance { get; set; }
        public double price { get; set; }
        public string logo { get; set; }
    }
}