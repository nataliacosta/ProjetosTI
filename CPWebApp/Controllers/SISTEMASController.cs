using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CPWebApp.Models;

namespace CPWebApp.Controllers
{
    public class SISTEMASController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: SISTEMAS
        public ActionResult Index()
        {
            return View(db.SISTEMAS.ToList());
        }

        // GET: SISTEMAS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            if (sISTEMAS == null)
            {
                return HttpNotFound();
            }
            return View(sISTEMAS);
        }

        // GET: SISTEMAS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SISTEMAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome")] SISTEMAS sISTEMAS)
        {
            if (ModelState.IsValid)
            {
                db.SISTEMAS.Add(sISTEMAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sISTEMAS);
        }

        // GET: SISTEMAS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            if (sISTEMAS == null)
            {
                return HttpNotFound();
            }
            return View(sISTEMAS);
        }

        // POST: SISTEMAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome")] SISTEMAS sISTEMAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sISTEMAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sISTEMAS);
        }

        // GET: SISTEMAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            if (sISTEMAS == null)
            {
                return HttpNotFound();
            }
            return View(sISTEMAS);
        }

        // POST: SISTEMAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SISTEMAS sISTEMAS = db.SISTEMAS.Find(id);
            db.SISTEMAS.Remove(sISTEMAS);
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
