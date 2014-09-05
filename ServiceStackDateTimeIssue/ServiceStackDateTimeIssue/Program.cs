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
            var utcDateStr = GetResponseJson();

            Console.WriteLine(utcDateStr); //"2014-08-27 14:30:23"
            
            var utcDate = DateTime.Parse(utcDateStr);
            
            Console.WriteLine(utcDate); //"2014-08-27 14:30:23" - Kind = Unspecified
            
            Console.WriteLine(utcDate.ToUniversalTime()); //"2014-08-27 12:30:23" - Kind = UTC

            /* Why is this time changed when doing ToUniversalTime()
             * as AssumeUtc = true is set? Should this not make Unspecified Kind
             be handled as Utc?*/
            
            Console.WriteLine(utcDate.ToLocalTime()); //"2014-08-27 16:30:23" - Kind = Local
            
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
