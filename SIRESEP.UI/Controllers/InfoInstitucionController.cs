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
    public class InfoInstitucionController : Controller
    {
        IInfoInstitucion cert;
        public InfoInstitucionController()
        {
            cert = new MInfoInstitucion();
        }
        // GET: InfoInstitucion
        public ActionResult Index()
        {
            var lista = cert.ListarInfoInstitucion();
            var InfoInstitucion = Mapper.Map<List<Models.InfoInstitucion>>(lista);
            return View(InfoInstitucion);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.InfoInstitucion InfoInstitucion)
        {
            var InfoInstitucionInsertar = Mapper.Map<DATOS.InfoInstitucion>(InfoInstitucion);
            cert.InsertarInfoInstitucion(InfoInstitucionInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var InfoInstitucion = cert.BuscarInfoInstitucion(id);
            var InfoInstitucionBuscar = Mapper.Map<Models.InfoInstitucion>(InfoInstitucion);
            return View(InfoInstitucionBuscar);
        }
        public ActionResult Edit(int id)
        {
            var InfoInstitucion = cert.BuscarInfoInstitucion(id);
            var InfoInstitucionBuscar = Mapper.Map<Models.InfoInstitucion>(InfoInstitucion);
            return View(InfoInstitucionBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.InfoInstitucion InfoInstitucion)
        {
            var InfoInstitucionEditar = Mapper.Map<DATOS.InfoInstitucion>(InfoInstitucion);
            cert.ActualizarInfoInstitucion(InfoInstitucionEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            cert.EliminarInfoInstitucion(id);
            return RedirectToAction("Index");
        }
    }
}