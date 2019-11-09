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
    public class PARTICIPANTESController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: PARTICIPANTES
        public ActionResult Index()
        {
            var pARTICIPANTES = db.PARTICIPANTES.Include(p => p.PESSOAS).Include(p => p.PROJETOS).Include(p => p.TIPO_PARTICIPANTE);
            return View(pARTICIPANTES.ToList());
        }

        // GET: PARTICIPANTES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PARTICIPANTES pARTICIPANTES = db.PARTICIPANTES.Find(id);
            if (pARTICIPANTES == null)
            {
                return HttpNotFound();
            }
            return View(pARTICIPANTES);
        }

        // GET: PARTICIPANTES/Create
        public ActionResult Create()
        {
            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome");
            ViewBag.projeto = new SelectList(db.PROJETOS, "id", "titulo");
            ViewBag.tipo = new SelectList(db.TIPO_PARTICIPANTE, "id", "titulo");
            return View();
        }

        // POST: PARTICIPANTES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pessoa,projeto,tipo,id")] PARTICIPANTES pARTICIPANTES)
        {
            if (ModelState.IsValid)
            {
                db.PARTICIPANTES.Add(pARTICIPANTES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome", pARTICIPANTES.pessoa);
            ViewBag.projeto = new SelectList(db.PROJETOS, "id", "titulo", pARTICIPANTES.projeto);
            ViewBag.tipo = new SelectList(db.TIPO_PARTICIPANTE, "id", "titulo", pARTICIPANTES.tipo);
            return View(pARTICIPANTES);
        }

        // GET: PARTICIPANTES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PARTICIPANTES pARTICIPANTES = db.PARTICIPANTES.Find(id);
            if (pARTICIPANTES == null)
            {
                return HttpNotFound();
            }
            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome", pARTICIPANTES.pessoa);
            ViewBag.projeto = new SelectList(db.PROJETOS, "id", "titulo", pARTICIPANTES.projeto);
            ViewBag.tipo = new SelectList(db.TIPO_PARTICIPANTE, "id", "titulo", pARTICIPANTES.tipo);
            return View(pARTICIPANTES);
        }

        // POST: PARTICIPANTES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pessoa,projeto,tipo,id")] PARTICIPANTES pARTICIPANTES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pARTICIPANTES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.pessoa = new SelectList(db.PESSOAS, "id", "nome", pARTICIPANTES.pessoa);
            ViewBag.projeto = new SelectList(db.PROJETOS, "id", "titulo", pARTICIPANTES.projeto);
            ViewBag.tipo = new SelectList(db.TIPO_PARTICIPANTE, "id", "titulo", pARTICIPANTES.tipo);
            return View(pARTICIPANTES);
        }

        // GET: PARTICIPANTES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PARTICIPANTES pARTICIPANTES = db.PARTICIPANTES.Find(id);
            if (pARTICIPANTES == null)
            {
                return HttpNotFound();
            }
            return View(pARTICIPANTES);
        }

        // POST: PARTICIPANTES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PARTICIPANTES pARTICIPANTES = db.PARTICIPANTES.Find(id);
            db.PARTICIPANTES.Remove(pARTICIPANTES);
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
