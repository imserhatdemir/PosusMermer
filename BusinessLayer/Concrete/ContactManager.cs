using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public int BLContactAdd(Contact c)
        {
            if (c.ContactMail == "" || c.Message == "" || c.ContactName == "" || c.Title == "" )
            {
                return -1;
            }
            return repocontact.Insert(c);
        }
        public List<Contact> GetAll()
        {
            return repocontact.List();
        }
        public List<Contact> GetContactByID(int id)
        {
            return repocontact.List().Where(x => x.ContactID == id).ToList();
        }
        public int DeleteContact(int p)
        {
            Contact c = repocontact.Find(x => x.ContactID == p);
            return repocontact.Delete(c);
        }
    }
}
