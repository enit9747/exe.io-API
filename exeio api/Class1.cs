using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace exeio_api
{
    public class shortenUrl
    {
        public string Shorten(string apitoken, string destination, string customalias)
        {
            string full;
            WebClient wc = new WebClient();
            if (!String.IsNullOrEmpty(customalias))
            {
                full = "https://exe.io/api?api=" + apitoken + "&url=" + destination + "&alias=" + customalias;
            }
            else
            {
                full = "https://exe.io/api?api=" + apitoken + "&url=" + destination;
            }
            string response = wc.DownloadString(full);
            dynamic parsed = JObject.Parse(response);
            return parsed.shortenedUrl;
        }
    }
}
