using System;
using ServiceStack;

namespace ServiceStackServer
{
    public class DateTimeService : Service
    {
        public object Any(GetDateTime request)
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

    public class GetDateTime : IReturn<GetDateTimeResponse>
    {
        public DateTime DateTime { get; set; }
    }

    public class GetDateTimeResponse
    {
        public string Value { get; set; }
    }
}