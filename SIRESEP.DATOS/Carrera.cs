using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SIRESEP.DATOS
{
   public class Carrera
    {
        [AutoIncrement]
        public int idCarrera { get; set; }
        public string carrera { get; set; }
    }
}
