using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace DLLJSON
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }


    }
    public interface IPhoneDictionary
    {
        List<Person> GetAll();
        Person InsertOne(Person person);
        Person UpdateOne(Person newPerson);
        Person DeleteOne(int personId);
    }
  
    public class PersonRepository : IPhoneDictionary
    {
        private const string PERSON_JSON_PATH = @"D:\\Учёба\\3 curs\\2 сем\\asp.NET\\Lab6\\Lab6\\phones.json";

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
