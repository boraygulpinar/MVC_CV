using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_CV.Models.Entity;

namespace MVC_CV.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var degerler = db.TBL_About.ToList();
            return View(degerler);
        }
        public PartialViewResult Education()
        {
            var degerler = db.TBL_Education.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Skills()
        {
            var degerler = db.TBL_Skills.ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public PartialViewResult Communication()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Communication(TBL_Communication t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBL_Communication.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}