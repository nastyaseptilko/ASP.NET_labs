using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4.Controllers
{
    public class DictController : Controller
    {
        private DbContext DatabaseContext { get; set; } = new DbContext();


        public ActionResult Index()
        {
            return View(viewName: "Index", model: DatabaseContext.Persons.ToList());
        }

        public ActionResult Add()
        {
            return View(viewName: "Add", model: new Person());
        }

        public ActionResult AddSave(string lastName, string phone)
        {
            DatabaseContext.Persons.Add(new Person(lastName, phone));
            DatabaseContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id, string lastName, string phone)
        {
            return View(viewName: "Update", model: new Person(id, lastName, phone));
        }

        public ActionResult UpdateSave(int id, string lastName, string phone)
        {
            Person targetPerson = DatabaseContext.Persons.Find(id);
            targetPerson.LastName = lastName;
            targetPerson.Phone = phone;
            DatabaseContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSave(int personId)
        {
            DatabaseContext.Persons.Remove(DatabaseContext.Persons.Find(personId));
            DatabaseContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}