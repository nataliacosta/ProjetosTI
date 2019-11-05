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
    public class PESSOASController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: PESSOAS
        public ActionResult Index()
        {
            var pESSOAS = db.PESSOAS.Include(p => p.PESSOAS2);
            return View(pESSOAS.ToList());
        }

        // GET: PESSOAS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PESSOAS pESSOAS = db.PESSOAS.Find(id);
            if (pESSOAS == null)
            {
                return HttpNotFound();
            }
            return View(pESSOAS);
        }

        // GET: PESSOAS/Create
        public ActionResult Create()
        {
            ViewBag.gestor = new SelectList(db.PESSOAS, "id", "nome");
            return View();
        }

        // POST: PESSOAS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,gestor")] PESSOAS pESSOAS)
        {
            if (ModelState.IsValid)
            {
                db.PESSOAS.Add(pESSOAS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.gestor = new SelectList(db.PESSOAS, "id", "nome", pESSOAS.gestor);
            return View(pESSOAS);
        }

        // GET: PESSOAS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PESSOAS pESSOAS = db.PESSOAS.Find(id);
            if (pESSOAS == null)
            {
                return HttpNotFound();
            }
            ViewBag.gestor = new SelectList(db.PESSOAS, "id", "nome", pESSOAS.gestor);
            return View(pESSOAS);
        }

        // POST: PESSOAS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,gestor")] PESSOAS pESSOAS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pESSOAS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.gestor = new SelectList(db.PESSOAS, "id", "nome", pESSOAS.gestor);
            return View(pESSOAS);
        }

        // GET: PESSOAS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PESSOAS pESSOAS = db.PESSOAS.Find(id);
            if (pESSOAS == null)
            {
                return HttpNotFound();
            }
            return View(pESSOAS);
        }

        // POST: PESSOAS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PESSOAS pESSOAS = db.PESSOAS.Find(id);
            db.PESSOAS.Remove(pESSOAS);
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
