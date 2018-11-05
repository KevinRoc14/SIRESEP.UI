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
    public class InfoLaboralController : Controller
    {
        IInfoLaboral carr;
        public InfoLaboralController()
        {
            carr = new MInfoLaboral();
        }

        // GET: InfoLaboral
        public ActionResult Index()
        {
            var lista = carr.ListarInfoLaboral();
            var InfoLaborals = Mapper.Map<List<Models.InfoLaboral>>(lista);
            return View(InfoLaborals);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoLaboral InfoLaborals)
        {
            var InfoLaboralInsertar = Mapper.Map<DATOS.InfoLaboral>(InfoLaborals);
            carr.InsertarInfoLaboral(InfoLaboralInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var InfoLaboral = carr.BuscarInfoLaboral(id);
            var InfoLaboralBuscar = Mapper.Map<Models.InfoLaboral>(InfoLaboral);
            return View(InfoLaboralBuscar);
        }
        public ActionResult Edit(int id)
        {
            var InfoLaboral = carr.BuscarInfoLaboral(id);
            var InfoLaboralBuscar = Mapper.Map<Models.InfoLaboral>(InfoLaboral);
            return View(InfoLaboralBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoLaboral InfoLaboral_)
        {
            var InfoLaboralEditar = Mapper.Map<DATOS.InfoLaboral>(InfoLaboral_);
            carr.ActualizarInfoLaboral(InfoLaboralEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            carr.EliminarInfoLaboral(id);
            return RedirectToAction("Index");
        }
    }
}