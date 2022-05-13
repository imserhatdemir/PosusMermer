using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager
    {
        Repository<Product> repoproduct = new Repository<Product>();
        public List<Product> GetAll()
        {
            return repoproduct.List();
        }
        public List<Product> GetProductByID(int id)
        {
            return repoproduct.List().Where(x => x.ProductID == id).ToList();
        }
        public int AddProduct(Product p)
        {

            if (p.Title == "" || p.Description == "" || p.Details=="")
            {
                return -1;
            }
            return repoproduct.Insert(p);
        }
        public Product FindProduct(int id)
        {
            return repoproduct.Find(x => x.ProductID == id);
        }
        public int DeleteProduct(int p)
        {
            Product blog = repoproduct.Find(x => x.ProductID == p);
            return repoproduct.Delete(blog);
        }
        public int UpdateBlog(Product p)
        {
            Product blog = repoproduct.Find(x => x.ProductID == p.ProductID);
            blog.Description = p.Description;
            blog.Title = p.Title;
            blog.Details = p.Details;
            blog.CategoryID = p.CategoryID;
            return repoproduct.Update(blog);
        }

        public List<Product> GetProductByCategory(int id)
        {
            return repoproduct.List().Where(x => x.CategoryID == id).ToList();
        }


    }
}
