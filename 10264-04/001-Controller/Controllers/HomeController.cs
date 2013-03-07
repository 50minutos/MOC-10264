using System;
using System.Web.Mvc;
using _001_Controller.Util;

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
}
