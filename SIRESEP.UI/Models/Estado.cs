using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class Estado
    {
        public int idEstado { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "el nombre es requerido")]
        public string estado { get; set; }
        public string usuarioCrea { get; set; }
        [Display(Name = "Fecha Creacion")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "el ano es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime fechaCreacion { get; set; }
        public string usuarioModifica { get; set; }
        [Display(Name = "Fecha Modificacion")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "el ano es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaModifica { get; set; }
    }
}