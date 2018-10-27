using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoGenero
    {
        public int idGenero { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el genero es requerido")]
        [StringLength(10, ErrorMessage = "El genero no puede tener mas de 10 caracteres")]
        public string genero { get; set; }
    }
}