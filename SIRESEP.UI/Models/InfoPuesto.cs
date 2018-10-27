using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoPuesto
    {
        public int idPuesto { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el puesto es requerido")]
        public string puesto { get; set; }
    }
}