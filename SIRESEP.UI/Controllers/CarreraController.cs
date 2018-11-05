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
    public class CarreraController : Controller
    {
        ICarrera carr;
        public CarreraController(ICarrera @object)
        {
            carr = new MCarrera();
        }

        public CarreraController()
        {
        }

        // GET: Carrera
        public ActionResult Index()
        {
            var lista = carr.ListarCarrera();
            var carreras = Mapper.Map<List<Models.Carrera>>(lista);
            return View(carreras);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Carrera carreras)
        {
            var carreraInsertar = Mapper.Map<DATOS.Carrera>(carreras);
            carr.InsertarCarrera(carreraInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var carrera = carr.BuscarCarrera(id);
            var carreraBuscar = Mapper.Map<Models.Carrera>(carrera);
            return View(carreraBuscar);
        }
        public ActionResult Edit(int id)
        {
            var carrera = carr.BuscarCarrera(id);
            var carreraBuscar = Mapper.Map<Models.Carrera>(carrera);
            return View(carreraBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.Carrera carrera_)
        {
            var carreraEditar = Mapper.Map<DATOS.Carrera>(carrera_);
            carr.ActualizarCarrera(carreraEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            carr.EliminarCarrera(id);
            return RedirectToAction("Index");
        }
    }
}