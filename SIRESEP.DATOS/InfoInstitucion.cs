using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;

namespace SIRESEP.DATOS
{
    public class InfoInstitucion
    {
        [AutoIncrement]
        public int idInstitucion { get; set; }
        public string nombreInstitucion { get; set; }
        public DateTime ano { get; set; }
    }
}
