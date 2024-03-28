using MVC_CV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_CV.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBL_Admin p)
        {
            DbCvEntities db = new DbCvEntities();
            var info = db.TBL_Admin.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if(info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Username,false);
                Session["Username"] = info.Username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}