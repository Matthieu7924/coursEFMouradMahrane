using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFR.DAO
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public class MyContext : DbContext
    {
        
        public MyContext()
            : base("name=MyContext")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }

   
}