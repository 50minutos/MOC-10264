using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _002_CRUD.Models;

namespace _002_CRUD.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View(new DBEntities().Pessoas);
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            return View(new DBEntities().Pessoas.FirstOrDefault(x => x.Codigo == id));
        }

        //
        // GET: /Pessoa/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Pessoa/Create

        [HttpPost]
        public ActionResult Create(Pessoa p)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        
        //
        // GET: /Pessoa/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(new DBEntities().Pessoas.FirstOrDefault(x => x.Codigo == id));
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(Pessoa p)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pessoa/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(new DBEntities().Pessoas.FirstOrDefault(x => x.Codigo == id));
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
