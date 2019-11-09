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
    public class TIPO_RECURSOController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: TIPO_RECURSO
        public ActionResult Index()
        {
            return View(db.TIPO_RECURSO.ToList());
        }

        // GET: TIPO_RECURSO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_RECURSO tIPO_RECURSO = db.TIPO_RECURSO.Find(id);
            if (tIPO_RECURSO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_RECURSO);
        }

        // GET: TIPO_RECURSO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TIPO_RECURSO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,titulo,cria_solicitacao,cria_projeto,aprova_solicitacao,aprova_projeto,administrador")] TIPO_RECURSO tIPO_RECURSO)
        {
            if (ModelState.IsValid)
            {
                db.TIPO_RECURSO.Add(tIPO_RECURSO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPO_RECURSO);
        }

        // GET: TIPO_RECURSO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_RECURSO tIPO_RECURSO = db.TIPO_RECURSO.Find(id);
            if (tIPO_RECURSO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_RECURSO);
        }

        // POST: TIPO_RECURSO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,titulo,cria_solicitacao,cria_projeto,aprova_solicitacao,aprova_projeto,administrador")] TIPO_RECURSO tIPO_RECURSO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPO_RECURSO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPO_RECURSO);
        }

        // GET: TIPO_RECURSO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPO_RECURSO tIPO_RECURSO = db.TIPO_RECURSO.Find(id);
            if (tIPO_RECURSO == null)
            {
                return HttpNotFound();
            }
            return View(tIPO_RECURSO);
        }

        // POST: TIPO_RECURSO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TIPO_RECURSO tIPO_RECURSO = db.TIPO_RECURSO.Find(id);
            db.TIPO_RECURSO.Remove(tIPO_RECURSO);
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
