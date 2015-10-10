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

    }
}
