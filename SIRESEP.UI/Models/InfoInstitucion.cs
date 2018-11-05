﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIRESEP.UI.Models
{
    public class InfoInstitucion
    {
        public int idInstitucion { get; set; }
        [Display(Name = "Nombre de Institucion")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "el nombre es requerido")]
        public string nombreInstitucion { get; set; }
        [Display(Name = "Año")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "el año es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime ano { get; set; }
    }
}