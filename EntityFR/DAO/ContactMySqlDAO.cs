﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFR.DAO
{
    public class ContactMySqlDAO : IContact
    {
        private MySqlContext context = new MySqlContext();
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Contact c)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact c)
        {
            throw new NotImplementedException();
        }
    }
}