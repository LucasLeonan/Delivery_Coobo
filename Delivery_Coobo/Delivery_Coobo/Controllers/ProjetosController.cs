using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Delivery_Coobo.Models;
using Delivery_Coobo.DAL;

namespace Delivery_Coobo.Controllers
{
    public class ProjetosController : Controller
    {
        private PMDContext db = new PMDContext();

        // GET: /Projetos/
        public ActionResult Index()
        {
            var projeto = db.Projeto.Include(p => p.Empresa);
            return View(projeto.ToList());
        }

        // GET: /Projetos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projetos projetos = db.Projeto.Find(id);
            if (projetos == null)
            {
                return HttpNotFound();
            }
            return View(projetos);
        }

        // GET: /Projetos/Create
        public ActionResult Create()
        {
            ViewBag.EmpresasID = new SelectList(db.Empresa, "EmpresasID", "Nome_Empresa");
            return View();
        }

        // POST: /Projetos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ProjeTosID,CategoriasID,EmpresasID,Titulo,Tipo,Cod_Proj,Descricao")] Projetos projetos)
        {
            if (ModelState.IsValid)
            {
                db.Projeto.Add(projetos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmpresasID = new SelectList(db.Empresa, "EmpresasID", "Nome_Empresa", projetos.EmpresasID);
            return View(projetos);
        }

        // GET: /Projetos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projetos projetos = db.Projeto.Find(id);
            if (projetos == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmpresasID = new SelectList(db.Empresa, "EmpresasID", "Nome_Empresa", projetos.EmpresasID);
            return View(projetos);
        }

        // POST: /Projetos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ProjeTosID,CategoriasID,EmpresasID,Titulo,Tipo,Cod_Proj,Descricao")] Projetos projetos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projetos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmpresasID = new SelectList(db.Empresa, "EmpresasID", "Nome_Empresa", projetos.EmpresasID);
            return View(projetos);
        }

        // GET: /Projetos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projetos projetos = db.Projeto.Find(id);
            if (projetos == null)
            {
                return HttpNotFound();
            }
            return View(projetos);
        }

        // POST: /Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projetos projetos = db.Projeto.Find(id);
            db.Projeto.Remove(projetos);
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
