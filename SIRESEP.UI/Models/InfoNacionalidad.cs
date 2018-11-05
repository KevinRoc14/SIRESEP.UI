using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoNacionalidad
    {
        public int idNacionalidad { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La Nacionalidad es requerida")]
        public string nacionalidad { get; set; }
    }
}