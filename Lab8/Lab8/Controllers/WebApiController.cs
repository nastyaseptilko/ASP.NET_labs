using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab8.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab8.Controllers
{
    [Route("api")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        private ApplicationContext db;

        public WebApiController(ApplicationContext context)
        {
            db = context;
        }
        

        // GET api/values
        [HttpGet]
        public List<Person> GetAllPersons()
        {
            return db.Persons.ToList();
        }

        // GET api/values/id
        [HttpGet("{id}")]
        public Person GetIdPersons(int id)
        {
            return db.Persons.ToList().First(p => p.Id == id);
        }

        // POST api/values
        [HttpPost]
        public Person PostPersons(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
            return person;
        }

        // PUT api/values
        [HttpPut]
        public Person PutPersons(Person person)
        {
            db.Persons.Update(person);
            db.SaveChanges();
            return person;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public Person DeletePersons(int id)
        {
            Person person = db.Persons.First(p => p.Id == id);
            db.Persons.Remove(person);
            db.SaveChanges();
            return person;
        }
    }

}

