using BusinessLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
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
    }
}