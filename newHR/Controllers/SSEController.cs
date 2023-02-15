using newHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace newHR.Controllers
{
    public class SSEController : Controller
    {
        // GET: SSE
        public ActionResult Index()
        {
            return View();
        }
        DBContext db = new DBContext();
        public ActionResult SSE(string userid)
        {
            /*= "sameh";
            DateTime n = new DateTime();*/
            var sb = new StringBuilder();
            var data =db.getData("select count(*)cnt from Requests where (Auth1User ='"+userid+"' and Auth1Status = 0) or (Auth2User ='"+userid+"' and Auth2Status = 0 and Auth1Status = 1)");
           // var emptyData = db.getData("select 0 cnt");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            if (!string.IsNullOrEmpty(StreamModel.dataHolder))
            {
                var serializedObject = ser.Serialize(new { result = data.Rows[0][0]/*StreamModel.dataHolder*/, status = "success" });
                sb.AppendFormat("data: {0}\n\n", serializedObject);
            }
            else
            {
                var serializedObject = ser.Serialize(new { result = data.Rows[0][0] /*emptyData.Rows[0][0]*/, status = "not found" });
                sb.AppendFormat("data: {0}\n\n", serializedObject);
            }
            return Content(sb.ToString(), "text/event-stream");
        }
    }
}