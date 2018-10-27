using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class Carrera
    {
        public int idCarrera { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "La carrera es requerida")]
        [StringLength(10, ErrorMessage = "La carrera no debe poseer mas de 15 caracteres")]
        public string carrera { get; set; }
    }
}