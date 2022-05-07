using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
       
        ContactManager cm = new ContactManager();
     
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public ActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(Contact p)
        {
            cm.BLContactAdd(p);
            return RedirectToAction("SendMessage");
        }
        public ActionResult AdminMessage()
        {
            var values = cm.GetAll();
            return View(values);
        }
        public ActionResult MessageDetails(int id)
        {
            var cd = cm.GetContactByID(id);
            return View(cd);
        }
    }
}