using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _004_PartialView.Models;

namespace _004_PartialView.Controllers
{
    public class SexoController : Controller
    {
        //
        // GET: /Sexo/

        public ActionResult Index()
        {
            return View(new ModelContainer().Sexos);
        }

        //
        // GET: /Sexo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Sexo/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Sexo/Create

        [HttpPost]
        public ActionResult Create(Sexo s)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using(var mc = new ModelContainer())
                    {
                        mc.AddToSexos(s);
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
        // GET: /Sexo/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Sexo/Edit/5

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
        // GET: /Sexo/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Sexo/Delete/5

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
