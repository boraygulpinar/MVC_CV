
using MVC_CV.Models.Entity;
using MVC_CV.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CV.Controllers
{
    public class SkillController : Controller
    {
        GenericRepository<TBL_Skills> repo = new GenericRepository<TBL_Skills>();
        // GET: Skill
        public ActionResult Index()
        {
            var yetenekler = repo.list();
            return View(yetenekler);
        }
        [HttpGet]
        public ActionResult NewSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewSkill(TBL_Skills p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSkill(int id)
        {
            var yetenek=repo.Find(x=>x.ID==id);
            repo.TRemove(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SkillUpdate(int id)
        {
            var yetenek=repo.Find(x=>x.ID==id);
            return View(yetenek);
        }
        [HttpPost]
        public ActionResult SkillUpdate(TBL_Skills p)
        {
            var y = repo.Find(x => x.ID == p.ID);
            y.Skill=p.Skill;
            y.SkillValue=p.SkillValue;
            repo.TUpdate(y);
            return RedirectToAction("Index");
        }
    }
}