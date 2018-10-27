using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace SIRESEP.DATOS
{
    public class InfoGradoEstudio
    {
        [AutoIncrement]
        public int idGradoEstudio { get; set; }
        public string descripcion { get; set; }
    }
}
