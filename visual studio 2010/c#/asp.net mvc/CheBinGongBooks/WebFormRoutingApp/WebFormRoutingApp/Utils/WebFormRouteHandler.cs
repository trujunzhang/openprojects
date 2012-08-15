using System.Web;
using System.Web.Compilation;
using System.Web.Routing;
using System.Web.UI;

namespace WebFormRoutingApp.Utils
{
    public class WebFormRouteHandler : IRouteHandler
    {
        public WebFormRouteHandler(string virtualPath)
        {
            this.VirtualPath = virtualPath;
        }

        public string VirtualPath { get; private set; }

        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            var page = BuildManager.CreateInstanceFromVirtualPath(VirtualPath, typeof(Page)) as IHttpHandler;
            return page;
        }

    }
}

