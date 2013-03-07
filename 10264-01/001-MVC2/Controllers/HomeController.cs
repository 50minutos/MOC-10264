using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _001_MVC2.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Home/DataAtual

        public String DataAtual()
        {
            return DateTime.Now.ToString();
        }
    }
}
