using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoGradoEstudio
    {
        public int idGradoEstudio { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el Grado es requerido")]
        public string descripcion { get; set; }
    }
}