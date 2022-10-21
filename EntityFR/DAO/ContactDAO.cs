using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFR.DAO
{
    public class ContactDAO : IContact
    {
        private MyContext context = new MyContext();
        public void Delete(int id)
        {
             Contact c = context.Contacts.Find(id);
            if (c != null)
            {
                context.Contacts.Remove(c); 
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Contact introuvable");
            }
        }

        public List<Contact> GetAll()
        {
            return context.Contacts.AsNoTracking().ToList();
        }

        public Contact GetById(int id)
        {
            Contact c = context.Contacts.AsNoTracking().SingleOrDefault(ct => ct.Id == id); 
            if (c != null)
            {
                return c;
            }
            else
            {
                throw new Exception("Contact introuvable");
            }

        }

        public void Insert(Contact c)
        {
            context.Contacts.Add(c);
            context.SaveChanges();
        }

        public void Update(Contact c) //c fournit par le formulaire de saisie : état = Detached (il n'est pas relié au context)
        {
           Contact contactDB = context.Contacts.Find(c.Id); //Unchaged
            if (contactDB != null)
            {
                //Option1: manipuler les états d'un objets 
                /*context.Contacts.Attach(c); //Unchanged
                context.Entry(c).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();*/

                //Option2: manipuler les attributs de l'objet - à choisir si y'à bcp d'attributs à modifier

                contactDB.Name = c.Name; //Etat = Modified
                context.SaveChanges();

                /*
                 * Etats possibles d'un objet dans le context:
                 * Added
                 * Deleted
                 * Modified
                 * Unchanged
                 * Detached
                 */
            }
            else
            {
                throw new Exception("Contact introuvable");
            }
        }

      
    }
}
