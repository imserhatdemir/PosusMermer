using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        AdminManager adm = new AdminManager();
        [Authorize]
        [HttpGet]
        public ActionResult Index(int id)
        {
            Admin author = adm.FindAdmin(id);
            return View(author);
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            adm.UpdateAdmin(p);
            return RedirectToAction("Index");
        }
    }
}