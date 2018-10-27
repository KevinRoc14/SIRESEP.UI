using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class InfoNacionalidad
    {
        [AutoIncrement]
        public int idNacionalidad { get; set; }
        public string nacionalidad { get; set; }
    }
}
