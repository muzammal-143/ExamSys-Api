using ExamSys.Database;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamSys.WebUi.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        private ExamDB db = new ExamDB();

        [HttpGet]
        public ActionResult Index()
        {
            var x = db.Role.Where(m => m.isDeleted == false).ToList();
            return View(x);
        }

        public JsonResult all()
        {
            dynamic returnData = new ExpandoObject();
            try
            {
                returnData.status = "sucess";
                returnData.data = db.Role.Where(m => m.isDeleted == false).ToList();
            }
            catch (Exception ex)
            {
                returnData.status = "error";
                returnData.data = ex.Message.ToString();
            }
            return Json(returnData, JsonRequestBehavior.AllowGet);
        }

        /*
        [HttpPost]
        public ActionResult SubmitAction(FormCollection collection)
        {
            // Get Post Params Here
            string var1 = collection["var1"];
        }
        [HttpPost]
        public ActionResult SubmitAction()
        {
            var value1 = Request["SimpleProp1"];
            var value2 = Request["SimpleProp2"];
            var value3 = Request["ComplexProp1.SimpleProp1"];
            
        }
         */ 


    }
}