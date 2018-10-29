using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class InfoHabilidad
    {
        [AutoIncrement]
        public int idHabilidad { get; set; }
        public string habilidad { get; set; }
    }
}
