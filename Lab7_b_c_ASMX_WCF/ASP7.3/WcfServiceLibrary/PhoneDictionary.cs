using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary
{
    public class PhoneDictionary : DbContext
    {
        public PhoneDictionary()
             : base("DbConnection")
        { }

        public DbSet<Phone> PhoneObjects { get; set; }
    }
}
