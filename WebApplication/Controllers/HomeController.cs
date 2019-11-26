using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Getstudent()
        {
            DataContext db = new DataContext();
            List<Student> Students = db.Students.ToList();
            return Json(Students, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Info()
        {
            return View();
        }
        
    }
}