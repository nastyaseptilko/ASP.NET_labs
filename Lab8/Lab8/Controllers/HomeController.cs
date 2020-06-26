using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab8.Models;

namespace Lab8.Controllers
{
    public class HomeController : Controller
    {
   
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Persons.OrderBy(p => p.LastName).ToListAsync()); //будем получать объекты из бд
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            db.Persons.Add(person);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Person person = await db.Persons.FirstOrDefaultAsync(p => p.Id == id);
                if (person != null)
                    return View(person);
            }
            return NotFound();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Person person = await db.Persons.FirstOrDefaultAsync(p => p.Id == id);
                if (person != null)
                    return View(person);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Person person)
        {
            db.Persons.Update(person);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Person person = await db.Persons.FirstOrDefaultAsync(p => p.Id == id);
                if (person != null)
                    return View(person);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Person person = new Person { Id = id.Value };
                db.Entry(person).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }

    }
}
