using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class CategoriaController : Controller
    {
        //
        // GET: /Categoria/

        public ActionResult Index()
        {
            return View(new Models.DBEntities().Categorias.ToList());
        }

        //
        // GET: /Categoria/Details/5

        public ActionResult Details(int id)
        {
            return View(new Models.DBEntities().Categorias.FirstOrDefault(c => c.Cod == id));
        }

        //
        // GET: /Categoria/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Categoria/Create

        [HttpPost]
        public ActionResult Create(Models.Categoria c)
        {
            if (ModelState.IsValid)
            {
                var e = new Models.DBEntities();
                e.AddToCategorias(c);
                e.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Categoria/Edit/5

        public ActionResult Edit(int id)
        {
            return View(new Models.DBEntities().Categorias.FirstOrDefault(c => c.Cod == id));
        }

        //
        // POST: /Categoria/Edit/5

        [HttpPost]
        public ActionResult Edit(Models.Categoria c)
        {
            if (ModelState.IsValid)
            {
                using (var e = new Models.DBEntities())
                {
                    e.Attach(e.Categorias.Single(x => x.Cod == c.Cod));
                    e.ApplyCurrentValues("Categorias", c);
                    e.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Categoria/Delete/5

        public ActionResult Delete(int id)
        {
            return View(new Models.DBEntities().Categorias.FirstOrDefault(c => c.Cod == id));
        }

        //
        // POST: /Categoria/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            using (var e = new Models.DBEntities())
            {
                var obj = e.Categorias.FirstOrDefault(x => x.Cod == id);

                if (obj != null)
                {
                    e.DeleteObject(obj);
                    e.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
