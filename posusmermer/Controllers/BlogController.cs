using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        BlogManager bm = new BlogManager();
      
        public ActionResult Index()
        {
            
            return View();
        }
        public PartialViewResult BlogList(int page=1)
        {
            var values = bm.GetAll().ToPagedList(page,6);
            return PartialView(values);
        }
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {
            return View();
        }
        public PartialViewResult BlogDetails2(int id)
        {
            var blogdetail = bm.GetBlogByID(id);
            return PartialView(blogdetail);
        }
        public PartialViewResult BlogPopular(int page = 1)
        {
            var values = bm.GetAll().ToPagedList(page, 3);
            return PartialView(values);
        }

        // GET: Admin
        public ActionResult AdminIndex()
        {
            return View();
        }

        public PartialViewResult AdminBlogList()
        {
            var values = bm.GetAll();
            return PartialView(values);
        }
        [HttpGet]
       public ActionResult AddNewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBlog(Blog b)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "/Images/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                b.Image = "/Images/" + dosyaadi + uzanti;
            }
            bm.BlogAddBL(b);
            return RedirectToAction("AdminIndex");
        }
        public ActionResult DeleteBlog(int id)
        {
            bm.DeleteBlogBL(id);
            return RedirectToAction("AdminIndex");
        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {

            Blog blog = bm.FindBlog(id);
            return View(blog);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog x, HttpPostedFileBase Görsel)
        {
            Context c = new Context();
            var gnc = c.blogs.Find(x.BlogID);

            gnc.Title = x.Title;



            gnc.Description = x.Description;




            if (ModelState.IsValid)

            {



                if (Görsel != null)

                {

                    string dosyaadi = Path.GetFileName(Görsel.FileName);



                    string yol = "/Images/" + dosyaadi;

                    Görsel.SaveAs(Server.MapPath(yol));

                    gnc.Image = yol;

                }

            }



            c.SaveChanges();

            return RedirectToAction("AdminIndex");

        }

    }
}