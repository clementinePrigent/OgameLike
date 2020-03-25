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
    public class FunctionBuildingsController : Controller
    {
        private OgameLikeContext db = new OgameLikeContext();

        // GET: FunctionBuildings
        public ActionResult Index()
        {
            return View(db.FunctionBuildings.ToList());
        }

        // GET: FunctionBuildings/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FunctionBuilding functionBuilding = db.FunctionBuildings.Find(id);
            if (functionBuilding == null)
            {
                return HttpNotFound();
            }
            return View(functionBuilding);
        }

        // GET: FunctionBuildings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FunctionBuildings/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] FunctionBuilding functionBuilding)
        {
            if (ModelState.IsValid)
            {
                db.FunctionBuildings.Add(functionBuilding);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(functionBuilding);
        }

        // GET: FunctionBuildings/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FunctionBuilding functionBuilding = db.FunctionBuildings.Find(id);
            if (functionBuilding == null)
            {
                return HttpNotFound();
            }
            return View(functionBuilding);
        }

        // POST: FunctionBuildings/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] FunctionBuilding functionBuilding)
        {
            if (ModelState.IsValid)
            {
                db.Entry(functionBuilding).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(functionBuilding);
        }

        // GET: FunctionBuildings/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FunctionBuilding functionBuilding = db.FunctionBuildings.Find(id);
            if (functionBuilding == null)
            {
                return HttpNotFound();
            }
            return View(functionBuilding);
        }

        // POST: FunctionBuildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            FunctionBuilding functionBuilding = db.FunctionBuildings.Find(id);
            db.FunctionBuildings.Remove(functionBuilding);
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
