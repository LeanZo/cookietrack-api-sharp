namespace CookieTrackApiSharp.Models
{
    public class Wallet
    {
        public string status { get; set; }
        public List<Token> data { get; set; }
        public string request { get; set; }
    }
}