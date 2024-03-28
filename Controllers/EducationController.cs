using MVC_CV.Models.Entity;
using MVC_CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CV.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<TBL_Education> repo = new GenericRepository<TBL_Education>();
        // GET: Education
        public ActionResult Index()
        {
            var egitim = repo.list();
            return View(egitim);
        }
        
    }
}