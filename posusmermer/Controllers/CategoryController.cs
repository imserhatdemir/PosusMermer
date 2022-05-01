using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult CategoryList()
        {
            var values = cm.GetAll();
            return PartialView(values);
        }
        public ActionResult AdminCategoryList()
        {
            var values = cm.GetAll();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            cm.CategoryAdd(c);
            return RedirectToAction("AdminCategoryList");
        }
        public ActionResult DeleteCategory(int id)
        {
            cm.DeleteCategory(id);
            return RedirectToAction("AdminCategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {

            Category ct = cm.FindCategory(id);
            return View(ct);
        }
        [HttpPost]
        public ActionResult UpdateCategory(Category p)
        {
            cm.UpdateCategory(p);
            return RedirectToAction("AdminCategoryList");
        }

    }
}