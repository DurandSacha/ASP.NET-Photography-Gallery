using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Photography_Gallery.Models;

namespace Photography_Gallery.Controllers
{
    public class PhotographyController : Controller
    {
        private BddContext db = new BddContext();

        // GET: Photography
        public ActionResult Index()
        {
            return View(db.Photographies.ToList());
        }

        // GET: Photography/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photography photography = db.Photographies.Find(id);
            if (photography == null)
            {
                return HttpNotFound();
            }
            return View(photography);
        }

        // GET: Photography/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Photography/Create
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nom,Path")] Photography photography)
        {
            if (ModelState.IsValid)
            {
                db.Photographies.Add(photography);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photography);
        }

        // GET: Photography/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photography photography = db.Photographies.Find(id);
            if (photography == null)
            {
                return HttpNotFound();
            }
            return View(photography);
        }

        // POST: Photography/Edit/5
        // Pour vous protéger des attaques par survalidation, activez les propriétés spécifiques auxquelles vous souhaitez vous lier. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nom,Path")] Photography photography)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photography).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(photography);
        }

        // GET: Photography/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Photography photography = db.Photographies.Find(id);
            if (photography == null)
            {
                return HttpNotFound();
            }
            return View(photography);
        }

        // POST: Photography/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Photography photography = db.Photographies.Find(id);
            db.Photographies.Remove(photography);
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
