using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager
    {
        Repository<Admin> repoadmin = new Repository<Admin>();
        public List<Admin> GetAll()
        {
            return repoadmin.List();
        }
        public Admin FindAdmin(int id)
        {
            return repoadmin.Find(x => x.AdminID == id);
        }
        public int UpdateAdmin(Admin p)
        {
            Admin blog = repoadmin.Find(x => x.AdminID == p.AdminID);
            blog.UserName = p.UserName;
            blog.Password = p.Password;
            return repoadmin.Update(blog);
        }
    }
}
