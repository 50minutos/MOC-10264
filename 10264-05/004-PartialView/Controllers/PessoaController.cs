using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _004_PartialView.Models;

namespace _004_PartialView.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View(new ModelContainer().Pessoas);
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            return View();
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
                    using(var mc = new ModelContainer())
                    {
                        mc.AddToPessoas(p);
                        mc.SaveChanges();
                    }

                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("MSG", ex);
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
            return View();
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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
            return View();
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
