using System;
using System.Web;
using System.Web.Routing;
using WebFormRoutingApp.Utils;

namespace WebFormRoutingApp
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //在应用程序启动时运行的代码
            RegisterRoutes(RouteTable.Routes);
            var r1 = RouteTable.Routes;
            int x = 0;
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Add("Named", new Route("foo/bar", new WebFormRouteHandler("~/forms/blech.aspx")));
            routes.Add("Numbers", new Route("one/two/three", new WebFormRouteHandler("~/forms/haha.aspx")));
        }


        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}