using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace SIRESEP.DATOS
{
    public class InfoLaboral
    {
        [AutoIncrement]
        public int idInfoLaboral { get; set; }
        public string profesion { get; set; }
        public int tiempoExperiencia { get; set; }
    }
}
