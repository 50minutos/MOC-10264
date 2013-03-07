using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _002_DB.Models;
using System.Data;

namespace _002_DB.Controllers
{
    public class PessoaController : Controller
    {
        //
        // GET: /Pessoa/

        public ActionResult Index()
        {
            return View(new ModelContainer().Pessoas.ToList<Pessoa>());
        }

        //
        // GET: /Pessoa/Details/5

        public ActionResult Details(int id)
        {
            return View(new ModelContainer().Pessoas.FirstOrDefault(p => p.Id == id));
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
            try
            {
                var mc = new ModelContainer();
                
                mc.AddToPessoas(p);
                mc.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Pessoa/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(new ModelContainer().Pessoas.FirstOrDefault(p => p.Id == id));
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Pessoa p)
        {
            try
            {
                var mc = new ModelContainer();

                mc.Pessoas.Attach(p);
                mc.ObjectStateManager.ChangeObjectState(p, EntityState.Modified);
                mc.SaveChanges();
 
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
            return View(new ModelContainer().Pessoas.FirstOrDefault(p => p.Id == id));
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost]
        public ActionResult Delete(Pessoa p)
        {
            try
            {
                var mc = new ModelContainer();
 
                mc.Pessoas.Attach(p);
                mc.Pessoas.DeleteObject(p);
                mc.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
