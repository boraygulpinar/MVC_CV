using MVC_CV.Models.Entity;
using MVC_CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CV.Controllers
{
    public class AdminController : Controller
    {
        GenericRepository<TBL_About> repo = new GenericRepository<TBL_About>();
        // GET: Admin
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.list();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TBL_About p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Name=p.Name;
            t.Surname=p.Surname;
            t.Address=p.Address;
            t.Mail=p.Mail;
            t.Description=p.Description;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}