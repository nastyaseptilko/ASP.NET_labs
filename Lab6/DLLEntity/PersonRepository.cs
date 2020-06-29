using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using AbstractPhoneDataProvider;

namespace DLLEntity
{
    public class PersonRepository : DbContext, IPhoneDictionary
    {
        public DbSet<Person> PersonsContext { get; set; }

        public PersonRepository() : base("DbConnection") {}


        public List<Person> GetAll()
        {
            return PersonsContext.ToList();
        }

        public Person InsertOne(Person person)
        {
            PersonsContext.Add(person);
            SaveChanges();
            return person;
        }

        public Person UpdateOne(Person newPerson)
        {
            Person targetPerson = PersonsContext.First(person => person.Id == newPerson.Id);
            targetPerson.LastName = newPerson.LastName;
            targetPerson.Phone = newPerson.Phone;
            SaveChanges();
            return targetPerson;
        }

        public Person DeleteOne(int personId)
        {
            Person deletedPerson = PersonsContext.First(person => person.Id == personId);
            PersonsContext.Remove(deletedPerson);
            SaveChanges();
            return deletedPerson;
        }
    }
}
