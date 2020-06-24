using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class ErrorController : Controller
    {
        public ActionResult NotFound()
        {
            return View(viewName: "NotFound");
        }
    }
}