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
    public class TIPO_PARTICIPANTEController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: TIPO_PARTICIPANTE
        public ActionResult Index()
        {
            return View(db.TIPO_PARTICIPANTE.ToList());
        }

        // GET: TIPO_PARTICIPANTE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_PARTICIPANTE tIPO_PARTICIPANTE = db.TIPO_PARTICIPANTE.Find(id);
            if (tIPO_PARTICIPANTE == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_PARTICIPANTE);
        }

        // GET: TIPO_PARTICIPANTE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_PARTICIPANTE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,titulo,insere_documentos")] TIPO_PARTICIPANTE tIPO_PARTICIPANTE)
        {
            if (ModelState.IsValid)
            {
                db.TIPO_PARTICIPANTE.Add(tIPO_PARTICIPANTE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPO_PARTICIPANTE);
        }

        // GET: TIPO_PARTICIPANTE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_PARTICIPANTE tIPO_PARTICIPANTE = db.TIPO_PARTICIPANTE.Find(id);
            if (tIPO_PARTICIPANTE == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_PARTICIPANTE);
        }

        // POST: TIPO_PARTICIPANTE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,titulo,insere_documentos")] TIPO_PARTICIPANTE tIPO_PARTICIPANTE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPO_PARTICIPANTE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_PARTICIPANTE);
        }

        // GET: TIPO_PARTICIPANTE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_PARTICIPANTE tIPO_PARTICIPANTE = db.TIPO_PARTICIPANTE.Find(id);
            if (tIPO_PARTICIPANTE == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_PARTICIPANTE);
        }

        // POST: TIPO_PARTICIPANTE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPO_PARTICIPANTE tIPO_PARTICIPANTE = db.TIPO_PARTICIPANTE.Find(id);
            db.TIPO_PARTICIPANTE.Remove(tIPO_PARTICIPANTE);
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
