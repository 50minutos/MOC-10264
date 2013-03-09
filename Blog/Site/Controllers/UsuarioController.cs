using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class UsuarioController : Controller
    {
        //
        // GET: /Usuario/

        public ActionResult Index()
        {
            return View(new Models.DBEntities().Usuarios.ToList());
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            return View(new Models.DBEntities().Usuarios.FirstOrDefault(u => u.Cod == id));
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(Models.Usuario u)
        {
            if (ModelState.IsValid)
            {
                var e = new Models.DBEntities();
                e.AddToUsuarios(u);
                e.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            return View(new Models.DBEntities().Usuarios.FirstOrDefault(u => u.Cod == id));
        }

        //
        // POST: /Usuario/Edit/5

        [HttpPost]
        public ActionResult Edit(Models.Usuario u)
        {
            if (ModelState.IsValid)
            {
                using (var e = new Models.DBEntities())
                {
                    e.Attach(e.Usuarios.Single(x => x.Cod == u.Cod));
                    e.ApplyCurrentValues("Usuarios", u);
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
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {
            return View(new Models.DBEntities().Usuarios.FirstOrDefault(u => u.Cod == id));
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            using (var e = new Models.DBEntities())
            {
                var obj = e.Usuarios.FirstOrDefault(x => x.Cod == id);

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
