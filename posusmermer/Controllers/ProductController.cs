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
    public class ProductController : Controller
    {
        // GET: Product
        ProductManager pm = new ProductManager();
        CategoryManager cm = new CategoryManager();
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

        //Admin
        [Authorize]
        public ActionResult AdminProductList()
        {
            var productlist = pm.GetAll();
            return View(productlist);
        }
        [Authorize]
        public ActionResult DeleteProduct(int id)
        {
            pm.DeleteProduct(id);
            return RedirectToAction("AdminProductList");
        }
        [Authorize]

        [HttpGet]
        public ActionResult AddNewProduct()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewProduct(Product b)
        {
            pm.AddProduct(b);
            return RedirectToAction("AdminProductList");
        }
        [Authorize]
        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            Product d = pm.FindProduct(id);
            Context c = new Context();
            List<SelectListItem> values = (from x in c.categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.values = values;
            return View(d);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product x)
        {
            pm.UpdateBlog(x);
            return RedirectToAction("AdminProductList");
        }


        public ActionResult Ctgbystock(int id)
        {
            var stocklistbycategory = pm.GetProductByCategory(id);
            return View(stocklistbycategory);
        }


    }


}