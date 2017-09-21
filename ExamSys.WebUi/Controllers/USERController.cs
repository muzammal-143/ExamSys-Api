using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamSys.WebUi.Controllers
{
    public class USERController : Controller
    {
        // GET: USER
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login() 
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login()
        //{
        //    return View();
        //}
    }
}