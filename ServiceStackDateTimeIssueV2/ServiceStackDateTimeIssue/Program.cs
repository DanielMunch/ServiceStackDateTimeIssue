namespace ServiceStackDateTimeIssue
{
    internal static class Program
    {
        private static void Main()
        {
            //        const string dateTimeUrlWithTime = "http://localhost:60577/json/reply/GetDateTime?DateTime=2014-08-27 14:30:23";
            //        const string dateTimeUrl = "http://localhost:60577/json/reply/GetDateTime?DateTime=2014-08-27";

            //        /**************************************/

            //        //With time specified
            //        Console.WriteLine(dateTimeUrlWithTime);
            //        var dateStr = GetResponseJson(dateTimeUrlWithTime);
            //        Console.WriteLine(dateStr); //Kind = Utc as expected

            //        //Without time specified
            //        Console.WriteLine(dateTimeUrl);
            //        var dateStr2 = GetResponseJson(dateTimeUrl);
            //        Console.WriteLine(dateStr2); //Kind = Local - This is unexpected

            //        /**************************************/

            //        Console.Read();
            //    }

            //    private static string GetResponseJson(string url)
            //    {
            //        var request = WebRequest.Create(url);
            //        request.Method = HttpMethods.Get;

            //        JObject response;
            //        using (var res = request.GetResponse())
            //            response = JObject.Parse(res.GetResponseString());

            //        return response["Value"].Value<string>();
            //    }
            //}

            //public static class WebResponseExtensions
            //{
            //    public static string GetResponseString(this WebResponse response)
            //    {
            //        using (var stream = response.GetResponseStream())
            //        {
            //            if (stream == null)
            //                return string.Empty;

            //            using (var reader = new StreamReader(stream))
            //                return reader.ReadToEnd();
            //        }
        }
    }
}