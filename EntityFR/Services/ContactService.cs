using EntityFR.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFR.Services
{
    public class ContactService
    {
        //Mise en evidence de la dépendence entre service et dao: typée avec le type parent (polymorphisme)
        private IContact dao;

        //Injection de dépendence via le constructeur
        public ContactService(IContact dao)
        {
            this.dao = dao;
        }

        public List<Contact> GetAll()
        {
            return dao.GetAll();
        }
        public Contact GetById(int id)
        {
            return dao.GetById(id);
        }
        public void Insert(Contact c)
        {
            dao.Insert(c);
        }
        public void Update(Contact c)
        {
            dao.Update(c);
        }
        public void Delete(int id)
        {
            dao.Delete(id);
        }
      
    }
}
