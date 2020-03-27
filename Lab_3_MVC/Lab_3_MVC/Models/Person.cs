using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Lab_3_MVC.Models
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
        
        /* SortedSet<Data> database = null;
         public DB()
         {
             this.database = new SortedSet<Data>
             (
                 new Data[]
                 {
                     new Data{Id = 1, LastName = "Septilko", Phone = "3212979"},
                     new Data{Id = 2, LastName = "Ivanov", Phone = "8784579"},
                 }, new DataComparer()

             );

         }
         public Data Find(int id);
         public bool Insert(Data data);
         public bool Update(Data data);
         public bool Delete(Data data);
         public Data[] GetAll();


         private class Data
         {
         }

         private class DataComparer : IComparer<Data>
         {
         }*/
    }
}