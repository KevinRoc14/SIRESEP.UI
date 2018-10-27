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
    public class InfoGradoEstudioController : Controller
    {
        IInfoGradoEstudio grado;
        public InfoGradoEstudioController()
        {
            grado = new MInfoGradoEstudio();
        }
        // GET: InfoGradoEstudio
        public ActionResult Index()
        {
            var lista = grado.ListarGradoEstudio();
            var infogrados = Mapper.Map<List<Models.InfoGradoEstudio>>(lista);
            return View(infogrados);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoGradoEstudio infogrados)
        {
            var gradoInsertar = Mapper.Map<DATOS.InfoGradoEstudio>(infogrados);
            grado.InsertarGradoEstudio(gradoInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var infogrados = grado.BuscarGradoEstudio(id);
            var infogradosoBuscar = Mapper.Map<Models.InfoGradoEstudio>(infogrados);
            return View(infogradosoBuscar);
        }
        public ActionResult Edit(int id)
        {
            var infogrados = grado.BuscarGradoEstudio(id);
            var infogradosBuscar = Mapper.Map<Models.InfoGradoEstudio>(infogrados);
            return View(infogradosBuscar);
        }

        [HttpPost]
        public ActionResult Edit(Models.InfoGradoEstudio infogrados)
        {
            var infogradosEditar = Mapper.Map<DATOS.InfoGradoEstudio>(infogrados);
            grado.ActualizarGradoEstudio(infogradosEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            grado.EliminarGradoEstudio(id);
            return RedirectToAction("Index");
        }
    }
}