using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager pm = new ProductManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult ProductList()
        {
            var productlist = pm.GetAll();
            return PartialView(productlist);
        }
        public PartialViewResult Filter()
        {
            return PartialView();
        }
        public ActionResult ProductDetails()
        {
            return View();
        }
        public PartialViewResult ProductDetails2(int id)
        {
            var proddetail = pm.GetProductByID(id);
            return PartialView(proddetail);

        }
    }
}