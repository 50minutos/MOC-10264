using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace _001_Controller.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [LogAction]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10, VaryByParam = "none")]
        public String GetDate()
        {
            return DateTime.Now.ToString();
        }

        [LogAction]
        public ActionResult About()
        {
            ViewData["NOME"] = "Agnaldo";

            return View();
        }
    }

    public class LogActionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var fileName = String.Format(@"c:\log\log{0}.txt", DateTime.Now.ToString("yyyyMMdd"));

            using (var sw = new System.IO.StreamWriter(fileName, true))
            {
                sw.WriteLine("{0} FIM - {1}", DateTime.Now.ToString("HH:mm:ss"), filterContext.ActionDescriptor.ActionName);
            }
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var fileName = String.Format(@"c:\log\log{0}.txt", DateTime.Now.ToString("yyyyMMdd"));

            using (var sw = new System.IO.StreamWriter(fileName, true))
            {
                sw.WriteLine("{0} INI - {1}", DateTime.Now.ToString("HH:mm:ss"), filterContext.ActionDescriptor.ActionName);
            }
        }
    }
}
