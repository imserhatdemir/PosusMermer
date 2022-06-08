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
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "/Images/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                b.Image = "/Images/" + dosyaadi + uzanti;
            }
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
        public ActionResult UpdatePlak(Plates x, HttpPostedFileBase Görsel)
        {
            Context c = new Context();
            var gnc = c.plates.Find(x.PlatesID);

            gnc.PlatesName = x.PlatesName;
            gnc.PlatesAbout = x.PlatesAbout;

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

            return RedirectToAction("AdminPlakaList");
        }
    }
}