using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
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

    }
}