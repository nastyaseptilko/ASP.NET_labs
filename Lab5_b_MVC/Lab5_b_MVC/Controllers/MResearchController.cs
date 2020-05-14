using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lab5_b_MVC.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        // GET: MResearch
        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs("get")]
        [Route("{n:int}/{name}")]
        public ActionResult M01B(int n, string name)
        {
            return Content($"Action M01B: n = {n}, name = {name}");
        }

        [AcceptVerbs("post", "get")]
        [Route("{b:bool}/{letters}")]
        public ActionResult M02(bool b, string letters)
        {
            return Content($"Action M02: b = {b}, letters = {letters}, method = {Request.HttpMethod}");
        }

        [AcceptVerbs("delete", "get")]
        [Route("{f:float}/{name:length(2,5)}")]
        public ActionResult M03(float f, string name)
        {
            return Content($"Action M03:f = {f}, name = {name}, method = {Request.HttpMethod}");
        }

        [AcceptVerbs("put", "get")]
        [Route("{letters:length(3,4)}/{n:range(100,200)}")]
        public ActionResult M04( string letters, int n)
        {
            return Content($"Action M04:n = {n}, name = {letters}, method = {Request.HttpMethod}");
        }

        [AcceptVerbs("post")]
        [Route(@"{mail:regex(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)}")]
        public ActionResult M05(string mail)
        {
            return Content($"Action M05: you mail = {mail}, method = {Request.HttpMethod}");
        }
    }
}//^\\S+@\\S+$