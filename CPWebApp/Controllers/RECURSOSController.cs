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
    public class RECURSOSController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: RECURSOS
        public ActionResult Index()
        {
            var rECURSOS = db.RECURSOS.Include(r => r.PESSOAS).Include(r => r.SISTEMAS).Include(r => r.TIPO_RECURSO);
            return View(rECURSOS.ToList());
        }

        // GET: RECURSOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RECURSOS rECURSOS = db.RECURSOS.Find(id);
            if (rECURSOS == null)
            {
                return HttpNotFound();
            }
            return View(rECURSOS);
        }

        // GET: RECURSOS/Create
        public ActionResult Create()
        {
            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome");
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome");
            ViewBag.tipo = new SelectList(db.TIPO_RECURSO, "id", "titulo");
            return View();
        }

        // POST: RECURSOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,pessoa,sistema,tipo")] RECURSOS rECURSOS)
        {
            if (ModelState.IsValid)
            {
                db.RECURSOS.Add(rECURSOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome", rECURSOS.pessoa);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", rECURSOS.sistema);
            ViewBag.tipo = new SelectList(db.TIPO_RECURSO, "id", "titulo", rECURSOS.tipo);
            return View(rECURSOS);
        }

        // GET: RECURSOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RECURSOS rECURSOS = db.RECURSOS.Find(id);
            if (rECURSOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome", rECURSOS.pessoa);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", rECURSOS.sistema);
            ViewBag.tipo = new SelectList(db.TIPO_RECURSO, "id", "titulo", rECURSOS.tipo);
            return View(rECURSOS);
        }

        // POST: RECURSOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,pessoa,sistema,tipo")] RECURSOS rECURSOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rECURSOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome", rECURSOS.pessoa);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", rECURSOS.sistema);
            ViewBag.tipo = new SelectList(db.TIPO_RECURSO, "id", "titulo", rECURSOS.tipo);
            return View(rECURSOS);
        }

        // GET: RECURSOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RECURSOS rECURSOS = db.RECURSOS.Find(id);
            if (rECURSOS == null)
            {
                return HttpNotFound();
            }
            return View(rECURSOS);
        }

        // POST: RECURSOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RECURSOS rECURSOS = db.RECURSOS.Find(id);
            db.RECURSOS.Remove(rECURSOS);
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
