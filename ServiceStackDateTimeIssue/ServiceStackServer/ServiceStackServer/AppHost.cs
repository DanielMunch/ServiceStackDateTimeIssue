using Funq;
using ServiceStack;
using ServiceStack.Text;

namespace ServiceStackServer
{
    public class AppHost : AppHostBase
    {
        /// <summary>
        /// Default constructor.
        /// Base constructor requires a name and assembly to locate web service classes. 
        /// </summary>
        public AppHost()
            : base("ServiceStackServer", typeof(DateTimeService).Assembly)
        {

        }

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        /// <param name="container"></param>
        public override void Configure(Container container)
        {
            JsConfig.AssumeUtc = true;
            JsConfig.AlwaysUseUtc = true;
            JsConfig.DateHandler = DateHandler.ISO8601;
            Routes.Add<GetDateTime>("/GetDateTime", "GET POST");
        }
    }
}