using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class PostController : Controller
    {
        //
        // GET: /Post/

        public ActionResult Index()
        {
            return View(new Models.DBEntities().Posts.ToList());
        }

        //
        // GET: /Post/Details/5

        public ActionResult Details(int id)
        {
            return View(new Models.DBEntities().Posts.FirstOrDefault(p => p.Cod == id));
        }

        //
        // GET: /Post/Create

        public ActionResult Create()
        {
            ViewData["USUARIOS"] = new SelectList(new Models.DBEntities().Usuarios.ToList(), "Cod", "Nome");
            return View();
        } 

        //
        // POST: /Post/Create

        [HttpPost]
        public ActionResult Create(Models.Post p)
        {
            if (ModelState.IsValid)
            {
                var e = new Models.DBEntities();
                e.AddToPosts(p);
                e.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        
        //
        // GET: /Post/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(new Models.DBEntities().Posts.FirstOrDefault(p => p.Cod == id));
        }

        //
        // POST: /Post/Edit/5

        [HttpPost]
        public ActionResult Edit(Models.Post p)
        {
            if (ModelState.IsValid)
            {
                using (var e = new Models.DBEntities())
                {
                    e.Attach(e.Posts.Single(x => x.Cod == p.Cod));
                    e.ApplyCurrentValues("Posts", p);
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
        // GET: /Post/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(new Models.DBEntities().Posts.FirstOrDefault(p => p.Cod == id));
        }

        //
        // POST: /Post/Delete/5

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ProcessDelete(int id)
        {
            using (var e = new Models.DBEntities())
            {
                var obj = e.Posts.FirstOrDefault(x => x.Cod == id);

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
