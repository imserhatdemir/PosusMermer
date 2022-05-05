using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        AboutManager am = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutList()
        {
            var values = am.GetAll();
            return PartialView(values);
        }
        public PartialViewResult Footer()
        {
            var values = am.GetAll();
            return PartialView(values);
        }
        public PartialViewResult ShowAbout()
        {
            var values = am.GetAll();
            return PartialView(values);
        }
        public ActionResult AdminAbout()
        {
            var values = am.GetAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {

            About about = am.FindAbout(id);
            return View(about);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About p,HttpPostedFileBase Görsel)
        {

            Context c = new Context();
            var blog = c.abouts.Find(p.AboutID);

            blog.Description = p.Description;
            blog.Title = p.Title;
            blog.Map = p.Map;
            blog.Facebook = p.Facebook;
            blog.Twitter = p.Twitter;
            blog.Whatsapp = p.Whatsapp;
            blog.ShortAbout = p.ShortAbout;
            blog.Mail = p.Mail;
            blog.Instagram = p.Instagram;




            if (ModelState.IsValid)

            {



                if (Görsel != null)

                {

                    string dosyaadi = Path.GetFileName(Görsel.FileName);



                    string yol = "/Images/" + dosyaadi;

                    Görsel.SaveAs(Server.MapPath(yol));

                    blog.Image = yol;

                }

            }



            c.SaveChanges();

            return RedirectToAction("AdminAbout");

        }

    }
}