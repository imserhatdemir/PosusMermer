using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class PlakManager
    {
        Repository<Plates> repoplak = new Repository<Plates>();

        public List<Plates> GetAll()
        {
            return repoplak.List();
        }
        public List<Plates> GetPlakByID(int id)
        {
            return repoplak.List().Where(x => x.PlatesID == id).ToList();
        }
    }
}
