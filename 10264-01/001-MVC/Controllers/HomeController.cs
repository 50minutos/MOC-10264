using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploMVC.Controllers
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
        // GET: /Home/About

        public ActionResult About()
        {
            ViewData["MENSAGEM"] = "tranquilo???";

            return View();
        }
    }
}
