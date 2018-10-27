using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
namespace SIRESEP.DATOS
{
    public class InfoGenero
    {
        [AutoIncrement]
        public int idGenero { get; set; }
        public string genero { get; set; }
    }
}
