using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab7_WebAPI.Models;

namespace Lab7_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private PersonRepository PersonModel { get; set; } = new PersonRepository();

        // GET api/values
        [HttpGet]
        public IEnumerable<Person> GetAllPersons()
        {
            return PersonModel.GetAll();
        }

        // POST api/values
        [HttpPost]
        public Person PostPersons(Person person)
        {
            return PersonModel.InsertOne(person);
        }

        // PUT api/values
        [HttpPut]
        public Person PutPersons(Person person)
        {
            return PersonModel.UpdateOne(person);
        }
    

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void DeletePersons(int id)
        {
            PersonModel.DeleteOne(id);
        }
    }
}
