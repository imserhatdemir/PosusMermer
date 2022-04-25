using BusinessLayer.Concrete;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        ProjectManager pm = new ProjectManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult Project(int page = 1)
        {
            var values = pm.GetAll().ToPagedList(page, 9);
            return PartialView(values);
        }
        public ActionResult ProjectID()
        {
            return View();
        }
        public PartialViewResult ProjectDetails(int id)
        {
            var proddetail = pm.GetProjectByID(id);
            return PartialView(proddetail);

        }
    }
}