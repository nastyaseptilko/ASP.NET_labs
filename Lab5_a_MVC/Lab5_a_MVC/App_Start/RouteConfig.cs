using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab5_a_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "M02",
                url: "V2/{controller}/{action}",
                defaults: new { controller = "MResearch", action = "M02" }
            );

            routes.MapRoute(
                name: "M03",
                url: "V3/{controller}/{X}/{action}",
                defaults: new { controller = "MResearch", action = "M03", X = UrlParameter.Optional },
                constraints: new { X = "^X$|^$" }
            );

            routes.MapRoute(
                name: "C01",
                url: "CResearch/{action}",
                defaults: new { controller = "CResearch", action = "C01" }
            );

            routes.MapRoute(
                name: "M01",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional }
            );

            //routes.MapRoute("M01_1", "MResearch/M01/1", new { controller = "MResearch", action = "M01" });
            //routes.MapRoute("M01_2", "MResearch/M01", new { controller = "MResearch", action = "M01" });
            //routes.MapRoute("M01_3", "MResearch", new { controller = "MResearch", action = "M01" });
            //routes.MapRoute("M01_4", "V2/MResearch/M01", new { controller = "MResearch", action = "M01" });
            //routes.MapRoute("M01_5", "V3/MResearch/X/M01", new { controller = "MResearch", action = "M01" });

            //routes.MapRoute("M02_1", "V2/MResearch/M02", new { controller = "MResearch", action = "M02" });
            //routes.MapRoute("M02_2", "V2/MResearch", new { controller = "MResearch", action = "M02" });
            //routes.MapRoute("M02_3", "V2", new { controller = "MResearch", action = "M02" });
            //routes.MapRoute("M02_4", "V3/MResearch/X/M02", new { controller = "MResearch", action = "M02" });
            //routes.MapRoute("M02_5", "MResearch/M02", new { controller = "MResearch", action = "M02" });

            //routes.MapRoute("M03_1", "V3/MResearch/X/M03", new { controller = "MResearch", action = "M03" });
            //routes.MapRoute("M03_2", "V3/MResearch/X/", new { controller = "MResearch", action = "M03" });
            //routes.MapRoute("M03_3", "V3", new { controller = "MResearch", action = "M03" });

            //routes.MapRoute("C01_1", "CResearch", new { controller = "CResearch", action = "C01" });
            //routes.MapRoute("C01_2", "CResearch/C01", new { controller = "CResearch", action = "C01" });
            //routes.MapRoute("C02_1", "CResearch/C02", new { controller = "CResearch", action = "C02" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}",
            //    defaults: new { controller = "MResearch", action = "M01" });
        }
    }
}
