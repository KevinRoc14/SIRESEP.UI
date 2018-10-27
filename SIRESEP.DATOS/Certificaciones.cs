using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace SIRESEP.DATOS
{
    public class Certificaciones
    {
        [AutoIncrement]
        public int idCertificacion { get; set; }
        public string nombre { get; set; }
        public DateTime ano { get; set; }
    }
}
