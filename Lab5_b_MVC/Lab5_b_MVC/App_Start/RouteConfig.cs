using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab5_b_MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute("M01B_1", "it/n/name", new { controller = "MResearch", action = "M01B" });
            routes.MapRoute("M02_1", "it/b/letters", new { controller = "MResearch", action = "M02" });
            routes.MapRoute("M03_1", "it/f/name", new { controller = "MResearch", action = "M03" });
            routes.MapRoute("M04_1", "it/letters/n", new { controller = "MResearch", action = "M04" });
            routes.MapRoute("M05_1", "it/mail", new { controller = "MResearch", action = "M05" });
            routes.MapRoute("F3_1", "f3", new { controller = "AResearch", action = "AA" });
            routes.MapRoute("F4_1", "f4", new { controller = "AResearch", action = "AR" });
            routes.MapRoute("F5_1", "f5", new { controller = "AResearch", action = "AE" });
            routes.MapRoute("CH1_1", "FLT/G", new { controller = "CHResearch", action = "AD" });
            routes.MapRoute("CH2_1", "x/y", new { controller = "CHResearch", action = "AP" });


            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}",
               defaults: new { controller = "MResearch", action = "M01B" });
        }
    }
}
