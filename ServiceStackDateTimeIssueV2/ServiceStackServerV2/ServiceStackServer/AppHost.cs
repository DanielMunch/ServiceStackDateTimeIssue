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
            : base("ServiceStackServer2", typeof(DateTimeService2).Assembly)
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
            Routes.Add<GetDateTime2>("/GetDateTime2", "GET POST");
        }
    }
}