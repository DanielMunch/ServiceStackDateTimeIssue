using System;
using ServiceStack;

namespace ServiceStackServer
{
    public class DateTimeService2 : Service
    {
        public object Any(GetDateTime2 request)
        {
            return new GetDateTimeResponse
            {
                Value = string.Format("{0}-{1}-{2} {3}:{4}:{5} {6}",
                request.DateTime.Year,
                request.DateTime.Month,
                request.DateTime.Day,
                request.DateTime.Hour,
                request.DateTime.Minute,
                request.DateTime.Second,
                request.DateTime.Kind)
            };
        }        
    }

    public class GetDateTime2 : IReturn<GetDateTimeResponse>
    {
        public DateTime DateTime { get; set; }
    }

    public class GetDateTimeResponse
    {
        public string Value { get; set; }
    }

    public class TestMe
    {
        public DateTime GetCurrentDateTimeAsUtc()
        {
            return DateTime.UtcNow;
        }
    }
}