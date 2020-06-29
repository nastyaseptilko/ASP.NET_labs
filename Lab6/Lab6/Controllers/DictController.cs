using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AbstractPhoneDataProvider;

namespace Lab6.Controllers
{
    public class DictController : Controller
    {
        //private PersonRepository PersonModel { get; set; } = new PersonRepository();
        private IPhoneDictionary PersonModel { get; set; }

        public DictController(IPhoneDictionary phoneDictionary)
        {
            this.PersonModel = phoneDictionary;
        }

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
            //return View(viewName: "Add", model: PersonModel.InsertOne(new Person { LastName = lastName, Phone = phone }));
            PersonModel.InsertOne(new Person { LastName = lastName, Phone = phone });
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id, string lastName, string phone)
        {
            return View(viewName: "Update", model: new Person { Id = id, LastName = lastName, Phone = phone });
        }

        public ActionResult UpdateSave(int id, string lastName, string phone)
        {
            PersonModel.UpdateOne(new Person { Id = id, LastName = lastName, Phone = phone });
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(viewName: "Delete", model: new { personId = id });
        }

        public ActionResult DeleteSave(int personId)
        {
            PersonModel.DeleteOne(personId);
            return RedirectToAction("Index");
        }
    }
}