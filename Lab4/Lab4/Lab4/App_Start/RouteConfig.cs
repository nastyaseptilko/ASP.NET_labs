using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "DictController", action = "Index" }
            );
            routes.MapRoute(
                name: "Dict",
                url: "{controller}/{action}",
                defaults: new { controller = "DictController", action = "Index" }
            );
            routes.MapRoute(
                name: "Error",
                url: "{controller}/{action}",
                defaults: new { controller = "ErrorController", action = "NotFound" }
            );
        }
    }
}
