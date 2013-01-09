using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _003_MVC3.Models;

namespace _003_MVC3.Controllers
{ 
    public class PessoaController : Controller
    {
        private DBEntities db = new DBEntities();

        //
        // GET: /Pessoa/

        public ViewResult Index()
        {
            return View(db.Pessoas.ToList());
        }

        //
        // GET: /Pessoa/Details/5

        public ViewResult Details(int id)
        {
            Pessoa pessoa = db.Pessoas.Single(p => p.Codigo == id);
            return View(pessoa);
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
        public ActionResult Create(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.AddObject(pessoa);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(pessoa);
        }
        
        //
        // GET: /Pessoa/Edit/5
 
        public ActionResult Edit(int id)
        {
            Pessoa pessoa = db.Pessoas.Single(p => p.Codigo == id);
            return View(pessoa);
        }

        //
        // POST: /Pessoa/Edit/5

        [HttpPost]
        public ActionResult Edit(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.Attach(pessoa);
                db.ObjectStateManager.ChangeObjectState(pessoa, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoa/Delete/5
 
        public ActionResult Delete(int id)
        {
            Pessoa pessoa = db.Pessoas.Single(p => p.Codigo == id);
            return View(pessoa);
        }

        //
        // POST: /Pessoa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Pessoa pessoa = db.Pessoas.Single(p => p.Codigo == id);
            db.Pessoas.DeleteObject(pessoa);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}