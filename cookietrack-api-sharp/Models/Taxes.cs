namespace CookieTrackApiSharp.Models
{
    public class Taxes
    {
        public string status { get; set; }
        public List<TaxTX> data { get; set; }
        public string request { get; set; }
    }
}