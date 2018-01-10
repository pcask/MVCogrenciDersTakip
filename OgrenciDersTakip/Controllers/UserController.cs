using OgrenciDersTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciDersTakip.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string userName, string password)
        {
            var context = new OgrenciDersTakipDbContext();

            var user = context.User.Where(u => u.UserName == userName && u.Password == password).FirstOrDefault();

            bool r = user != null;

            return Json(new { UserId = user?.Id, Result = r }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Lesson(int UserId)
        {
            var context = new OgrenciDersTakipDbContext();

            var user = context.User.Include("Lessons").Where(u => u.Id == UserId).FirstOrDefault();

            var lesson = user.Lessons.ToList();


            // lesson yerine user gönderip user'a ait lesson lar içerisinde dönme işlemine bak!!!
            return View(lesson);
        }
    }
}