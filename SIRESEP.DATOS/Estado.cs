using System;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DATOS
{
    public class Estado
    {
        [AutoIncrement]
        public int idEstado { get; set; }
        public string estado { get; set; }
        public string usuarioCrea { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuarioModifica { get; set; }
        public DateTime FechaModifica { get; set; }
    }
}
