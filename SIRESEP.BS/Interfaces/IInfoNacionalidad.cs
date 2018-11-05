using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.BS.Interfaces
{
    public interface IInfoNacionalidad
    {
        List<InfoNacionalidad> ListarInfoNacionalidad();
        InfoNacionalidad BuscarInfoNacionalidad(int idInfoNacionalidad);
        void InsertarInfoNacionalidad(InfoNacionalidad InfoNacionalidad);
        void ActualizarInfoNacionalidad(InfoNacionalidad InfoNacionalidad);
        void EliminarInfoNacionalidad(int idInfoNacionalidad);
    }
}
