using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SIRESEP.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
             name: "Carrera",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Carrera", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
           name: "Certificaciones",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "Certificaciones", action = "Index", id = UrlParameter.Optional }
       );
            routes.MapRoute(
           name: "Genero",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "InfoGenero", action = "Index", id = UrlParameter.Optional }
       );
            routes.MapRoute(
           name: "Puesto",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "InfoPuesto", action = "Index", id = UrlParameter.Optional }
       );
           routes.MapRoute(
           name: "InfoGradoo",
           url: "{controller}/{action}/{id}",
           defaults: new { controller = "InfoGradoEstudio", action = "Index", id = UrlParameter.Optional }
       );
        }
    }
}
