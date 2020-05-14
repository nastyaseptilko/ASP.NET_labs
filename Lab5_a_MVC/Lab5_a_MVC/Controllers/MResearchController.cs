using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_a_MVC.Controllers
{
    [RoutePrefix("V2")]
    public class MResearchController : Controller
    {
        // GET: MResearch
        public ActionResult Index()
        {
            return View();
        }
        // GET: 
        // /MResearch/M01/1
        // /MResearch/M01
        // /MResearch
        // /
        // V2/MResearch/M01
        // V3/MResearch/X/M01
        public ActionResult M01()
        {
            return Content("GET:M01");
        }

        // GET:
        // V2/MResearch/M02
        // V2/MResearch
        // V2
        // V3/MResearch/X/M02
        // MResearch/M02
        public ActionResult M02()
        {
            return Content("GET:M02");
        }

        // GET:
        // V3/MResearch/X/M03
        // V3/MResearch/X/
        // V3
        public ActionResult M03()
        {
            return Content("GET:M03");
        }

        // GET:
        // Others
        public ActionResult MXX()
        {
            return Content("MXX");
        }
    }
}