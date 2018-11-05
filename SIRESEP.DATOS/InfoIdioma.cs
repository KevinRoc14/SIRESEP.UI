using System;
using ServiceStack.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DATOS
{
    public class InfoIdioma
    {
        [AutoIncrement]
        public int idIdioma { get; set; }
        public string idioma { get; set; }

    }
}
