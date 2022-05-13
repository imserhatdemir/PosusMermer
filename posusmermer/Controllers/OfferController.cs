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
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddNewOffer()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.offers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Product.Title,
                                               Value = x.ProductID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewOffer(Offer b)
        {
           
            om.OfferAdd(b);
            return RedirectToAction("/Product/Index");
        }
    }
}