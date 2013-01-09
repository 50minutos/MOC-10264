using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _003_Helpers.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View(new Models.Pessoa[]{ new Models.Pessoa{ Codigo=1, Nome="ADÃO", Sexo = 'M'} });
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.Pessoa p)
        {
            if (ModelState.IsValid)
            {
                //todo: gravar!!!

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
