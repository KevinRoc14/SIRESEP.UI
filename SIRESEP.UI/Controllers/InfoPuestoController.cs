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
    public class InfoPuestoController : Controller
    {
        IInfoPuesto info;
        public InfoPuestoController()
        {
            info = new MInfoPuesto();
        }
        // GET: InfoPuesto
        public ActionResult Index()
        {
            var lista = info.ListarInfoPuesto();
            var infopuestos = Mapper.Map<List<Models.InfoPuesto>>(lista);
            return View(infopuestos);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoPuesto infopuestos)
        {
            var infoPuestoInsertar = Mapper.Map<DATOS.InfoPuesto>(infopuestos);
            info.InsertarInfoPuesto(infoPuestoInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var infopuesto = info.BuscarInfoPuesto(id);
            var infopuestoBuscar = Mapper.Map<Models.InfoPuesto>(infopuesto);
            return View(infopuestoBuscar);
        }
        public ActionResult Edit(int id)
        {
            var infopuesto = info.BuscarInfoPuesto(id);
            var infopuestoBuscar = Mapper.Map<Models.InfoPuesto>(infopuesto);
            return View(infopuestoBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoPuesto infopuesto)
        {
            var infopuestoEditar = Mapper.Map<DATOS.InfoPuesto>(infopuesto);
            info.ActualizarInfoPuesto(infopuestoEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            info.EliminarInfoPuesto(id);
            return RedirectToAction("Index");
        }
    }
}