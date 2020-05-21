using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLEntity
{
    public interface IPhoneDictionary
    {
        DbSet<Phone> PhoneObjects { get; set; }

        int SaveChanges();
    }
    public class Phone : IComparable<Phone>
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Telephone { get; set; }
        public int CompareTo(Phone p)
        {
            return this.FIO.CompareTo(p.FIO);
        }
    }
    public class PhoneDictionary : DbContext,IPhoneDictionary
    {
        public PhoneDictionary()
             : base("DbConnection")
        { }

        public DbSet<Phone> PhoneObjects { get; set; }
    }
}
