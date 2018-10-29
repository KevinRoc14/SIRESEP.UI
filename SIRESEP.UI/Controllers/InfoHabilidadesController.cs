using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIRESEP.BS.Interfaces;
using SIRESEP.BS.Metodos;
using AutoMapper;

namespace SIRESEP.UI.Controllers
{
    public class InfoHabilidadesController : Controller
    {
        IInfoHabilidades habi;
        public InfoHabilidadesController()
        {
            habi = new MInfoHabilidades();
        }
        // GET: InfoHabilidades
        public ActionResult Index()
        {
            var lista = habi.ListarHabilidades();
            var habilidadades = Mapper.Map<List<Models.InfoHabilidad>>(lista);
            return View(habilidadades);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoHabilidad habilidad_)
        {
            var habilidadInsertar = Mapper.Map<DATOS.InfoHabilidad>(habilidad_);
            habi.InsertarHabilidad(habilidadInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var habilidad = habi.BuscarHabilidad(id);
            var habilidadBuscar = Mapper.Map<Models.InfoHabilidad>(habilidad);
            return View(habilidadBuscar);
        }
        public ActionResult Edit(int id)
        {
            var habilidad = habi.BuscarHabilidad(id);
            var habilidadBuscar = Mapper.Map<Models.InfoHabilidad>(habilidad);
            return View(habilidadBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoHabilidad habilidad_)
        {
            var habilidadEditar = Mapper.Map<DATOS.InfoHabilidad>(habilidad_);
            habi.ActualizarHabilidad(habilidadEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            habi.EliminarHabilidad(id);
            return RedirectToAction("Index");
        }
    }
}