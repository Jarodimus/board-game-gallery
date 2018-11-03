using System.Web.Mvc;
using System.Web.Routing;

namespace BoardGameGallery
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //files with extension .axd are ignored by the routing engine
            // requests for axd files are handled by ASP.net and shouldn't be routed to any of the websites controllers
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "BoardGame", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
