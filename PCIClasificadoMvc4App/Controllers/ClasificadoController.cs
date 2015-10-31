using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using PCIClasificadoMvc4App.Models;

namespace PCIClasificadoMvc4App.Controllers {
    public class ClasificadoController : Controller {
        //declaro la variable db como tipo de dato ClasificadoEntities... 
        //y la asocio a un objeto nuevo del tipo ClasificadoEntities 
        private ClasificadoEntities db = new ClasificadoEntities();
        //
        // GET: /Clasificado/

        public ActionResult Index()
        {
            //declara una variable clasificados del tipo List de Clasificado
            //List<Clasificado> usa generics.
            List<Clasificado> clasificados = db.Clasificado.ToList();
            return View(clasificados);
            //return View(db.Clasificado.ToList());
        }

        [HttpPost]
        public ActionResult Create(Clasificado clasificado)
        {
            if (ModelState.IsValid)
            {
                db.Clasificado.Add(clasificado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clasificado);
        }
        public ActionResult Edit(long id)
        {
            //return View(db.Clasificado.Where(c => c.clasificadoId.Equals(id)).First());
            return View(db.Clasificado.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Clasificado clasificado)
        {
            db.Entry(clasificado).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
        public ActionResult Delete(long id)
        {
            Clasificado clasificado = db.Clasificado.Find(id);
            db.Clasificado.Remove(clasificado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
