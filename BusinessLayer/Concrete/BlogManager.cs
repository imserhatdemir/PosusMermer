using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();
        public List<Blog> GetAll()
        {
            return repoblog.List();
        }
        public List<Blog> GetBlogByID(int id)
        {
            return repoblog.List().Where(x => x.BlogID == id).ToList();
        }

        public int BlogAddBL(Blog p)
        {

            if (p.Title == ""  || p.Description == "" ||  p.Description.Length <= 100)
            {
                return -1;
            }
            return repoblog.Insert(p);
        }
        public Blog FindBlog(int id)
        {
            return repoblog.Find(x => x.BlogID == id);
        }
        public int DeleteBlogBL(int p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p);
            return repoblog.Delete(blog);
        }
        public int UpdateBlog(Blog p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p.BlogID);
            blog.Description = p.Description;
            blog.Title = p.Title;
            blog.Image = p.Image;
            return repoblog.Update(blog);
        }

    }
}
