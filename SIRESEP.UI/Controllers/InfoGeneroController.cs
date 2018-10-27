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
    public class InfoGeneroController : Controller
    {
        IInfoGenero infog;
        public InfoGeneroController()
        {
            infog = new MInfoGenero();
        }

        // GET: InfoGenero
        public ActionResult Index()
        {
            var lista = infog.ListarInfoGenero();
            var infoGeneros = Mapper.Map<List<Models.InfoGenero>>(lista);
            return View(infoGeneros);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoGenero infoGeneros)
        {
            var infoGeneroInsertar = Mapper.Map<DATOS.InfoGenero>(infoGeneros);
            infog.InsertarInfoGenero(infoGeneroInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var infoGeneros = infog.BuscarInfoGenero(id);
            var infoGeneroBuscar = Mapper.Map<Models.InfoGenero>(infoGeneros);
            return View(infoGeneroBuscar);
        }
        public ActionResult Edit(int id)
        {
            var infoGeneros = infog.BuscarInfoGenero(id);
            var infoGeneroBuscar = Mapper.Map<Models.InfoGenero>(infoGeneros);
            return View(infoGeneroBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoGenero infoGeneros)
        {
            var infoGeneroEditar = Mapper.Map<DATOS.InfoGenero>(infoGeneros);
            infog.ActualizarInfoGenero(infoGeneroEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            infog.EliminarInfoGenero(id);
            return RedirectToAction("Index");
        }
    }
}