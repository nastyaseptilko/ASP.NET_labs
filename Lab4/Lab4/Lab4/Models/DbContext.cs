using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Lab4.Models
{
    public class DbContext : System.Data.Entity.DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public DbContext() : base("DefaultConnection") {}
    }
}