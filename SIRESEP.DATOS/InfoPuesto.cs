using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace SIRESEP.DATOS
{
    public class InfoPuesto
    {
        [AutoIncrement]
        public int idPuesto { get; set; }
        public string puesto { get; set; }
    }

}
