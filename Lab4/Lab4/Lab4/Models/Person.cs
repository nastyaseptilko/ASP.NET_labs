using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public Person() { }

        public Person(int id, string lastName, string phone)
        {
            Id = id;
            LastName = lastName;
            Phone = phone;
        }

        public Person(string lastName, string phone)
        {
            LastName = lastName;
            Phone = phone;
        }
    }
}