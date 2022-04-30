namespace CookieTrackApiSharp.Models
{
    public class TX
    {
        public string wallet { get; set; }
        public string chain { get; set; }
        public string type { get; set; }
        public string hash { get; set; }
        public bool contract { get; set; }
        public int time { get; set; }
        public string direction { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public Token token { get; set; }
        public double value { get; set; }
        public double fee { get; set; }
        public string nativeToken { get; set; }
    }
}