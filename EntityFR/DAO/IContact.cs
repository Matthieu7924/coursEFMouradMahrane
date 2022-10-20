using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFR.DAO
{
    public interface IContact
    {
        List<Contact> GetAll();
        Contact GetById(int id);
        void Insert(Contact c);
        void Update(Contact c);
        void Delete(int id);
    }
}
