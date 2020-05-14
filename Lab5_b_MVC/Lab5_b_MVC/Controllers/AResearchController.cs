using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab5_b_MVC.Controllers
{
    
    public class AResearchController : Controller
    {
       
        // GET: AResearch
        public ActionResult Index()
        {
            return View();
        }

        [F3]
        public ActionResult AA()
        {
            return Content($"<p>Action AA</p>");
        }
        public class F3Attribute : FilterAttribute, IActionFilter
        {
            public void OnActionExecuted(ActionExecutedContext filterContext)  //после  
            {
                filterContext.HttpContext.Response.Write("<h2>F3:OnActionExecuted</h2>");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)  // вызывается перед вызовом метода действий
            {
                filterContext.HttpContext.Response.Write("<h2>F3:OnActionExecuting</h2>");
            }
        }

        [F4]
        public ActionResult AR()
        {
            return Content($"<p>Action AR</p>");
        }
        public class F4Attribute : FilterAttribute, IResultFilter
        {
            public void OnResultExecuted(ResultExecutedContext filterContext) // после того, как метод действия возвратил результат
            {
                filterContext.HttpContext.Response.Write("<h2>F4:OnResultExecuted</h2>");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext) //вызывается перед тем, как метод действия начнет возвращать результат действия
            {
                filterContext.HttpContext.Response.Write("<h2>F4:OnResultExecuting</h2>");
            }
        }

        [F5]
        public ActionResult AE()
        {
            throw new Exception("From-E");
            return Content($"<p>Action AE</p>");
        }
        public class F5Attribute : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<h2>F5:OnException</h2>");
                ViewResult viewResult = new ViewResult();
                viewResult.ViewName = "ERROR";
                filterContext.Result = viewResult;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}