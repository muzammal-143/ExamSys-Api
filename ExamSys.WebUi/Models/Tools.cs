using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using ExamSys.Database;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
namespace ExamSys.WebUi.Models
{
    public class Tools
    {
        public JavaScriptSerializer toJson(dynamic data) 
        {
            var SerializeJson = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            var DeserializeJson = new JavaScriptSerializer().Deserialize<object>(SerializeJson);
            return DeserializeJson;
        }
        
    }
}