using MVC_CV.Models.Entity;
using MVC_CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CV.Controllers
{
    public class CommunicationController : Controller
    {
        GenericRepository<TBL_Communication> repo = new GenericRepository<TBL_Communication>();
        // GET: Communication
        public ActionResult Index()
        {
            var mesajlar = repo.list();
            return View(mesajlar);
        }

    }
}