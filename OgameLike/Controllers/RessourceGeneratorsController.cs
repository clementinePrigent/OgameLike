using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BO_OgameLike;
using OgameLike.Data;

namespace OgameLike.Controllers
{
    public class RessourceGeneratorsController : Controller
    {
        private OgameLikeContext db = new OgameLikeContext();

        // GET: RessourceGenerators
        public ActionResult Index()
        {
            return View(db.RessourceGenerators.ToList());
        }

        // GET: RessourceGenerators/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RessourceGenerator ressourceGenerator = db.RessourceGenerators.Find(id);
            if (ressourceGenerator == null)
            {
                return HttpNotFound();
            }
            return View(ressourceGenerator);
        }

        // GET: RessourceGenerators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RessourceGenerators/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] RessourceGenerator ressourceGenerator)
        {
            if (ModelState.IsValid)
            {
                db.RessourceGenerators.Add(ressourceGenerator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ressourceGenerator);
        }

        // GET: RessourceGenerators/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RessourceGenerator ressourceGenerator = db.RessourceGenerators.Find(id);
            if (ressourceGenerator == null)
            {
                return HttpNotFound();
            }
            return View(ressourceGenerator);
        }

        // POST: RessourceGenerators/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] RessourceGenerator ressourceGenerator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ressourceGenerator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ressourceGenerator);
        }

        // GET: RessourceGenerators/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RessourceGenerator ressourceGenerator = db.RessourceGenerators.Find(id);
            if (ressourceGenerator == null)
            {
                return HttpNotFound();
            }
            return View(ressourceGenerator);
        }

        // POST: RessourceGenerators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            RessourceGenerator ressourceGenerator = db.RessourceGenerators.Find(id);
            db.RessourceGenerators.Remove(ressourceGenerator);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
