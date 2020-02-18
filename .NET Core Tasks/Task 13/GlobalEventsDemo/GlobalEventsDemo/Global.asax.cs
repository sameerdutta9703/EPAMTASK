using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace GlobalEventsDemo
{
    public class Global : HttpApplication
    {

        void Application_Init(object sender, EventArgs e)
        {
        }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        void Application_EndRequest(Object sender, EventArgs e)
        {
        }

        void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
        }

        void Application_Error(object sender, EventArgs e)
        {
        }

        void Application_End(object sender, EventArgs e)
        {
        }

        void Session_Start(object sender, EventArgs e)
        {
        }

        void Session_End(object sender, EventArgs e)
        {
        }
    }
}