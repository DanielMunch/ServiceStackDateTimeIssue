using System;
using System.Threading;
using ServiceStack;

namespace ServiceStackServer2
{
    public class DateTimeService2 : Service
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public object Any(GetDateTime2 request)
        {
            Thread.Sleep(1000);

            Log.Info("THIS IS MY LOG4NET MESSAGE " + request.DateTime);

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
        public DateTime DateTime { get; set; } //asd
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