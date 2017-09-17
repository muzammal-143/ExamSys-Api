using ExamSys.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamSys.WebUi.Controllers
{
    public class HomeController : Controller
    {
        ExamDB db = new ExamDB();
        public ActionResult Index()
        {
            //var s = db.Comment.ToList();
            ViewBag.Title = "Home Page";

            return View();
        }

        // Activity = 1
        [Authorize(Roles = "0")]
        public ActionResult StartPage() 
        {
            return View();
        }
    }
}
