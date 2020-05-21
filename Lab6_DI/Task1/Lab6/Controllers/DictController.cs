using DLLJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3_MVC.Controllers
{
    public class DictController : Controller
    {
        private PersonRepository PersonModel { get; set; } = new PersonRepository();


        public ActionResult Index()
        {
            return View(viewName: "Index", model: PersonModel);
        }

        public ActionResult Add()
        {
            return View(viewName: "Add", model: new Person());
        }

        [HttpPost]
        public ActionResult AddSave(string lastName, string phone)
        {
            return View(viewName: "Add", model: PersonModel.InsertOne(new Person { LastName = lastName, Phone = phone }));
        }

        public ActionResult Update(int id, string lastName, string phone)
        {
            return View(viewName: "Update", model: new Person { Id = id, LastName = lastName, Phone = phone });
        }

        public ActionResult UpdateSave(int id, string lastName, string phone)
        {
            return View(viewName: "Update", model: PersonModel.UpdateOne(new Person { Id = id, LastName = lastName, Phone = phone }));
        }
        public ActionResult Delete()
        {
            return View(viewName: "Index", model: PersonModel);
        }
        public ActionResult DeleteSave(int personId)
        {
            PersonModel.DeleteOne(personId);
            return View(viewName: "Index", model: PersonModel);
        }
    }
}