using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoLicenciaConducir
    {
        public int idLicenciaConducir { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Licencia es requerida")]
        [StringLength(10, ErrorMessage = "La carrera no debe poseer mas de 15 caracteres")]
        public string licencia { get; set; }
    }
}