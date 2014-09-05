using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;
using ServiceStack;

namespace ServiceStackDateTimeIssue
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine(GetResponseJson());
            Console.Read();
        }

        private static string GetResponseJson()
        {            
            var request = WebRequest.Create("http://localhost:60577/json/reply/GetDateTime?DateTime=2014-08-27 14:30:23");
            request.Method = HttpMethods.Get;

            JObject response;
            using (var res = request.GetResponse())
                response = JObject.Parse(res.GetResponseString());

            return response["Value"].Value<string>();
        }
    }

    public static class WebResponseExtensions
    {
        public static string GetResponseString(this WebResponse response)
        {
            using (var stream = response.GetResponseStream())
            {
                if (stream == null)
                    return string.Empty;

                using (var reader = new StreamReader(stream))
                    return reader.ReadToEnd();
            }
        }
    }
}
