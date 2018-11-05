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
    public class InfoLicenciaConducirController : Controller
    {
        IInfoLicenciaConducir licc;
        public InfoLicenciaConducirController()
        {
            licc = new MInfoLicenciaConducir();
        }

        // GET: InfoLicenciaConducir
        public ActionResult Index()
        {
            var lista = licc.ListarInfoLicenciaConducir();
            var InfoLicenciaConducirs = Mapper.Map<List<Models.InfoLicenciaConducir>>(lista);
            return View(InfoLicenciaConducirs);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoLicenciaConducir InfoLicenciaConducirs)
        {
            var InfoLicenciaConducirInsertar = Mapper.Map<DATOS.InfoLicenciaConducir>(InfoLicenciaConducirs);
            licc.InsertarInfoLicenciaConducir(InfoLicenciaConducirInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var InfoLicenciaConducir = licc.BuscarInfoLicenciaConducir(id);
            var InfoLicenciaConducirBuscar = Mapper.Map<Models.InfoLicenciaConducir>(InfoLicenciaConducir);
            return View(InfoLicenciaConducirBuscar);
        }
        public ActionResult Edit(int id)
        {
            var InfoLicenciaConducir = licc.BuscarInfoLicenciaConducir(id);
            var InfoLicenciaConducirBuscar = Mapper.Map<Models.InfoLicenciaConducir>(InfoLicenciaConducir);
            return View(InfoLicenciaConducirBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoLicenciaConducir InfoLicenciaConducir_)
        {
            var InfoLicenciaConducirEditar = Mapper.Map<DATOS.InfoLicenciaConducir>(InfoLicenciaConducir_);
            licc.ActualizarInfoLicenciaConducir(InfoLicenciaConducirEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            licc.EliminarInfoLicenciaConducir(id);
            return RedirectToAction("Index");
        }
    }
}