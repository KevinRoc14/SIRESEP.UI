using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoIdioma
    {
        public int idIdioma { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El Idioma es requerido")]
        public string idioma { get; set; }
    }
}