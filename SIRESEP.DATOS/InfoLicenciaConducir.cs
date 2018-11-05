using System;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DATOS
{
    public class InfoLicenciaConducir
    {
        [AutoIncrement]
        public int idLicenciaConducir { get; set; }
        public string licencia { get; set; }
    }
}
