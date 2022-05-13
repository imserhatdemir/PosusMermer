using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OfferManager
    {
        Repository<Offer> repofer = new Repository<Offer>();

        public List<Offer> GetAll()
        {
            return repofer.List();
        }
        public int OfferAdd(Offer c)
        {
            if (c.Name == "" || c.Mail == "" || c.Location == "" || c.No == "")
            {
                return -1;
            }
            return repofer.Insert(c);
        }
        public int DeleteOffer(int p)
        {
            Offer o = repofer.Find(x => x.OfferID == p);
            return repofer.Delete(o);
        }
    }
}
