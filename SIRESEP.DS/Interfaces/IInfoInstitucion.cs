using SIRESEP.DATOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRESEP.DS.Interfaces
{
    public interface IInfoInstitucion
    {
        List<InfoInstitucion> ListarInfoInstitucion();
        InfoInstitucion BuscarInfoInstitucion(int idInfoInstitucion);
        void InsertarInfoInstitucion(InfoInstitucion InfoInstitucion);
        void ActualizarInfoInstitucion(InfoInstitucion InfoInstitucion);
        void EliminarInfoInstitucion(int idInfoInstitucion);
    }
}
