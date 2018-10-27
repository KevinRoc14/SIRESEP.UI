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
    public class CertificacionesController : Controller
    {
        ICertificaciones cert;
        public CertificacionesController()
        {
            cert = new MCertificaciones();
        }
        // GET: Certificaciones
        public ActionResult Index()
        {
            var lista = cert.ListarCertificaciones();
            var certificaciones = Mapper.Map<List<Models.Certificaciones>>(lista);
            return View(certificaciones);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Certificaciones certificaciones)
        {
            var certificacionInsertar = Mapper.Map<DATOS.Certificaciones>(certificaciones);
            cert.InsertarCertificacion(certificacionInsertar);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var certificacion = cert.BuscarCertificacion(id);
            var certificacionBuscar = Mapper.Map<Models.Certificaciones>(certificacion);
            return View(certificacionBuscar);
        }
        public ActionResult Edit(int id)
        {
            var certificacion = cert.BuscarCertificacion(id);
            var certificacionBuscar = Mapper.Map<Models.Certificaciones>(certificacion);
            return View(certificacionBuscar);
        }
        [HttpPost]
        public ActionResult Edit(Models.Certificaciones certificacion)
        {
            var certificacionEditar = Mapper.Map<DATOS.Certificaciones>(certificacion);
            cert.ActualizarCertificacion(certificacionEditar);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            cert.EliminarCertificacion(id);
            return RedirectToAction("Index");
        }
    }
}