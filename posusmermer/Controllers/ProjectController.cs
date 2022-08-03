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

        //admin
        [Authorize]
        public ActionResult AdminProject()
        {
            var values = pm.GetAll();
            return View(values);
        }
        [Authorize]
        public ActionResult DeleteProject(int id)
        {
            pm.DeleteProject(id);
            return RedirectToAction("AdminProject");
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddNewProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewProject(Project b)
        {
           
            pm.AddProject(b);
            return RedirectToAction("AdminProject");
        }
        [Authorize]
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            Project d = pm.FindProject(id);
            return View(d);
        }
        [HttpPost]
        public ActionResult UpdateProject(Project x)
        {
            pm.UpdateProject(x);
            return RedirectToAction("AdminProject");
        }
    }
}