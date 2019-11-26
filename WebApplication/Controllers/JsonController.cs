using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public JsonResult GetNumber()
        {
            DataContext db = new DataContext();
            string result = db.Students.FirstOrDefault(x => x.StudentId == 1).StudentLastname;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetString()
        {
            DataContext db = new DataContext();
            string result2 = db.Students.FirstOrDefault(x => x.StudentId == 1).StudentName;
            return Json(result2, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetId()
        {
            DataContext db = new DataContext();
            int result3 = db.Students.FirstOrDefault(x => x.StudentId == 1).StudentId;
            return Json(result3, JsonRequestBehavior.AllowGet);
        }
    }
}