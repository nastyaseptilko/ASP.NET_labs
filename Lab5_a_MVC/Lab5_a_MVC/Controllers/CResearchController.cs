using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_a_MVC.Controllers
{
    public class CResearchController : Controller
    {
        // GET: CResearch
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs("post", "get")]
        public ActionResult C01()
        {
            HttpContextBase c = this.HttpContext;
            HttpRequestBase rq = c.Request;
            ViewBag.Request = rq;
            return View();
        }

        [AcceptVerbs("post", "get")]
        public ActionResult C02()
        {
            HttpContextBase c = this.HttpContext;
            HttpResponseBase rs = c.Response;
            ViewBag.Response = rs;
            return View();
        }
    }
}