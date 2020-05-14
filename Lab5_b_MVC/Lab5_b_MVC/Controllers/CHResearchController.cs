using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_b_MVC.Controllers
{
    public class CHResearchController : Controller
    {
        // GET: CHResearch
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs("get")]
        [OutputCache(Duration =5)]
        public ActionResult AD()
        {
            long time = DateTime.Now.Second;
            return Content($"<h2>FLT/G: {time} </h2>");
        }

        [AcceptVerbs("post")]
        [OutputCache(Duration = 7)]
        [Route("{x:int}/{y:int}")]
        public ActionResult AP(int x, int y)
        {
            long time = DateTime.Now.Second;
            return Content($"<h2>Params: {x} and {y}; Time seconds: {time}</h2>");
        }
    }
}