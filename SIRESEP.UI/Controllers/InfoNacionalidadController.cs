using AutoMapper;
using SIRESEP.BS.Interfaces;
using SIRESEP.BS.Metodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SIRESEP.UI.Controllers
{
    public class InfoNacionalidadController : Controller
    {
        IInfoNacionalidad carr;
        public InfoNacionalidadController()
        {
            carr = new MInfoNacionalidad();
        }

        // GET: InfoNacionalidad
        public ActionResult Index()
        {
            var lista = carr.ListarInfoNacionalidad();
            var InfoNacionalidads = Mapper.Map<List<Models.InfoNacionalidad>>(lista);
            return View(InfoNacionalidads);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoNacionalidad InfoNacionalidads)
        {
            var InfoNacionalidadInsertar = Mapper.Map<DATOS.InfoNacionalidad>(InfoNacionalidads);
            carr.InsertarInfoNacionalidad(InfoNacionalidadInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var InfoNacionalidad = carr.BuscarInfoNacionalidad(id);
            var InfoNacionalidadBuscar = Mapper.Map<Models.InfoNacionalidad>(InfoNacionalidad);
            return View(InfoNacionalidadBuscar);
        }
        public ActionResult Edit(int id)
        {
            var InfoNacionalidad = carr.BuscarInfoNacionalidad(id);
            var InfoNacionalidadBuscar = Mapper.Map<Models.InfoNacionalidad>(InfoNacionalidad);
            return View(InfoNacionalidadBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoNacionalidad InfoNacionalidad_)
        {
            var InfoNacionalidadEditar = Mapper.Map<DATOS.InfoNacionalidad>(InfoNacionalidad_);
            carr.ActualizarInfoNacionalidad(InfoNacionalidadEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            carr.EliminarInfoNacionalidad(id);
            return RedirectToAction("Index");
        }
    }
}