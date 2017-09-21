using ExamSys.Database;
using ExamSys.WebUi.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace ExamSys.WebUi.Controllers
{
    public class RoleController : Controller
    {
        // GET: Role
        private ExamDB db = new ExamDB();
        public Tools Tool = new Tools();
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
                returnData.status = "success";
                returnData.message = "Find some data";
                returnData.data = db.Role.Where(m => m.isDeleted == false).ToList();
            }
            catch (Exception ex)
            {
                returnData.status = "error";
                returnData.message = ex.Message.ToString();
                returnData.data = "";
            }

            var SerializeJson = Newtonsoft.Json.JsonConvert.SerializeObject(returnData);
            var DeserializeJson = new JavaScriptSerializer().Deserialize<object>(SerializeJson);

            return Json(DeserializeJson, JsonRequestBehavior.AllowGet);
        }

        
        [HttpPost]
        public JsonResult add(FormCollection collection)
        {
            // Get Post Params Here
            
            dynamic returnData = new ExpandoObject();
            try
            {
                string var1 = collection["var1"];

                returnData.status = "success";
                returnData.data = "Inserted successfully";
            }
            catch (Exception ex)
            {
                returnData.status = "error";
                returnData.data = ex.Message.ToString();
            }

            var SerializeJson = Newtonsoft.Json.JsonConvert.SerializeObject(returnData);
            var DeserializeJson = new JavaScriptSerializer().Deserialize<object>(SerializeJson);

            return Json(DeserializeJson, JsonRequestBehavior.AllowGet);
        }
        /*
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