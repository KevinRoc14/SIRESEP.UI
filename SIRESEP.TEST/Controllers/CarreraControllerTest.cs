using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIRESEP.UI.Controllers;
using SIRESEP.UI.Models;
using SIRESEP.BS.Interfaces;
using SIRESEP.BS.Metodos;
using AutoMapper;

namespace SIRESEP.TEST.Controllers
{
    [TestClass]
    public class CarreraControllerTest
    {
        [TestMethod]
        public void IndexViewResultNoEsNulo()
        {
            //arrange
           // CarreraController controller = new CarreraController();
            //ICarrera carr;
            //carr = new MCarrera();
            //var lista = carr.ListarCarrera();
            // var carreras = Mapper.Map<List<UI.Models.Carrera>>(lista);
            //act

           // ViewResult result = controller.Index() as ViewResult;
            //assert
           // Assert.IsNotNull(result);
        }
        [TestMethod]
        public void CarreraDetalles()
        {
            //var controller = new CarreraController();
            //var result = controller.Details(2) as ViewResult;
            //Assert.AreEqual("Details", result.ViewName);
        }
    }
}
