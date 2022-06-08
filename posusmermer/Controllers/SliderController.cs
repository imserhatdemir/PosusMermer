using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace posusmermer.Controllers
{
    public class SliderController : Controller
    {
        SliderManager sm = new SliderManager();
        // GET: Slider
        public PartialViewResult Slider()
        {
            var values = sm.GetAll();
            return PartialView(values);
        }
        [Authorize]
        public ActionResult SliderList()
        {
            var values = sm.GetAll();
            return View(values);
        }
        [Authorize]
        public ActionResult DeleteSlider(int id)
        {
            sm.DeleteSlider(id);
            return RedirectToAction("SliderList");
        }
        [Authorize]
        [HttpGet]
        public ActionResult AddSlider()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSlider(Slider b)
        {
            if (Request.Files.Count > 0)
            {
                string dosyaadi = Path.GetFileName(Request.Files[0].FileName);
                string uzanti = Path.GetExtension(Request.Files[0].FileName);
                string yol = "/Images/" + dosyaadi + uzanti;
                Request.Files[0].SaveAs(Server.MapPath(yol));
                b.Image1 = "/Images/" + dosyaadi + uzanti;
            }
            sm.SliderAdd(b);
            return RedirectToAction("SliderList");
        }
    }
}