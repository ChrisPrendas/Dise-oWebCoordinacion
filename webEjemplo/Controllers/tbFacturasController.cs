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
    public class tbFacturasController : Controller
    {
        private dbVentasContext db = new dbVentasContext();

        // GET: tbFacturas
        public ActionResult Index()
        {
            var tbFactura = db.tbFactura.Include(t => t.tbLogin);
            return View(tbFactura.ToList());
        }

        // GET: tbFacturas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbFactura tbFactura = db.tbFactura.Find(id);
            if (tbFactura == null)
            {
                return HttpNotFound();
            }
            return View(tbFactura);
        }

        // GET: tbFacturas/Create
        public ActionResult Create()
        {
            ViewBag.idCliente = new SelectList(db.tbLogin, "idCliente", "nomCliente");
            return View();
        }

        // POST: tbFacturas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idFactura,fecha,idCliente,montoTotal")] tbFactura tbFactura)
        {
            if (ModelState.IsValid)
            {
                db.tbFactura.Add(tbFactura);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idCliente = new SelectList(db.tbLogin, "idCliente", "nomCliente", tbFactura.idCliente);
            return View(tbFactura);
        }

        // GET: tbFacturas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbFactura tbFactura = db.tbFactura.Find(id);
            if (tbFactura == null)
            {
                return HttpNotFound();
            }
            ViewBag.idCliente = new SelectList(db.tbLogin, "idCliente", "nomCliente", tbFactura.idCliente);
            return View(tbFactura);
        }

        // POST: tbFacturas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idFactura,fecha,idCliente,montoTotal")] tbFactura tbFactura)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbFactura).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idCliente = new SelectList(db.tbLogin, "idCliente", "nomCliente", tbFactura.idCliente);
            return View(tbFactura);
        }

        // GET: tbFacturas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbFactura tbFactura = db.tbFactura.Find(id);
            if (tbFactura == null)
            {
                return HttpNotFound();
            }
            return View(tbFactura);
        }

        // POST: tbFacturas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbFactura tbFactura = db.tbFactura.Find(id);
            db.tbFactura.Remove(tbFactura);
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
