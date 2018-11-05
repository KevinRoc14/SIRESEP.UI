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
    public class InfoIdiomaController : Controller
    {
        IInfoIdioma carr;
        public InfoIdiomaController()
        {
            carr = new MInfoIdioma();
        }

        // GET: InfoIdioma
        public ActionResult Index()
        {
            var lista = carr.ListarInfoIdioma();
            var InfoIdiomas = Mapper.Map<List<Models.InfoIdioma>>(lista);
            return View(InfoIdiomas);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoIdioma InfoIdiomas)
        {
            var InfoIdiomaInsertar = Mapper.Map<DATOS.InfoIdioma>(InfoIdiomas);
            carr.InsertarInfoIdioma(InfoIdiomaInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var InfoIdioma = carr.BuscarInfoIdioma(id);
            var InfoIdiomaBuscar = Mapper.Map<Models.InfoIdioma>(InfoIdioma);
            return View(InfoIdiomaBuscar);
        }
        public ActionResult Edit(int id)
        {
            var InfoIdioma = carr.BuscarInfoIdioma(id);
            var InfoIdiomaBuscar = Mapper.Map<Models.InfoIdioma>(InfoIdioma);
            return View(InfoIdiomaBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoIdioma InfoIdioma_)
        {
            var InfoIdiomaEditar = Mapper.Map<DATOS.InfoIdioma>(InfoIdioma_);
            carr.ActualizarInfoIdioma(InfoIdiomaEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            carr.EliminarInfoIdioma(id);
            return RedirectToAction("Index");
        }
    }
}