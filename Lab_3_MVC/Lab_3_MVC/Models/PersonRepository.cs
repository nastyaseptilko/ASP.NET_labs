using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;

namespace Lab_3_MVC.Models
{
    public class PersonRepository
    {
        private const string PERSON_JSON_PATH = @"D:\\Учёба\\3 curs\\2 сем\\asp.NET\\GIT\\Lab_3_MVC\\Lab_3_MVC\\Models\\phones.json";
        
        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            
            DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(List<Person>));

            using (var jsonStream = new StreamReader(PERSON_JSON_PATH))
            {
                persons.AddRange((List<Person>)deserializer.ReadObject(jsonStream.BaseStream));
            }
           
            return persons;
        }

        public Person InsertOne(Person person)
        {
            List<Person> persons = GetAll();
            person.Id = persons.Count;
            persons.Add(person);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>));

            using (var jsonStream = new StreamWriter(PERSON_JSON_PATH))
            {
                serializer.WriteObject(jsonStream.BaseStream, persons);
            }
            return person;
        }

        public Person UpdateOne(Person newPerson)
        {
            List<Person> persons = GetAll();
            Person person = persons.Where(p => p.Id == newPerson.Id).First();

            if (newPerson.LastName != null)
            {
                person.LastName = newPerson.LastName;
            }
            if (newPerson.Phone != null)
            {
                person.Phone = newPerson.Phone;
            }

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>));

            using (var jsonStream = new StreamWriter(PERSON_JSON_PATH))
            {
                serializer.WriteObject(jsonStream.BaseStream, persons);
            }

            return person;
        }

        public Person DeleteOne(int personId)
        {
            List<Person> persons = GetAll();
            Person person = persons.Where(p => p.Id == personId).First();
            persons.Remove(person);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>));

            using (var jsonStream = new StreamWriter(PERSON_JSON_PATH))
            {
                serializer.WriteObject(jsonStream.BaseStream, persons);
            }

            return new Person { Id = person.Id, LastName = person.LastName, Phone = person.Phone };
        }
    }
}