using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PCIClasificadoMvc4App.Models;

namespace PCIClasificadoMvc4App.Controllers
{
    public class ClasificadoEstadoController : Controller
    {
        private ClasificadoEntities db = new ClasificadoEntities();

        //
        // GET: /ClasificadoEstado/

        public ActionResult Index()
        {
            return View(db.ClasificadoEstado.ToList());
        }

        //
        // GET: /ClasificadoEstado/Details/5

        public ActionResult Details(int id = 0)
        {
            ClasificadoEstado clasificadoestado = db.ClasificadoEstado.Find(id);
            if (clasificadoestado == null)
            {
                return HttpNotFound();
            }
            return View(clasificadoestado);
        }

        //
        // GET: /ClasificadoEstado/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ClasificadoEstado/Create

        [HttpPost]
        public ActionResult Create(ClasificadoEstado clasificadoestado)
        {
            if (ModelState.IsValid)
            {
                db.ClasificadoEstado.Add(clasificadoestado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasificadoestado);
        }

        //
        // GET: /ClasificadoEstado/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ClasificadoEstado clasificadoestado = db.ClasificadoEstado.Find(id);
            if (clasificadoestado == null)
            {
                return HttpNotFound();
            }
            return View(clasificadoestado);
        }

        //
        // POST: /ClasificadoEstado/Edit/5

        [HttpPost]
        public ActionResult Edit(ClasificadoEstado clasificadoestado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clasificadoestado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clasificadoestado);
        }

        //
        // GET: /ClasificadoEstado/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ClasificadoEstado clasificadoestado = db.ClasificadoEstado.Find(id);
            if (clasificadoestado == null)
            {
                return HttpNotFound();
            }
            return View(clasificadoestado);
        }

        //
        // POST: /ClasificadoEstado/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ClasificadoEstado clasificadoestado = db.ClasificadoEstado.Find(id);
            db.ClasificadoEstado.Remove(clasificadoestado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}