﻿using System;
using System.Data.Entity;
using System.Linq;

namespace EntityFR.DAO
{
    public class MyContext : DbContext
    {
        
        public MyContext()
            : base("name=MyContext")
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }

   
}