using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DLLEntity;
using Newtonsoft.Json;

namespace ASP3MVC.Controllers
{
    public class DictController : Controller
    {
        IPhoneDictionary db = null;
        public DictController(IPhoneDictionary phoneDictionary)
        {
            this.db = phoneDictionary;
        }
        // GET: Dict
        public ActionResult Index()
        {
            IEnumerable<Phone> dictObjects = db.PhoneObjects.OrderBy(i => i.FIO);
            ViewBag.Objects = dictObjects;
            return View();
        }

        // GET: Dict/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Object = db.PhoneObjects.Find(id);
            return View();
        }

        // GET: Dict/Create
        public ActionResult Add()
        {
            return View();
        }

        // POST: Dict/Create
        [HttpPost]
        public ActionResult AddSave(Phone dict)
        {
            try
            {
                // TODO: Add insert logic here
                db.PhoneObjects.Add(dict);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dict/Update/5
        [HttpGet]
        public ActionResult Update(int id)
        {
            ViewBag.Object = db.PhoneObjects.Find(id);
            return View();
        }
        // POST: Dict/UpdateSave/5
        [HttpPost]
        public ActionResult UpdateSave(Phone dict)
        {
            try
            {
                Phone s =db.PhoneObjects.Find(dict.Id);
                s.FIO = dict.FIO;
                s.Telephone = dict.Telephone;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Dict/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.Object = db.PhoneObjects.Find(id);
            return View();
        }

        // POST: Dict/Delete/5
        [HttpPost]
        public ActionResult DeleteSave(Phone dict)
        {
            try
            {
                // TODO: Add delete logic here
                db.PhoneObjects.Remove(db.PhoneObjects.Find(dict.Id));
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            ViewBag.Method = Request.HttpMethod;
            ViewBag.URL2 = Request.Url.ToString().Split(';')[1];
            return View();
        }
        [ChildActionOnly]
        public ActionResult StringDictionary(Phone phone)
        {
            ViewBag.Object = phone;
            return PartialView("StringDictionary");
        }
    }
}
