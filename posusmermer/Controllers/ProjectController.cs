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
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "/Images/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                b.Image = "/Images/" + dosyaadi + uzanti;
            }
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
        public ActionResult UpdateProject(Project x, HttpPostedFileBase Görsel)
        {
            Context c = new Context();
            var gnc = c.projects.Find(x.ProjectID);

            gnc.ProjectName = x.ProjectName;
            gnc.About1 = x.About1;
            gnc.About2 = x.About2;
            gnc.Map = x.Map;

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

            return RedirectToAction("AdminProject");
        }
    }
}