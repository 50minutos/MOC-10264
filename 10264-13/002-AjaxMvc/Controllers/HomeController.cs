using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _002_AjaxMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }

        public String ObterData()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss.ffff");
        }
    }
}
