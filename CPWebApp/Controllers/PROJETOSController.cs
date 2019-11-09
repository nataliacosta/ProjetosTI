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
    public class PROJETOSController : Controller
    {
        private CPDatabaseEntities db = new CPDatabaseEntities();

        // GET: PROJETOS
        public ActionResult Index()
        {
            var pROJETOS = db.PROJETOS.Include(p => p.PESSOAS).Include(p => p.PESSOAS1).Include(p => p.SISTEMAS).Include(p => p.SOLICITACOES);
            return View(pROJETOS.ToList());
        }

        // GET: PROJETOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROJETOS pROJETOS = db.PROJETOS.Find(id);
            if (pROJETOS == null)
            {
                return HttpNotFound();
            }
            return View(pROJETOS);
        }

        // GET: PROJETOS/Create
        public ActionResult Create()
        {
            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome");
            ViewBag.responsavel = new SelectList(db.PESSOAS, "id", "nome");
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome");
            ViewBag.solicitacao = new SelectList(db.SOLICITACOES, "id", "id");
            return View();
        }

        // POST: PROJETOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,sistema,responsavel,aprovador,aprovado_em,criado_em,titulo,descricao,solicitacao,finalizado_em,status")] PROJETOS pROJETOS)
        {
            if (ModelState.IsValid)
            {
                db.PROJETOS.Add(pROJETOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome", pROJETOS.aprovador);
            ViewBag.responsavel = new SelectList(db.PESSOAS, "id", "nome", pROJETOS.responsavel);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", pROJETOS.sistema);
            ViewBag.solicitacao = new SelectList(db.SOLICITACOES, "id", "id", pROJETOS.solicitacao);
            return View(pROJETOS);
        }

        // GET: PROJETOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROJETOS pROJETOS = db.PROJETOS.Find(id);
            if (pROJETOS == null)
            {
                return HttpNotFound();
            }
            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome", pROJETOS.aprovador);
            ViewBag.responsavel = new SelectList(db.PESSOAS, "id", "nome", pROJETOS.responsavel);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", pROJETOS.sistema);
            ViewBag.solicitacao = new SelectList(db.SOLICITACOES, "id", "id", pROJETOS.solicitacao);
            return View(pROJETOS);
        }

        // POST: PROJETOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,sistema,responsavel,aprovador,aprovado_em,criado_em,titulo,descricao,solicitacao,finalizado_em,status")] PROJETOS pROJETOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pROJETOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.aprovador = new SelectList(db.PESSOAS, "id", "nome", pROJETOS.aprovador);
            ViewBag.responsavel = new SelectList(db.PESSOAS, "id", "nome", pROJETOS.responsavel);
            ViewBag.sistema = new SelectList(db.SISTEMAS, "id", "nome", pROJETOS.sistema);
            ViewBag.solicitacao = new SelectList(db.SOLICITACOES, "id", "id", pROJETOS.solicitacao);
            return View(pROJETOS);
        }

        // GET: PROJETOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PROJETOS pROJETOS = db.PROJETOS.Find(id);
            if (pROJETOS == null)
            {
                return HttpNotFound();
            }
            return View(pROJETOS);
        }

        // POST: PROJETOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PROJETOS pROJETOS = db.PROJETOS.Find(id);
            db.PROJETOS.Remove(pROJETOS);
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
