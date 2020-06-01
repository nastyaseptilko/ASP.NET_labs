using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Web;

namespace Lab7_WebAPI.Models
{
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }

    }
}
