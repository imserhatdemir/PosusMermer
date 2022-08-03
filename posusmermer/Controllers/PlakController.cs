using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class PlakController : Controller
    {
        // GET: Plak
        PlakManager pm = new PlakManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PlakaList(int page=1)
        {
            var values = pm.GetAll().ToPagedList(page, 9);
            return PartialView(values);
        }
        public ActionResult PlakDetail()
        {
            return View();
        }
        public PartialViewResult PlakDetails(int id)
        {
            var plakdetail = pm.GetPlakByID(id);
            return PartialView(plakdetail);
        }

        //admin
        [Authorize]
        public ActionResult AdminPlakaList()
        {
            var values = pm.GetAll();
            return View(values);
        }

        public ActionResult DeletePlak(int id)
        {
            pm.DeletePlates(id);
            return RedirectToAction("AdminPlakaList");
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddNewPlak()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddNewPlak(Plates b)
        {
            
            pm.AddPlates(b);
            return RedirectToAction("AdminPlakaList");
        }
        [Authorize]
        [HttpGet]
        public ActionResult UpdatePlak(int id)
        {
            Plates d = pm.FindPlak(id);
            return View(d);
        }
        [HttpPost]
        public ActionResult UpdatePlak(Plates x)
        {
            pm.UpdatePlak(x);

            return RedirectToAction("AdminPlakaList");
        }
    }
}