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
                Value = string.Format("{0}",
                request.Text)
            };
        }
    }

    public class GetDateTime : IReturn<GetDateTimeResponse>
    {
        public string Text { get; set; }
    }

    public class GetDateTimeResponse
    {
        public string Value { get; set; }
    }
}