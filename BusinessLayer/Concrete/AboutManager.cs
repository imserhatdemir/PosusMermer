using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager
    {
        Repository<About> repoabout = new Repository<About>();

       public List<About> GetAll()
        {
            return repoabout.List();
        }
        public About FindAbout(int id)
        {
            return repoabout.Find(x => x.AboutID == id);
        }
        public int UpdateAbout(About p)
        {
            About blog = repoabout.Find(x => x.AboutID == p.AboutID);
            blog.Description = p.Description;
            blog.Title = p.Title;
            blog.Map = p.Map;
            blog.Image = p.Image;
            blog.Facebook = p.Facebook;
            blog.Twitter = p.Twitter;
            blog.Whatsapp = p.Whatsapp;
            blog.ShortAbout = p.ShortAbout;
            blog.Mail = p.Mail;
            blog.Instagram = p.Instagram;
            return repoabout.Update(blog);
        }
    }
}
