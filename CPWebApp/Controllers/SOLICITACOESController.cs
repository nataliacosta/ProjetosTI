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
    public class SOLICITACOESController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: SOLICITACOES
        public ActionResult Index()
        {
            var sOLICITACOES = db.SOLICITACOES.Include(s => s.PESSOAS).Include(s => s.PESSOAS1).Include(s => s.SISTEMAS);
            return View(sOLICITACOES.ToList());
        }

        // GET: SOLICITACOES/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOLICITACOES sOLICITACOES = db.SOLICITACOES.Find(id);
            if (sOLICITACOES == null)
            {
                return HttpNotFound();
            }
            return View(sOLICITACOES);
        }

        // GET: SOLICITACOES/Create
        public ActionResult Create()
        {
            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome");
            ViewBag.solicitante = new SelectList(db.PESSOAS, "id", "nome");
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome");
            return View();
        }

        // POST: SOLICITACOES/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,sistema,solicitante,aprovador,titulo,descricao,criado_em,aprovado_em,status")] SOLICITACOES sOLICITACOES)
        {
            if (ModelState.IsValid)
            {
                db.SOLICITACOES.Add(sOLICITACOES);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome", sOLICITACOES.aprovador);
            ViewBag.solicitante = new SelectList(db.PESSOAS, "id", "nome", sOLICITACOES.solicitante);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", sOLICITACOES.sistema);
            return View(sOLICITACOES);
        }

        // GET: SOLICITACOES/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOLICITACOES sOLICITACOES = db.SOLICITACOES.Find(id);
            if (sOLICITACOES == null)
            {
                return HttpNotFound();
            }
            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome", sOLICITACOES.aprovador);
            ViewBag.solicitante = new SelectList(db.PESSOAS, "id", "nome", sOLICITACOES.solicitante);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", sOLICITACOES.sistema);
            return View(sOLICITACOES);
        }

        // POST: SOLICITACOES/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,sistema,solicitante,aprovador,titulo,descricao,criado_em,aprovado_em,status")] SOLICITACOES sOLICITACOES)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sOLICITACOES).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome", sOLICITACOES.aprovador);
            ViewBag.solicitante = new SelectList(db.PESSOAS, "id", "nome", sOLICITACOES.solicitante);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", sOLICITACOES.sistema);
            return View(sOLICITACOES);
        }

        // GET: SOLICITACOES/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SOLICITACOES sOLICITACOES = db.SOLICITACOES.Find(id);
            if (sOLICITACOES == null)
            {
                return HttpNotFound();
            }
            return View(sOLICITACOES);
        }

        // POST: SOLICITACOES/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SOLICITACOES sOLICITACOES = db.SOLICITACOES.Find(id);
            db.SOLICITACOES.Remove(sOLICITACOES);
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
