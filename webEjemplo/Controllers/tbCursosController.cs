using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using webEjemplo;

namespace webEjemplo.Controllers
{
    public class tbCursosController : Controller
    {
        private BDPortafolioUcrContext db = new BDPortafolioUcrContext();

        // GET: tbCursos
        public ActionResult Index()
        {
            return View(db.tbCursos.ToList());
        }

        // GET: tbCursos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCursos tbCursos = db.tbCursos.Find(id);
            if (tbCursos == null)
            {
                return HttpNotFound();
            }
            return View(tbCursos);
        }

        // GET: tbCursos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbCursos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad,nombrePrograma")] tbCursos tbCursos)
        {
            if (ModelState.IsValid)
            {
                db.tbCursos.Add(tbCursos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbCursos);
        }

        // GET: tbCursos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCursos tbCursos = db.tbCursos.Find(id);
            if (tbCursos == null)
            {
                return HttpNotFound();
            }
            return View(tbCursos);
        }

        // POST: tbCursos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCurso,sigla,nombre,lugar,ciclo,creditos,programa,estado,totalHoras,modalidad,nombrePrograma")] tbCursos tbCursos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbCursos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbCursos);
        }

        // GET: tbCursos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbCursos tbCursos = db.tbCursos.Find(id);
            if (tbCursos == null)
            {
                return HttpNotFound();
            }
            return View(tbCursos);
        }

        // POST: tbCursos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbCursos tbCursos = db.tbCursos.Find(id);
            db.tbCursos.Remove(tbCursos);
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
