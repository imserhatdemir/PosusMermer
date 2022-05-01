using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
      
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public int CategoryAdd(Category p)
        {

            if (p.CategoryName==" ")
            {
                return -1;
            }
            return repocategory.Insert(p);
        }
        public Category FindCategory(int id)
        {
            return repocategory.Find(x => x.CategoryID == id);
        }
        public int DeleteCategory(int p)
        {
            Category ctg = repocategory.Find(x => x.CategoryID == p);
            return repocategory.Delete(ctg);
        }
        public int UpdateCategory(Category p)
        {
            Category ct = repocategory.Find(x => x.CategoryID == p.CategoryID);
            ct.CategoryName = p.CategoryName;
         
            return repocategory.Update(ct);
        }

    }
}
