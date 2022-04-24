using BusinessLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
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
            var values = bm.GetAll().ToPagedList(page,3);
            return PartialView(values);
        }
        public PartialViewResult Slider()
        {
            return PartialView();
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
    }
}