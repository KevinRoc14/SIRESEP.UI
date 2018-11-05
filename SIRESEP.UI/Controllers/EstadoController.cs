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
    public class EstadoController : Controller
    {
        IEstado infog;
        public EstadoController()
        {
            infog = new MEstado();
        }

        // GET: Estado
        public ActionResult Index()
        {
            var lista = infog.ListarEstado();
            var Estados = Mapper.Map<List<Models.Estado>>(lista);
            return View(Estados);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Estado Estados)
        {
            var EstadoInsertar = Mapper.Map<DATOS.Estado>(Estados);
            infog.InsertarEstado(EstadoInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var Estados = infog.BuscarEstado(id);
            var EstadoBuscar = Mapper.Map<Models.Estado>(Estados);
            return View(EstadoBuscar);
        }
        public ActionResult Edit(int id)
        {
            var Estados = infog.BuscarEstado(id);
            var EstadoBuscar = Mapper.Map<Models.Estado>(Estados);
            return View(EstadoBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.Estado Estados)
        {
            var EstadoEditar = Mapper.Map<DATOS.Estado>(Estados);
            infog.ActualizarEstado(EstadoEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            infog.EliminarEstado(id);
            return RedirectToAction("Index");
        }
    }
}