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
        public int AddPlates(Plates p)
        {

            if (p.PlatesName == "" || p.PlatesAbout == "" )
            {
                return -1;
            }
            return repoplak.Insert(p);
        }
        public Plates FindPlak(int id)
        {
            return repoplak.Find(x => x.PlatesID == id);
        }
        public int DeletePlates(int p)
        {
            Plates blog = repoplak.Find(x => x.PlatesID == p);
            return repoplak.Delete(blog);
        }
        public int UpdatePlak(Plates p)
        {
            Plates blog = repoplak.Find(x => x.PlatesID == p.PlatesID);
            blog.PlatesName = p.PlatesName;
            blog.PlatesAbout = p.PlatesAbout;
            blog.Image = p.Image;
            return repoplak.Update(blog);
        }
    }
}
