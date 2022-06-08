using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class OfferController : Controller
    {
        // GET: Offer
        OfferManager om = new OfferManager();

        [HttpGet]
        public ActionResult Index()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ProductID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Offer b)
        {
           
            om.OfferAdd(b);
            return RedirectToAction("AddNewOffer");
        }
       
        public ActionResult AdminOfferList()
        {
            var values = om.GetAll();
            return View(values);
        }
        public ActionResult DeleteOffer(int id)
        {
            om.DeleteOffer(id);
            return RedirectToAction("Index");
        }
    }
}